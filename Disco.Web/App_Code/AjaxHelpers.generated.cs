﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.WebPages.Html;
    
    #line 2 "..\..\App_Code\AjaxHelpers.cshtml"
    using Disco.BI.Extensions;
    
    #line default
    #line hidden
    
    #line 3 "..\..\App_Code\AjaxHelpers.cshtml"
    using Disco.Web;
    
    #line default
    #line hidden
    
    #line 4 "..\..\App_Code\AjaxHelpers.cshtml"
    using Disco.Web.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public class AjaxHelpers : System.Web.WebPages.HelperPage
    {

public static System.Web.WebPages.HelperResult AjaxLoader(string id = null)
    {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 6 "..\..\App_Code\AjaxHelpers.cshtml"
     
        Html.GetPageHelper().BundleDeferred("~/ClientScripts/Modules/Disco-AjaxHelperIcons");

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "    <span ");



#line 8 "..\..\App_Code\AjaxHelpers.cshtml"
WriteTo(@__razor_helper_writer, id!=null ? new HtmlString(string.Format("id=\"{0}_loading\"", id)) : new HtmlString(string.Empty));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, " class=\"ajaxHelperIcon ajaxLoading\" title=\"Loading...\"></span>");



WriteLiteralTo(@__razor_helper_writer, "<span ");



#line 8 "..\..\App_Code\AjaxHelpers.cshtml"
                                                                                                                                                    WriteTo(@__razor_helper_writer, id != null ? new HtmlString(string.Format("id=\"{0}_ok\"", id)) : new HtmlString(string.Empty));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, " class=\"ajaxHelperIcon ajaxOk\"\r\n        title=\"Ok\"></span>\r\n");



#line 10 "..\..\App_Code\AjaxHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult AjaxSave()
    {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 12 "..\..\App_Code\AjaxHelpers.cshtml"
     
        Html.GetPageHelper().BundleDeferred("~/ClientScripts/Modules/Disco-AjaxHelperIcons");

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "    <span class=\"ajaxHelperIcon ajaxSave\" title=\"Save Changes\"></span>\r\n");



#line 15 "..\..\App_Code\AjaxHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult AjaxRemove()
    {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 17 "..\..\App_Code\AjaxHelpers.cshtml"
     
        Html.GetPageHelper().BundleDeferred("~/ClientScripts/Modules/Disco-AjaxHelperIcons");

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "    <span class=\"ajaxHelperIcon ajaxRemove\" title=\"Remove\"></span>\r\n");



#line 20 "..\..\App_Code\AjaxHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult JsonDate(DateTime? date)
    {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 22 "..\..\App_Code\AjaxHelpers.cshtml"
     
        if (date.HasValue)
        {
            var d = date.Value;
    
#line default
#line hidden


#line 26 "..\..\App_Code\AjaxHelpers.cshtml"
WriteTo(@__razor_helper_writer, new HtmlString(string.Format("new Date({0}, {1}, {2}, {3}, {4}, {5})", d.Year, d.Month - 1, d.Day, d.Hour, d.Minute, d.Second)));

#line default
#line hidden


#line 26 "..\..\App_Code\AjaxHelpers.cshtml"
                                                                                                                                      
        }
        else
        { 
    
#line default
#line hidden


#line 30 "..\..\App_Code\AjaxHelpers.cshtml"
WriteTo(@__razor_helper_writer, new HtmlString("null"));

#line default
#line hidden


#line 30 "..\..\App_Code\AjaxHelpers.cshtml"
                             
        }

#line default
#line hidden

});

}


        public AjaxHelpers()
        {
        }
    }
}
#pragma warning restore 1591
