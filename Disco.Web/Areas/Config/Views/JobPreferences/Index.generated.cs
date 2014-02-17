﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web.Areas.Config.Views.JobPreferences
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/JobPreferences/Index.cshtml")]
    public partial class Index : Disco.Services.Web.WebViewPage<Disco.Web.Areas.Config.Models.JobPreferences.IndexModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\JobPreferences\Index.cshtml"
  
    Authorization.Require(Claims.Config.JobPreferences.Show);

    var canConfig = Authorization.Has(Claims.Config.JobPreferences.Configure);

    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "Job Preferences");

    if (canConfig)
    {
        Html.BundleDeferred("~/ClientScripts/Modules/Disco-PropertyChangeHelpers");
        Html.BundleDeferred("~/ClientScripts/Modules/Disco-AjaxHelperIcons");
    }
    Html.RenderPartial(MVC.Config.JobPreferences.Views.Parts.General);
    Html.RenderPartial(MVC.Config.JobPreferences.Views.Parts.Locations);

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
