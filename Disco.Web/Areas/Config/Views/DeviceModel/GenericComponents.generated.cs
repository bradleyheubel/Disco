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

namespace Disco.Web.Areas.Config.Views.DeviceModel
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
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/DeviceModel/GenericComponents.cshtml")]
    public class GenericComponents : System.Web.Mvc.WebViewPage<Disco.Web.Areas.Config.Models.DeviceModel.DeviceComponentsModel>
    {
        public GenericComponents()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\DeviceModel\GenericComponents.cshtml"
  
    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "Device Models", MVC.Config.DeviceModel.Index(null), "Generic Components");

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 5 "..\..\Areas\Config\Views\DeviceModel\GenericComponents.cshtml"
Write(Html.Partial(MVC.Config.DeviceModel.Views._DeviceComponentsTable, Model));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
