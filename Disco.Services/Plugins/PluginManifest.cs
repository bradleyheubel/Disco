﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Disco.Data.Repository;
using Newtonsoft.Json;

namespace Disco.Services.Plugins
{
    public class PluginManifest
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public Version Version { get; set; }
        [JsonProperty]
        internal string AssemblyPath { get; set; }
        [JsonProperty]
        private string TypeName { get; set; }
        [JsonProperty]
        private string ConfigurationHandlerTypeName { get; set; }
        [JsonProperty]
        private string WebHandlerTypeName { get; set; }

        [JsonProperty]
        internal Dictionary<string, string> AssemblyReferences { get; set; }

        [JsonProperty]
        public List<PluginFeatureManifest> Features { get; private set; }

        [JsonIgnore]
        internal Assembly PluginAssembly { get; private set; }
        [JsonIgnore]
        internal Type Type { get; private set; }
        [JsonIgnore]
        private Type ConfigurationHandlerType { get; set; }
        [JsonIgnore]
        private Type WebHandlerType { get; set; }

        [JsonIgnore]
        public string PluginLocation { get; private set; }
        [JsonIgnore]
        public string StorageLocation { get; private set; }

        private static Dictionary<string, Tuple<string, DateTime>> WebResourceHashes = new Dictionary<string, Tuple<string, DateTime>>();

        public List<PluginFeatureManifest> GetFeatures(Type FeatureCategoryType)
        {
            return this.Features.Where(fm => fm.CategoryType.IsAssignableFrom(FeatureCategoryType)).ToList();
        }
        public PluginFeatureManifest GetFeature(string PluginFeatureId)
        {
            return this.Features.Where(fm => fm.Id == PluginFeatureId).FirstOrDefault();
        }

        public Plugin CreateInstance()
        {
            var i = (Plugin)Activator.CreateInstance(Type);
            i.Manifest = this;
            return i;
        }

        /// <summary>
        /// Deserializes a Json Manifest
        /// </summary>
        /// <param name="FilePath">Path to the Json Manifest file</param>
        /// <returns></returns>
        public static PluginManifest FromPluginManifestFile(string FilePath)
        {
            using (Stream manifestStream = File.OpenRead(FilePath))
            {
                PluginManifest manifest = FromPluginManifestFile(manifestStream, Path.GetDirectoryName(FilePath));
                return manifest;
            }
        }
        
        /// <summary>
        /// Deserializes a Json Manifest
        /// </summary>
        /// <param name="FileStream">Stream containing the encoded Json Manifest File</param>
        /// <param name="PluginLocation">PluginLocation to be set in the manifest</param>
        /// <returns></returns>
        public static PluginManifest FromPluginManifestFile(Stream FileStream, string PluginLocation = null)
        {
            string manifestString;
            using (StreamReader manifestStreamReader = new StreamReader(FileStream))
            {
                manifestString = manifestStreamReader.ReadToEnd();
            }

            var manifest = JsonConvert.DeserializeObject<PluginManifest>(manifestString);

            manifest.PluginLocation = PluginLocation;

            return manifest;
        }
        /// <summary>
        /// Uses reflection to build a Plugin Manifest
        /// </summary>
        /// <param name="pluginAssembly">Assembly containing a plugin</param>
        /// <returns>A plugin manifest for the first encountered plugin within the assembly</returns>
        public static PluginManifest FromPluginAssembly(Assembly assembly)
        {
            // Determine Plugin Properties
            var pluginType = (from type in assembly.GetTypes()
                              where typeof(Plugin).IsAssignableFrom(type) && !type.IsAbstract
                              select type).FirstOrDefault();

            if (pluginType == null)
                throw new ArgumentException("No Plugin was found in this Assembly", "pluginAssembly");

            var assemblyName = assembly.GetName();

            var pluginAttributes = pluginType.GetCustomAttribute<PluginAttribute>(false);

            if (pluginAttributes == null)
                throw new ArgumentException(string.Format("Plugin found [{0}], but no PluginAttribute found", pluginType.Name), "pluginAssembly");

            var pluginId = pluginAttributes.Id;
            var pluginName = pluginAttributes.Name;
            var pluginAuthor = pluginAttributes.Author;

            var pluginVersion = assemblyName.Version;
            var pluginAssemblyPath = Path.GetFileName(assembly.Location);
            var pluginTypeName = pluginType.FullName;
            var pluginLocation = Path.GetDirectoryName(assembly.Location);

            // Find Configuration Handler
            var pluginConfigurationHandlerType = (from type in assembly.GetTypes()
                                                  where typeof(PluginConfigurationHandler).IsAssignableFrom(type) && !type.IsAbstract
                                                  select type).FirstOrDefault();
            if (pluginConfigurationHandlerType == null)
                throw new ArgumentException("A Plugin was found, but no Configuration Handler was found in this Assembly - this is required", "pluginAssembly");

            // Find Web Handler
            var pluginWebHandlerType = (from type in assembly.GetTypes()
                                        where typeof(PluginWebHandler).IsAssignableFrom(type) && !type.IsAbstract
                                        select type).FirstOrDefault();

            Dictionary<string, string> pluginAssemblyReferences = new Dictionary<string, string>();
            foreach (string referenceFilename in Directory.EnumerateFiles(pluginLocation, "*.dll", SearchOption.TopDirectoryOnly))
            {
                if (!referenceFilename.Equals(assembly.Location, StringComparison.InvariantCultureIgnoreCase))
                {
                    try
                    {
                        Assembly pluginRefAssembly = Assembly.ReflectionOnlyLoadFrom(referenceFilename);
                        pluginAssemblyReferences[pluginRefAssembly.FullName] = referenceFilename.Substring(pluginLocation.Length + 1);
                    }
                    catch (Exception) { } // Ignore Load Exceptions
                }
            }

            PluginManifest pluginManifest = new PluginManifest()
            {
                Id = pluginId,
                Name = pluginName,
                Author = pluginAuthor,
                Version = pluginVersion,
                AssemblyPath = pluginAssemblyPath,
                TypeName = pluginTypeName,
                AssemblyReferences = pluginAssemblyReferences,
                PluginAssembly = assembly,
                Type = pluginType,
                PluginLocation = pluginLocation,
                ConfigurationHandlerType = pluginConfigurationHandlerType,
                ConfigurationHandlerTypeName = pluginConfigurationHandlerType.FullName,
                WebHandlerType = pluginWebHandlerType,
                WebHandlerTypeName = (pluginWebHandlerType == null ? null : pluginWebHandlerType.FullName)
            };

            pluginManifest.Features = (from type in assembly.GetTypes()
                                       where typeof(PluginFeature).IsAssignableFrom(type) && !type.IsAbstract
                                       select PluginFeatureManifest.FromPluginFeatureType(type, pluginManifest)).ToList();

            return pluginManifest;
        }

        public string ToManifestFile()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public bool InitializePlugin(DiscoDataContext dbContext)
        {
            var assemblyFullPath = Path.Combine(this.PluginLocation, this.AssemblyPath);

            if (!File.Exists(assemblyFullPath))
                throw new FileNotFoundException(string.Format("Plugin Assembly [{0}] not found at: {1}", this.Id, assemblyFullPath), assemblyFullPath);

            if (this.PluginAssembly == null)
                this.PluginAssembly = Assembly.LoadFile(assemblyFullPath);

            if (this.PluginAssembly == null)
                throw new InvalidOperationException(string.Format("Unable to load Plugin Assembly [{0}] at: {1}", this.Id, assemblyFullPath));

            PluginsLog.LogInitializingPluginAssembly(this.PluginAssembly);

            // Check Manifest/Assembly Versions Match
            if (this.Version != this.PluginAssembly.GetName().Version)
                throw new InvalidOperationException(string.Format("The plugin [{0}] manifest version [{1}] doesn't match the plugin assembly [{2} : {3}]", this.Id, this.Version, assemblyFullPath, this.PluginAssembly.GetName().Version));

            if (this.Type == null)
                this.Type = this.PluginAssembly.GetType(this.TypeName, true, true);

            if (this.ConfigurationHandlerType == null)
                this.ConfigurationHandlerType = this.PluginAssembly.GetType(this.ConfigurationHandlerTypeName, true, true);

            if (!string.IsNullOrEmpty(this.WebHandlerTypeName) && this.WebHandlerType == null)
                this.WebHandlerType = this.PluginAssembly.GetType(this.WebHandlerTypeName, true, true);

            // Update non-static values
            this.StorageLocation = Path.Combine(dbContext.DiscoConfiguration.PluginStorageLocation, this.Id);

            // Initialize Plugin
            using (var pluginInstance = this.CreateInstance())
            {
                pluginInstance.Initalize(dbContext);
            }
            PluginsLog.LogInitializedPlugin(this);

            // Initialize Plugin Features
            if (Features != null)
            {
                foreach (var feature in Features)
                {
                    feature.Initialize(dbContext, this);
                }
            }
            else
            {
                Features = new List<PluginFeatureManifest>();
            }

            return true;
        }

        public PluginConfigurationHandler CreateConfigurationHandler()
        {
            // Configuration Handler is Required
            if (this.ConfigurationHandlerType == null)
                throw new ArgumentNullException("ConfigurationType");
            if (!typeof(PluginConfigurationHandler).IsAssignableFrom(this.ConfigurationHandlerType))
                throw new ArgumentException("The Plugin ConfigurationHandlerType must inherit Disco.Services.Plugins.PluginConfigurationHandler", "ConfigurationHandlerType");

            var handler = (PluginConfigurationHandler)Activator.CreateInstance(this.ConfigurationHandlerType);

            handler.Manifest = this;

            return handler;
        }
        [JsonIgnore]
        public bool HasWebHandler
        {
            get
            {
                return this.WebHandlerType != null;
            }
        }
        public PluginWebHandler CreateWebHandler(Controller HostController)
        {
            // Web Handler is Not Required
            if (this.WebHandlerType == null)
                return null;

            if (!typeof(PluginWebHandler).IsAssignableFrom(this.WebHandlerType))
                throw new ArgumentException("The Plugin WebHandlerType must inherit Disco.Services.Plugins.PluginWebHandler", "WebHandlerType");

            var handler = (PluginWebHandler)Activator.CreateInstance(this.WebHandlerType);

            handler.Manifest = this;
            handler.HostController = HostController;

            return handler;
        }

        public Tuple<string, string> WebResourcePath(string Resource)
        {
            if (string.IsNullOrWhiteSpace(Resource))
                throw new ArgumentNullException("Resource");

            if (Resource.Contains(".."))
                throw new ArgumentException("Resource Paths cannot navigate to the parent", "Resource");

            var resourcePath = Path.Combine(this.PluginLocation, "WebResources", Resource.Replace(@"/", @"\"));

            Tuple<string, DateTime> resourceHash;
            string resourceKey = string.Format("{0}://{1}", this.Name, Resource);
            if (WebResourceHashes.TryGetValue(resourceKey, out resourceHash))
            {
#if DEBUG
                var fileDateCheck = System.IO.File.GetLastWriteTime(resourcePath);
                if (fileDateCheck == resourceHash.Item2)
#endif
                    return new Tuple<string, string>(resourcePath, resourceHash.Item1);
            }

            if (!File.Exists(resourcePath))
                throw new FileNotFoundException(string.Format("Resource [{0}] not found", Resource), resourcePath);

            var fileDate = System.IO.File.GetLastWriteTime(resourcePath);
            var fileBytes = System.IO.File.ReadAllBytes(resourcePath);
            if (fileBytes.Length > 0)
            {
                using (SHA256 sha = SHA256.Create())
                {
                    byte[] hash = sha.ComputeHash(fileBytes);
                    resourceHash = new Tuple<string, DateTime>(HttpServerUtility.UrlTokenEncode(hash), fileDate);
                }
            }
            WebResourceHashes[resourceKey] = resourceHash;

            return new Tuple<string, string>(resourcePath, resourceHash.Item1);
        }
    }
}
