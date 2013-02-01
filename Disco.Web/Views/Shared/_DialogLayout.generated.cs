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

namespace Disco.Web.Views.Shared
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_DialogLayout.cshtml")]
    public class DialogLayout : System.Web.Mvc.WebViewPage<dynamic>
    {
        public DialogLayout()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\_DialogLayout.cshtml"
  
    Html.BundleDeferred("~/Style/Dialog");
    Html.BundleDeferred("~/Style/Site");
    Html.BundleDeferred("~/ClientScripts/Core");

            
            #line default
            #line hidden
WriteLiteral("\r\n<!doctype html>\r\n<html>\r\n<head>\r\n    <title>Disco - ");

            
            #line 9 "..\..\Views\Shared\_DialogLayout.cshtml"
              Write(CommonHelpers.BreadcrumbsTitle(ViewBag.Title));

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <link");

WriteLiteral(" rel=\"shortcut icon\"");

WriteLiteral(" href=\"/favicon.ico\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"application-name\"");

WriteLiteral(" content=\"Disco\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"msapplication-starturl\"");

WriteLiteral(" content=\"/\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"msapplication-tooltip\"");

WriteLiteral(" content=\"Open Disco\"");

WriteLiteral(" />\r\n");

WriteLiteral("    ");

            
            #line 14 "..\..\Views\Shared\_DialogLayout.cshtml"
Write(Html.BundleRenderDeferred());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 15 "..\..\Views\Shared\_DialogLayout.cshtml"
Write(RenderSection("head", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n</head>\r\n<body");

WriteLiteral(" class=\"layoutDialog\"");

WriteLiteral(">\r\n    <section");

WriteLiteral(" id=\"layout_Page\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 19 "..\..\Views\Shared\_DialogLayout.cshtml"
   Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </section>\r\n</body>\r\n</html>");

        }
    }
}
#pragma warning restore 1591
