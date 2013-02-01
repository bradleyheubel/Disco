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

namespace Disco.Web.Views.Job.JobParts
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job/JobParts/Flags.cshtml")]
    public class Flags : System.Web.Mvc.WebViewPage<Disco.Web.Models.Job.ShowModel>
    {
        public Flags()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Job\JobParts\Flags.cshtml"
  
    var validFlags = Model.Job.ValidFlagsGrouped();

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"jobDetailTab-Flags\"");

WriteLiteral(" class=\"jobPart\"");

WriteLiteral(">\r\n    <table");

WriteLiteral(" id=\"jobFlags\"");

WriteLiteral(">\r\n");

            
            #line 7 "..\..\Views\Job\JobParts\Flags.cshtml"
        
            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Job\JobParts\Flags.cshtml"
         foreach (var flagGroup in validFlags)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <th>\r\n                    <span");

WriteLiteral(" class=\"flagGroupName\"");

WriteLiteral(">");

            
            #line 11 "..\..\Views\Job\JobParts\Flags.cshtml"
                                           Write(flagGroup.Key);

            
            #line default
            #line hidden
WriteLiteral("</span><br />\r\n");

WriteLiteral("                    ");

            
            #line 12 "..\..\Views\Job\JobParts\Flags.cshtml"
               Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
WriteLiteral("\r\n                </th>\r\n                <td>\r\n");

            
            #line 15 "..\..\Views\Job\JobParts\Flags.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Job\JobParts\Flags.cshtml"
                     foreach (var flagItem in flagGroup.Value)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div>\r\n                            <input");

WriteLiteral(" type=\"checkbox\"");

WriteAttribute("value", Tuple.Create(" value=\"", 609), Tuple.Create("\"", 632)
            
            #line 18 "..\..\Views\Job\JobParts\Flags.cshtml"
, Tuple.Create(Tuple.Create("", 617), Tuple.Create<System.Object, System.Int32>(flagItem.Item1
            
            #line default
            #line hidden
, 617), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 633), Tuple.Create("\"", 663)
, Tuple.Create(Tuple.Create("", 638), Tuple.Create("jobFlag_", 638), true)
            
            #line 18 "..\..\Views\Job\JobParts\Flags.cshtml"
         , Tuple.Create(Tuple.Create("", 646), Tuple.Create<System.Object, System.Int32>(flagItem.Item1
            
            #line default
            #line hidden
, 646), false)
);

WriteLiteral(" ");

            
            #line 18 "..\..\Views\Job\JobParts\Flags.cshtml"
                                                                                                      Write(flagItem.Item3 ? new HtmlString("checked=\"checked\"") : new HtmlString(string.Empty));

            
            #line default
            #line hidden
WriteLiteral(" /><label");

WriteAttribute("id", Tuple.Create(" id=\"", 762), Tuple.Create("\"", 797)
, Tuple.Create(Tuple.Create("", 767), Tuple.Create("jobFlagLabel_", 767), true)
            
            #line 18 "..\..\Views\Job\JobParts\Flags.cshtml"
                                                                                                                                               , Tuple.Create(Tuple.Create("", 780), Tuple.Create<System.Object, System.Int32>(flagItem.Item1
            
            #line default
            #line hidden
, 780), false)
);

WriteAttribute("for", Tuple.Create(" for=\"", 798), Tuple.Create("\"", 829)
, Tuple.Create(Tuple.Create("", 804), Tuple.Create("jobFlag_", 804), true)
            
            #line 18 "..\..\Views\Job\JobParts\Flags.cshtml"
                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 812), Tuple.Create<System.Object, System.Int32>(flagItem.Item1
            
            #line default
            #line hidden
, 812), false)
);

WriteLiteral(">");

            
            #line 18 "..\..\Views\Job\JobParts\Flags.cshtml"
                                                                                                                                                                                                                                                                           Write(flagItem.Item2);

            
            #line default
            #line hidden
WriteLiteral("</label></div>\r\n");

            
            #line 19 "..\..\Views\Job\JobParts\Flags.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n            </tr>\r\n");

            
            #line 22 "..\..\Views\Job\JobParts\Flags.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </table>\r\n    <div");

WriteLiteral(" id=\"dialogFlagsAction\"");

WriteLiteral(" title=\"Add Flag\"");

WriteLiteral(">\r\n");

            
            #line 25 "..\..\Views\Job\JobParts\Flags.cshtml"
        
            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Job\JobParts\Flags.cshtml"
         using (Html.BeginForm(MVC.API.Job.UpdateFlag(Model.Job.Id, null, null, true)))
        {

            
            #line default
            #line hidden
WriteLiteral("            <input");

WriteLiteral(" id=\"dialogFlagsActionFlag\"");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"Flag\"");

WriteLiteral(" value=\"0\"");

WriteLiteral(" />\r\n");

WriteLiteral("            <h3>\r\n                Reason:</h3>\r\n");

WriteLiteral("            <p>\r\n                <textarea");

WriteLiteral(" name=\"Reason\"");

WriteLiteral(" class=\"block\"");

WriteLiteral("></textarea>\r\n            </p>\r\n");

            
            #line 33 "..\..\Views\Job\JobParts\Flags.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        $('#jobDetailTabItems').append('<li><a href=""#jobDetailTab-Flags"">Flags</a></li>');
        $(function () {
            var $flagCheckboxes = $('#jobFlags').find('input[type=""checkbox""]');
            var $dialogFlagsAction = $('#dialogFlagsAction');
            var $flagCheckbox;

            var updateFlags = function () {
                $flagCheckbox = $(this);
                var flagValue = $flagCheckbox.val();

                if ($flagCheckbox.is(':checked')) {
                    // Add
                    $('#dialogFlagsActionFlag').val(flagValue);
                    var title = 'Add Flag: ' + $flagCheckbox.closest('tr').find('th .flagGroupName').text() + ': ' + $('#jobFlagLabel_' + flagValue).text();
                    $dialogFlagsAction.dialog('option', 'title', title);
                    $dialogFlagsAction.dialog('open');
                } else {
                    // Remove
                    var $ajaxLoading = $flagCheckbox.closest('tr').find('span.ajaxLoading');
                    $ajaxLoading.show();
                    $.getJSON('");

            
            #line 56 "..\..\Views\Job\JobParts\Flags.cshtml"
                           Write(Url.Action(MVC.API.Job.UpdateFlag(Model.Job.Id, null, null, false)));

            
            #line default
            #line hidden
WriteLiteral(@"', { Flag: '-' + flagValue }, function (response, result) {
                        if (result != 'success' || response != 'OK') {
                            alert('Unable to change Flag:\n' + response);
                            $ajaxLoading.hide();
                        } else {
                            $ajaxLoading.hide().next('.ajaxOk').show().delay('fast').fadeOut('slow');
                        }
                    })
                }
            };
            $dialogFlagsAction.dialog({
                resizable: false,
                height: 240,
                modal: true,
                autoOpen: false,
                buttons: {
                    ""Add"": function () {
                        var $this = $(this);
                        $this.dialog(""disable"");
                        $this.dialog(""option"", ""buttons"", null);
                        $this.find('form').first().submit();
                    },
                    Cancel: function () {
                        $(this).dialog(""close"");
                    }
                },
                close: function () {
                    $flagCheckbox.attr('checked', false);
                }
            });

            $flagCheckboxes.click(updateFlags);
        });
    </script>
</div>
");

        }
    }
}
#pragma warning restore 1591
