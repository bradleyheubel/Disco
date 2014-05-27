﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web.Views.Device
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
    using Disco;
    using Disco.BI.Extensions;
    using Disco.Models.Repository;
    using Disco.Services;
    using Disco.Services.Authorization;
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Device/ImportHeaders.cshtml")]
    public partial class ImportHeaders : Disco.Services.Web.WebViewPage<Disco.Web.Models.Device.ImportHeadersModel>
    {
        public ImportHeaders()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Device\ImportHeaders.cshtml"
  
    Authorization.Require(Claims.Device.Actions.Import);

    ViewBag.Title = Html.ToBreadcrumb("Devices", MVC.Device.Index(), "Import Devices", MVC.Device.Import(), string.Format("File: {0}", Model.Context.Filename));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"Devices_Import_Headers\"");

WriteLiteral(">\r\n\r\n    <h2>Define Import Columns</h2>\r\n\r\n");

            
            #line 11 "..\..\Views\Device\ImportHeaders.cshtml"
    
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\Device\ImportHeaders.cshtml"
     if (Model.Context.RawData.Count > 10)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h4");

WriteLiteral(" class=\"alert\"");

WriteLiteral(">");

            
            #line 13 "..\..\Views\Device\ImportHeaders.cshtml"
                     Write(Model.Context.RawData.Count);

            
            #line default
            #line hidden
WriteLiteral(" records were loaded, only the first 10 are shown here.</h4>\r\n");

            
            #line 14 "..\..\Views\Device\ImportHeaders.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <h4");

WriteLiteral(" id=\"Devices_Import_Headers_DeviceSerialNumberRequired\"");

WriteLiteral(" class=\"error\"");

WriteLiteral(">The Device Serial Number column must be defined.</h4>\r\n\r\n    <div");

WriteLiteral(" id=\"Devices_Import_Headers_TableContainer\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"tableData\"");

WriteLiteral(">\r\n            <thead>\r\n                <tr>\r\n");

            
            #line 22 "..\..\Views\Device\ImportHeaders.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Device\ImportHeaders.cshtml"
                     foreach (var header in Model.Context.Header.Select((h, i) => Tuple.Create(h, i)))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <th");

WriteLiteral(" data-headerindex=\"");

            
            #line 24 "..\..\Views\Device\ImportHeaders.cshtml"
                                         Write(header.Item2);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("class", Tuple.Create(" class=\"", 984), Tuple.Create("\"", 1030)
, Tuple.Create(Tuple.Create("", 992), Tuple.Create("header", 992), true)
            
            #line 24 "..\..\Views\Device\ImportHeaders.cshtml"
, Tuple.Create(Tuple.Create("", 998), Tuple.Create<System.Object, System.Int32>(header.Item1.Item2.ToString()
            
            #line default
            #line hidden
, 998), false)
);

WriteLiteral(">");

            
            #line 24 "..\..\Views\Device\ImportHeaders.cshtml"
                                                                                                       Write(header.Item1.Item1);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n");

            
            #line 25 "..\..\Views\Device\ImportHeaders.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </tr>\r\n                <tr>\r\n");

            
            #line 28 "..\..\Views\Device\ImportHeaders.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Device\ImportHeaders.cshtml"
                     foreach (var header in Model.Context.Header.Select((h, i) => Tuple.Create(h, i)))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <td");

WriteLiteral(" data-headerindex=\"");

            
            #line 30 "..\..\Views\Device\ImportHeaders.cshtml"
                                         Write(header.Item2);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("class", Tuple.Create(" class=\"", 1313), Tuple.Create("\"", 1359)
, Tuple.Create(Tuple.Create("", 1321), Tuple.Create("header", 1321), true)
            
            #line 30 "..\..\Views\Device\ImportHeaders.cshtml"
, Tuple.Create(Tuple.Create("", 1327), Tuple.Create<System.Object, System.Int32>(header.Item1.Item2.ToString()
            
            #line default
            #line hidden
, 1327), false)
);

WriteLiteral(">\r\n                            <ul");

WriteLiteral(" class=\"importHeaderType\"");

WriteLiteral(" data-headerindex=\"");

            
            #line 31 "..\..\Views\Device\ImportHeaders.cshtml"
                                                                      Write(header.Item2);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-headertype=\"");

            
            #line 31 "..\..\Views\Device\ImportHeaders.cshtml"
                                                                                                      Write(header.Item1.Item2.ToString());

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                                <li><a");

WriteLiteral(" href=\"#\"");

WriteLiteral("><span");

WriteLiteral(" class=\"headerTypeTitle\"");

WriteLiteral(">");

            
            #line 32 "..\..\Views\Device\ImportHeaders.cshtml"
                                                                          Write(Model.HeaderTypes.FirstOrDefault(h => h.Item1 == header.Item1.Item2).Item2);

            
            #line default
            #line hidden
WriteLiteral("</span></a>\r\n                                    <ul>\r\n");

            
            #line 34 "..\..\Views\Device\ImportHeaders.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\Device\ImportHeaders.cshtml"
                                         foreach (var headerType in Model.HeaderTypes)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <li");

WriteLiteral(" data-headertype=\"");

            
            #line 36 "..\..\Views\Device\ImportHeaders.cshtml"
                                                            Write(headerType.Item1);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">");

            
            #line 36 "..\..\Views\Device\ImportHeaders.cshtml"
                                                                                           Write(headerType.Item2);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 37 "..\..\Views\Device\ImportHeaders.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </ul>\r\n                                </li>\r" +
"\n                            </ul>\r\n                        </td>\r\n");

            
            #line 42 "..\..\Views\Device\ImportHeaders.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </tr>\r\n            </thead>\r\n            <tbody>\r\n");

            
            #line 46 "..\..\Views\Device\ImportHeaders.cshtml"
                
            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\Device\ImportHeaders.cshtml"
                 foreach (var record in Model.Context.RawData.Take(10))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <tr>\r\n");

            
            #line 49 "..\..\Views\Device\ImportHeaders.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Device\ImportHeaders.cshtml"
                         foreach (var field in record.Select((h, i) => Tuple.Create(h, i)))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <td");

WriteLiteral(" data-headerindex=\"");

            
            #line 51 "..\..\Views\Device\ImportHeaders.cshtml"
                                             Write(field.Item2);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">");

            
            #line 51 "..\..\Views\Device\ImportHeaders.cshtml"
                                                           Write(field.Item1);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 52 "..\..\Views\Device\ImportHeaders.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </tr>\r\n");

            
            #line 54 "..\..\Views\Device\ImportHeaders.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"actionBar\"");

WriteLiteral(">\r\n");

            
            #line 59 "..\..\Views\Device\ImportHeaders.cshtml"
        
            
            #line default
            #line hidden
            
            #line 59 "..\..\Views\Device\ImportHeaders.cshtml"
         using (Html.BeginForm(MVC.API.Device.ImportParse(Model.Context.SessionId, null)))
        {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteLiteral(" id=\"Devices_Import_Headers_Submit\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Parse Device Import</a>   \r\n");

            
            #line 62 "..\..\Views\Device\ImportHeaders.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n<div");

WriteLiteral(" id=\"Devices_Import_Parsing_Dialog\"");

WriteLiteral(" class=\"dialog\"");

WriteLiteral(" title=\"Parsing devices import...\"");

WriteLiteral(">\r\n    <h4><i");

WriteLiteral(" class=\"fa fa-lg fa-cog fa-spin\"");

WriteLiteral(" title=\"Please Wait\"");

WriteLiteral("></i>Parsing device import...</h4>\r\n</div>\r\n<script>\r\n    $(function () {\r\n      " +
"  var headerTypes = {\r\n");

            
            #line 71 "..\..\Views\Device\ImportHeaders.cshtml"
            
            
            #line default
            #line hidden
            
            #line 71 "..\..\Views\Device\ImportHeaders.cshtml"
             foreach (var h in Model.HeaderTypes)
            {

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("\'");

            
            #line 73 "..\..\Views\Device\ImportHeaders.cshtml"
                   Write(h.Item1);

            
            #line default
            #line hidden
WriteLiteral("\': \'");

            
            #line 73 "..\..\Views\Device\ImportHeaders.cshtml"
                                 Write(h.Item2);

            
            #line default
            #line hidden
WriteLiteral("\',");

WriteLiteral("\r\n");

            
            #line 74 "..\..\Views\Device\ImportHeaders.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        };\r\n\r\n        var $Devices_Import_Headers_TableContainer = $(\'#Devices_Im" +
"port_Headers_TableContainer\');\r\n        var $importHeaderTypes = $Devices_Import" +
"_Headers_TableContainer.find(\'thead\').find(\'ul.importHeaderType\');\r\n        var " +
"$Devices_Import_Headers_DeviceSerialNumberRequired = $(\'#Devices_Import_Headers_" +
"DeviceSerialNumberRequired\');\r\n        var $Devices_Import_Headers_Submit = $(\'#" +
"Devices_Import_Headers_Submit\');\r\n        var $Devices_Import_Parsing_Dialog = n" +
"ull;\r\n\r\n        function getUsedHeaders() {\r\n            return $importHeaderTyp" +
"es.map(function () { return $(this).attr(\'data-headertype\'); }).filter(function " +
"() { return this != \'IgnoreColumn\' }).get();\r\n        }\r\n\r\n        function upda" +
"teHeaderOptions() {\r\n            var usedHeaders = getUsedHeaders();\r\n          " +
"  var deviceSerialNumberPresent = (usedHeaders.indexOf(\'DeviceSerialNumber\') >= " +
"0);\r\n\r\n            if (deviceSerialNumberPresent) {\r\n                $Devices_Im" +
"port_Headers_Submit.attr(\'disabled\', null);\r\n                $Devices_Import_Hea" +
"ders_DeviceSerialNumberRequired.hide();\r\n            } else {\r\n                $" +
"Devices_Import_Headers_DeviceSerialNumberRequired.show();\r\n                $Devi" +
"ces_Import_Headers_Submit.attr(\'disabled\', \'disabled\');\r\n            }\r\n\r\n      " +
"      $importHeaderTypes.each(function () {\r\n                var $header = $(thi" +
"s);\r\n                var $headerType = $header.attr(\'data-headertype\');\r\n       " +
"         $header.find(\'li[data-headertype]\').each(function () {\r\n               " +
"     var $headerOption = $(this);\r\n                    var $headerOptionType = $" +
"headerOption.attr(\'data-headertype\');\r\n                    if ($headerOptionType" +
" === $headerType) {\r\n                        $headerOption.removeClass(\'ui-state" +
"-disabled\');\r\n                        $headerOption.addClass(\'ui-state-highlight" +
"\');\r\n                    } else if (usedHeaders.indexOf($headerOptionType) < 0) " +
"{\r\n                        $headerOption.removeClass(\'ui-state-disabled ui-state" +
"-highlight\');\r\n                    } else {\r\n                        $headerOpti" +
"on.removeClass(\'ui-state-highlight\');\r\n                        $headerOption.add" +
"Class(\'ui-state-disabled\');\r\n                    }\r\n                })\r\n        " +
"    });\r\n        }\r\n\r\n        function updateDataStyle(index, headerType) {\r\n   " +
"         $Devices_Import_Headers_TableContainer.find(\'tbody\').find(\'td[data-head" +
"erindex=\"\' + index + \'\"]\').removeClass().addClass(\'header\' + headerType);\r\n     " +
"       $Devices_Import_Headers_TableContainer.find(\'thead\').find(\'td[data-header" +
"index=\"\' + index + \'\"], th[data-headerindex=\"\' + index + \'\"]\').removeClass().add" +
"Class(\'header\' + headerType);\r\n        }\r\n\r\n        $Devices_Import_Headers_Tabl" +
"eContainer.find(\'thead\').on(\'menuselect\', \'ul.importHeaderType\', function (e, ui" +
") {\r\n            var headerType = ui.item.attr(\'data-headertype\');\r\n\r\n          " +
"  if (headerType !== undefined) {\r\n                var $this = $(this).closest(\'" +
"ul.importHeaderType\');\r\n                var headerIndex = $this.attr(\'data-heade" +
"rindex\');\r\n                var headerTypeName = headerTypes[headerType];\r\n      " +
"          $this.attr(\'data-headertype\', headerType).find(\'span.headerTypeTitle\')" +
".text(headerTypeName);\r\n                updateDataStyle(headerIndex, headerType)" +
";\r\n                updateHeaderOptions();\r\n            }\r\n        });\r\n\r\n       " +
" // Add Type Options\r\n        $importHeaderTypes.each(function () {\r\n           " +
" var $this = $(this);\r\n            var thisHeaderIndex = $this.attr(\'data-header" +
"index\');\r\n            var thisHeaderType = $this.attr(\'data-headertype\');\r\n     " +
"       updateDataStyle(thisHeaderIndex, thisHeaderType);\r\n        }).menu({ posi" +
"tion: { my: \"left top\", at: \"left bottom\" } });\r\n\r\n        updateHeaderOptions()" +
";\r\n\r\n        $(\'#Devices_Import_Headers_Submit\').click(function () {\r\n\r\n        " +
"    // Validate Device Serial Number Present\r\n            var usedHeaders = getU" +
"sedHeaders();\r\n            var deviceSerialNumberPresent = (usedHeaders.indexOf(" +
"\'DeviceSerialNumber\') >= 0);\r\n            if (!deviceSerialNumberPresent) {\r\n   " +
"             updateHeaderOptions();\r\n                $Devices_Import_Headers_Dev" +
"iceSerialNumberRequired.show(\'highlight\');\r\n            } else {\r\n              " +
"  var $form = $(this).closest(\'form\');\r\n\r\n                // Build Form\r\n       " +
"         $importHeaderTypes.each(function () {\r\n                    var $this = " +
"$(this);\r\n                    var thisHeaderIndex = $this.attr(\'data-headerindex" +
"\');\r\n                    var thisHeaderType = $this.attr(\'data-headertype\');\r\n\r\n" +
"                    $(document.createElement(\'input\')).attr({ type: \'hidden\', na" +
"me: \'Headers[\' + thisHeaderIndex + \']\', value: thisHeaderType }).appendTo($form)" +
";\r\n                });\r\n\r\n                // Submit Form\r\n                if ($D" +
"evices_Import_Parsing_Dialog == null) {\r\n                    $Devices_Import_Par" +
"sing_Dialog = $(\'#Devices_Import_Parsing_Dialog\').dialog({\r\n                    " +
"    width: 400,\r\n                        height: 160,\r\n                        r" +
"esizable: false,\r\n                        modal: true,\r\n                        " +
"autoOpen: false\r\n                    });\r\n                }\r\n                $De" +
"vices_Import_Parsing_Dialog.dialog(\'open\');\r\n                $form.submit();\r\n  " +
"          }\r\n\r\n            return false;\r\n        });\r\n    });\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591