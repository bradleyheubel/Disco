﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web.Areas.Config.Views.Plugins
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Disco.BI.Extensions;
    using Disco.Models.Repository;
    
    #line 2 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
    using Disco.Services.Plugins;
    
    #line default
    #line hidden
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/Plugins/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<Disco.Web.Areas.Config.Models.Plugins.IndexViewModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
  
    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "Plugins");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"plugins\"");

WriteLiteral(">\r\n");

            
            #line 7 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 7 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
      
        if (Model.PluginManifests.Count == 0)
        { 

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 450px; padding: 100px 0;\"");

WriteLiteral(">\r\n            <h2>No Plugins are Installed</h2>\r\n        </div>  \r\n");

            
            #line 13 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
        }
        else
        {
            var pluginGroups = Model.PluginManifestsByCategory;


            int itemsPerColumn = pluginGroups.Count / 3;
            var itemNextId = 0;
    

            
            #line default
            #line hidden
WriteLiteral("        <table");

WriteLiteral(" id=\"pageMenu\"");

WriteLiteral(">\r\n            <tr>\r\n");

            
            #line 24 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 24 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
                 for (int i = 0; i < 3; i++)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td>\r\n");

            
            #line 27 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 27 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
                          
                    int itemsForThisColumn = itemsPerColumn + (pluginGroups.Count % 3 > i ? 1 : 0);
                    for (int i2 = 0; i2 < itemsForThisColumn && itemNextId < pluginGroups.Count; i2++)
                    {
                        var pluginGroup = pluginGroups[itemNextId];
                        itemNextId++;

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"pageMenuArea\"");

WriteLiteral(">\r\n                                <h2>");

            
            #line 34 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
                               Write(Plugins.PluginFeatureCategoryDisplayName(pluginGroup.Item1));

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n");

            
            #line 35 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 35 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
                                 foreach (var pluginDefinition in pluginGroup.Item2)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1439), Tuple.Create("\"", 1508)
            
            #line 37 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1446), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Config.Plugins.Configure(pluginDefinition.Id))
            
            #line default
            #line hidden
, 1446), false)
);

WriteLiteral(">\r\n                                        <h3>");

            
            #line 38 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
                                       Write(pluginDefinition.Name);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                                    </a>\r\n");

WriteLiteral("                                    <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(">\r\n                                        <span");

WriteLiteral(" class=\"pluginVersion\"");

WriteLiteral(">v");

            
            #line 41 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
                                                                 Write(pluginDefinition.VersionFormatted);

            
            #line default
            #line hidden
WriteLiteral("</span> | ");

            
            #line 41 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
                                                                                                              Write(pluginDefinition.Author);

            
            #line default
            #line hidden
WriteLiteral(" | <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1836), Tuple.Create("\"", 1864)
            
            #line 41 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
                                                                       , Tuple.Create(Tuple.Create("", 1843), Tuple.Create<System.Object, System.Int32>(pluginDefinition.Url
            
            #line default
            #line hidden
, 1843), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">More Information</a>\r\n                                    </div>\r\n");

            
            #line 43 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </div>\r\n");

            
            #line 45 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
                    }
                        
            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");

            
            #line 48 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n        </table>\r\n");

WriteLiteral("        <div");

WriteLiteral(" id=\"dialogUninstallPlugins\"");

WriteLiteral(" title=\"Uninstall Plugin\"");

WriteLiteral(">\r\n            <div>\r\n");

WriteLiteral("                ");

            
            #line 53 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
           Write(Html.DropDownList("uninstallPlugin", Model.PluginManifests.ToSelectListItems(null, true, "Select a Plugin to Uninstall")));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n            <div>\r\n                <input");

WriteLiteral(" id=\"uninstallPluginData\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" /><label");

WriteLiteral(" for=\"uninstallPluginData\"");

WriteLiteral("> Uninstall Plugin Data</label>\r\n                <div");

WriteLiteral(" id=\"uninstallPluginDataAlert\"");

WriteLiteral(" style=\"display: none; padding: 0.7em 0.7em; margin-top: 8px;\"");

WriteLiteral(" class=\"ui-state-error ui-corner-all\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" style=\"margin-right: 0.3em; float: left;\"");

WriteLiteral(" class=\"ui-icon ui-icon-alert\"");

WriteLiteral("></span>NOTE: Data will be permanently deleted\r\n                </div>\r\n         " +
"   </div>\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" id=\"dialogUninstallPluginConfirm\"");

WriteLiteral(" title=\"Confirm Plugin Uninstall\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" style=\"padding: 0.7em 0.7em; margin-top: 8px;\"");

WriteLiteral(" class=\"ui-state-highlight ui-corner-all\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" style=\"margin-right: 0.3em; float: left;\"");

WriteLiteral(" class=\"ui-icon ui-icon-help\"");

WriteLiteral("></span>Are you sure you want to uninstall this plugin?\r\n            <h4");

WriteLiteral(" id=\"uninstallPluginConfirm\"");

WriteLiteral("></h4>\r\n            </div>\r\n            <div");

WriteLiteral(" id=\"uninstallPluginDataConfirm\"");

WriteLiteral(" style=\"display: none; padding: 0.7em 0.7em; margin-top: 8px;\"");

WriteLiteral(" class=\"ui-state-error ui-corner-all\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" style=\"margin-right: 0.3em; float: left;\"");

WriteLiteral(" class=\"ui-icon ui-icon-alert\"");

WriteLiteral("></span>NOTE: Data will be permanently deleted\r\n            </div>\r\n        </div" +
">\r\n");

WriteLiteral("        <script>\r\n            $(function () {\r\n                // Uninstall\r\n    " +
"            var uninstallUrl = \'");

            
            #line 74 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
                                Write(Url.Action(MVC.API.Plugin.Uninstall()));

            
            #line default
            #line hidden
WriteLiteral("/\';\r\n                var uninstallPlugin, uninstallPluginData, $dialogConfirm, un" +
"installPluginConfirm, uninstallPluginDataConfirm;\r\n\r\n                var pluginI" +
"d, pluginName, pluginUninstallData;\r\n\r\n                var $dialog = $(\'#dialogU" +
"ninstallPlugins\').dialog({\r\n                    resizable: false,\r\n             " +
"       modal: true,\r\n                    width: 350,\r\n                    autoOp" +
"en: false,\r\n                    buttons: {\r\n                        \"Uninstall\":" +
" function () {\r\n                            pluginId = uninstallPlugin.val();\r\n " +
"                           pluginName = uninstallPlugin.find(\'option:selected\')." +
"text();\r\n                            pluginUninstallData = uninstallPluginData.i" +
"s(\':checked\');\r\n\r\n                            if (!pluginId) {\r\n                " +
"                alert(\'Select a plugin to uninstall\');\r\n                        " +
"    } else {\r\n                                uninstallPluginConfirm.text(plugin" +
"Name + \' [\' + pluginId + \']\');\r\n                                if (pluginUninst" +
"allData)\r\n                                    uninstallPluginDataConfirm.show();" +
"\r\n                                else\r\n                                    unin" +
"stallPluginDataConfirm.hide();\r\n\r\n                                $dialogConfirm" +
".dialog(\'open\');\r\n                                $(this).dialog(\"close\");\r\n    " +
"                        }\r\n                        },\r\n                        C" +
"ancel: function () {\r\n                            uninstallPluginData.prop(\'chec" +
"ked\', false);\r\n                            $(\'#uninstallPluginDataAlert\').hide()" +
";\r\n                            $(this).dialog(\"close\");\r\n                       " +
" }\r\n                    }\r\n                });\r\n\r\n                $dialogConfirm" +
" = $(\'#dialogUninstallPluginConfirm\').dialog({\r\n                    resizable: f" +
"alse,\r\n                    modal: true,\r\n                    width: 350,\r\n      " +
"              autoOpen: false,\r\n                    buttons: {\r\n                " +
"        \"Confirm Uninstall\": function () {\r\n                            var url " +
"= uninstallUrl + pluginId;\r\n                            if (pluginUninstallData)" +
"\r\n                                url += \'?UninstallData=true\'\r\n                " +
"            else\r\n                                url += \'?UninstallData=false\'\r" +
"\n\r\n                            window.location.href = url;\r\n                    " +
"        $(this).dialog(\"disable\");\r\n                        },\r\n                " +
"        Cancel: function () {\r\n                            uninstallPluginData.p" +
"rop(\'checked\', false);\r\n                            $(\'#uninstallPluginDataAlert" +
"\').hide();\r\n                            $(this).dialog(\"close\");\r\n              " +
"          }\r\n                    }\r\n                });\r\n\r\n                unins" +
"tallPlugin = $(\'#uninstallPlugin\');\r\n                uninstallPluginData = $(\'#u" +
"ninstallPluginData\');\r\n                uninstallPluginConfirm = $(\'#uninstallPlu" +
"ginConfirm\');\r\n                uninstallPluginDataConfirm = $(\'#uninstallPluginD" +
"ataConfirm\');\r\n\r\n                $(\'#buttonUninstall\').click(function () {\r\n    " +
"                $dialog.dialog(\'open\');\r\n                    return false;\r\n    " +
"            });\r\n\r\n                $(\'#uninstallPluginData\').change(function () " +
"{\r\n                    if ($(this).is(\':checked\')) {\r\n                        $(" +
"\'#uninstallPluginDataAlert\').slideDown();\r\n                    } else {\r\n       " +
"                 $(\'#uninstallPluginDataAlert\').slideUp();\r\n                    " +
"}\r\n                });\r\n            });\r\n        </script>\r\n");

            
            #line 154 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
        
                if (Model.PluginUpdates.Count > 0)
                {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"updateAvailableContainer\"");

WriteLiteral(">\r\n            <div>");

            
            #line 158 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
             Write(Model.PluginUpdates.Count);

            
            #line default
            #line hidden
WriteLiteral(" plugin update");

            
            #line 158 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
                                                       Write(Model.PluginUpdates.Count == 1 ? " is" : "s are");

            
            #line default
            #line hidden
WriteLiteral(" available</div>\r\n");

WriteLiteral("            ");

            
            #line 159 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
       Write(Html.ActionLinkButton("Update Now", MVC.API.Plugin.UpdateAll()));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n");

WriteLiteral(@"        <script>
            (function () {
                $(function () {
                    var layout_PageHeading = $('#layout_PageHeading').height(80);
                    var updateAvailableContainer = $('#updateAvailableContainer');
                    updateAvailableContainer.appendTo(layout_PageHeading);
                });
            })();
        </script>    
");

            
            #line 170 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
                }
        }
    
            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n<div");

WriteLiteral(" class=\"actionBar\"");

WriteLiteral(">\r\n");

            
            #line 175 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 175 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
     if (Model.PluginManifests.Count > 0)
    { 
        
            
            #line default
            #line hidden
            
            #line 177 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
   Write(Html.ActionLinkButton("Uninstall Plugins", MVC.Config.Plugins.Index(), "buttonUninstall"));

            
            #line default
            #line hidden
            
            #line 177 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
                                                                                                  
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 179 "..\..\Areas\Config\Views\Plugins\Index.cshtml"
Write(Html.ActionLinkButton("Install Plugins", MVC.Config.Plugins.Install()));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
