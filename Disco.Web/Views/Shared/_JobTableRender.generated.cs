﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
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
    using Disco;
    using Disco.BI.Extensions;
    using Disco.Models.Repository;
    
    #line 2 "..\..\Views\Shared\_JobTableRender.cshtml"
    using Disco.Models.Services.Jobs.JobLists;
    
    #line default
    #line hidden
    using Disco.Services;
    using Disco.Services.Authorization;
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_JobTableRender.cshtml")]
    public partial class JobTableRender : Disco.Services.Web.WebViewPage<Disco.Models.Services.Jobs.JobLists.JobTableModel>
    {
        public JobTableRender()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\_JobTableRender.cshtml"
  
    Html.BundleDeferred("~/ClientScripts/Modules/Disco-DataTableHelpers");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"jobTable\"");

WriteLiteral(">\r\n");

            
            #line 7 "..\..\Views\Shared\_JobTableRender.cshtml"
    
            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Shared\_JobTableRender.cshtml"
     if (Model != null && Model.Items.Count() > 0)
    { 

            
            #line default
            #line hidden
WriteLiteral("        <table");

WriteAttribute("class", Tuple.Create(" class=\"", 284), Tuple.Create("\"", 520)
, Tuple.Create(Tuple.Create("", 292), Tuple.Create("jobTable", 292), true)
            
            #line 9 "..\..\Views\Shared\_JobTableRender.cshtml"
, Tuple.Create(Tuple.Create("", 300), Tuple.Create<System.Object, System.Int32>(Model.IsSmallTable ? " smallTable" : string.Empty
            
            #line default
            #line hidden
, 300), false)
            
            #line 9 "..\..\Views\Shared\_JobTableRender.cshtml"
    , Tuple.Create(Tuple.Create("", 352), Tuple.Create<System.Object, System.Int32>(Model.HideClosedJobs ? " hideStatusClosed" : string.Empty
            
            #line default
            #line hidden
, 352), false)
            
            #line 9 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                , Tuple.Create(Tuple.Create("", 412), Tuple.Create<System.Object, System.Int32>(Model.EnablePaging ? " enablePaging" : string.Empty
            
            #line default
            #line hidden
, 412), false)
            
            #line 9 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                                                                      , Tuple.Create(Tuple.Create("", 466), Tuple.Create<System.Object, System.Int32>(Model.EnableFilter ? " enableFilter" : string.Empty
            
            #line default
            #line hidden
, 466), false)
);

WriteLiteral(">\r\n            <thead>\r\n                <tr>\r\n");

            
            #line 12 "..\..\Views\Shared\_JobTableRender.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Shared\_JobTableRender.cshtml"
                     if (Model.ShowId)
                    {
            
            #line default
            #line hidden
WriteLiteral(" <th");

WriteLiteral(" class=\"id\"");

WriteLiteral(">Ref\r\n                    </th> ");

            
            #line 14 "..\..\Views\Shared\_JobTableRender.cshtml"
                          }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 15 "..\..\Views\Shared\_JobTableRender.cshtml"
                     if (Model.ShowStatus)
                    {
            
            #line default
            #line hidden
WriteLiteral(" <th");

WriteLiteral(" class=\"status\"");

WriteLiteral(">Status\r\n                    </th> ");

            
            #line 17 "..\..\Views\Shared\_JobTableRender.cshtml"
                          }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 18 "..\..\Views\Shared\_JobTableRender.cshtml"
                     if (Model.ShowLastActivityDate)
                    {
            
            #line default
            #line hidden
WriteLiteral(" <th");

WriteLiteral(" class=\"lastActive\"");

WriteLiteral(">Last Active\r\n                    </th> ");

            
            #line 20 "..\..\Views\Shared\_JobTableRender.cshtml"
                          }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 21 "..\..\Views\Shared\_JobTableRender.cshtml"
                     if (Model.ShowDates)
                    {
            
            #line default
            #line hidden
WriteLiteral(" <th");

WriteLiteral(" class=\"dates\"");

WriteLiteral(">When\r\n                    </th> ");

            
            #line 23 "..\..\Views\Shared\_JobTableRender.cshtml"
                          }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 24 "..\..\Views\Shared\_JobTableRender.cshtml"
                     if (Model.ShowType)
                    {
            
            #line default
            #line hidden
WriteLiteral(" <th");

WriteLiteral(" class=\"type\"");

WriteLiteral(">Type\r\n                    </th> ");

            
            #line 26 "..\..\Views\Shared\_JobTableRender.cshtml"
                          }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 27 "..\..\Views\Shared\_JobTableRender.cshtml"
                     if (Model.ShowDevice)
                    {
            
            #line default
            #line hidden
WriteLiteral("<th");

WriteLiteral(" class=\"device\"");

WriteLiteral(">Device\r\n                    </th> ");

            
            #line 29 "..\..\Views\Shared\_JobTableRender.cshtml"
                          }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 30 "..\..\Views\Shared\_JobTableRender.cshtml"
                     if (Model.ShowUser)
                    {
            
            #line default
            #line hidden
WriteLiteral(" <th");

WriteLiteral(" class=\"user\"");

WriteLiteral(">User\r\n                    </th> ");

            
            #line 32 "..\..\Views\Shared\_JobTableRender.cshtml"
                          }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 33 "..\..\Views\Shared\_JobTableRender.cshtml"
                     if (Model.ShowTechnician)
                    {
            
            #line default
            #line hidden
WriteLiteral(" <th");

WriteLiteral(" class=\"technician\"");

WriteLiteral(">Technician\r\n                    </th> ");

            
            #line 35 "..\..\Views\Shared\_JobTableRender.cshtml"
                          }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 36 "..\..\Views\Shared\_JobTableRender.cshtml"
                     if (Model.ShowLocation)
                    {
            
            #line default
            #line hidden
WriteLiteral(" <th");

WriteLiteral(" class=\"location\"");

WriteLiteral(">Location\r\n                    </th> ");

            
            #line 38 "..\..\Views\Shared\_JobTableRender.cshtml"
                          }

            
            #line default
            #line hidden
WriteLiteral("                </tr>\r\n            </thead>\r\n            <tbody>\r\n");

            
            #line 42 "..\..\Views\Shared\_JobTableRender.cshtml"
                
            
            #line default
            #line hidden
            
            #line 42 "..\..\Views\Shared\_JobTableRender.cshtml"
                 foreach (var item in Model.Items)
                {
                    string statusSlaClass = null;
                    if (Model.ShowStatus)
                    {
                        var statusItem = (JobTableStatusItemModel)item;
                        if (statusItem.ActiveJobQueues != null)
                        {
                            var slaRemaining = statusItem.ActiveJobQueues.UsersQueueItems(Authorization).SlaPrecentageRemaining();
                            if (slaRemaining.HasValue && (slaRemaining <= 0))
                            {
                                statusSlaClass = "statusSlaExpired";
                            }
                            else if (slaRemaining.HasValue && (slaRemaining < .3))
                            {
                                statusSlaClass = "statusSlaWarning";
                            }
                        }
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <tr");

WriteLiteral(" data-id=\"");

            
            #line 61 "..\..\Views\Shared\_JobTableRender.cshtml"
                             Write(item.Id);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-status=\"");

            
            #line 61 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                      Write(Model.ShowStatus ? item.StatusId : null);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("class", Tuple.Create(" class=\"", 2803), Tuple.Create("\"", 2828)
            
            #line 61 "..\..\Views\Shared\_JobTableRender.cshtml"
                              , Tuple.Create(Tuple.Create("", 2811), Tuple.Create<System.Object, System.Int32>(statusSlaClass
            
            #line default
            #line hidden
, 2811), false)
);

WriteLiteral(">\r\n");

            
            #line 62 "..\..\Views\Shared\_JobTableRender.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 62 "..\..\Views\Shared\_JobTableRender.cshtml"
                         if (Model.ShowId)
                        {
            
            #line default
            #line hidden
WriteLiteral("<td");

WriteLiteral(" class=\"id\"");

WriteLiteral(">\r\n");

            
            #line 64 "..\..\Views\Shared\_JobTableRender.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 64 "..\..\Views\Shared\_JobTableRender.cshtml"
                             if (Authorization.Has(Claims.Job.Show))
                            {
            
            #line default
            #line hidden
            
            #line 65 "..\..\Views\Shared\_JobTableRender.cshtml"
                        Write(Html.ActionLink(item.JobId.ToString(), MVC.Job.Show(item.JobId)));

            
            #line default
            #line hidden
            
            #line 65 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                                              }
                            else
                            {
            
            #line default
            #line hidden
            
            #line 67 "..\..\Views\Shared\_JobTableRender.cshtml"
                        Write(item.JobId.ToString());

            
            #line default
            #line hidden
            
            #line 67 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                   }
            
            #line default
            #line hidden
WriteLiteral("</td>");

            
            #line 67 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                         }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 68 "..\..\Views\Shared\_JobTableRender.cshtml"
                         if (Model.ShowStatus)
                        {
                            var statusItem = (JobTableStatusItemModel)item;

            
            #line default
            #line hidden
WriteLiteral("                            <td");

WriteLiteral(" class=\"status\"");

WriteLiteral("><i");

WriteAttribute("class", Tuple.Create(" class=\"", 3380), Tuple.Create("\"", 3427)
, Tuple.Create(Tuple.Create("", 3388), Tuple.Create("fa", 3388), true)
, Tuple.Create(Tuple.Create(" ", 3390), Tuple.Create("fa-square", 3391), true)
, Tuple.Create(Tuple.Create(" ", 3400), Tuple.Create("jobStatus", 3401), true)
            
            #line 71 "..\..\Views\Shared\_JobTableRender.cshtml"
, Tuple.Create(Tuple.Create(" ", 3410), Tuple.Create<System.Object, System.Int32>(item.StatusId
            
            #line default
            #line hidden
, 3411), false)
);

WriteLiteral("></i>&nbsp;");

            
            #line 71 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                                                       Write(item.StatusDescription);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 72 "..\..\Views\Shared\_JobTableRender.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 72 "..\..\Views\Shared\_JobTableRender.cshtml"
                                 if (statusItem.ActiveJobQueues != null)
                                {
            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"queues\"");

WriteLiteral(">\r\n");

            
            #line 74 "..\..\Views\Shared\_JobTableRender.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 74 "..\..\Views\Shared\_JobTableRender.cshtml"
                                     foreach (var jqToken in ((JobTableStatusItemModel)item).ActiveJobQueues.Select(jqj => new Tuple<JobTableStatusQueueItemModel, Disco.Services.Jobs.JobQueues.JobQueueToken>(jqj, Disco.Services.Jobs.JobQueues.JobQueueService.GetQueue(jqj.QueueId))))
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <i");

WriteAttribute("class", Tuple.Create(" class=\"", 3959), Tuple.Create("\"", 4048)
, Tuple.Create(Tuple.Create("", 3967), Tuple.Create("fa", 3967), true)
, Tuple.Create(Tuple.Create(" ", 3969), Tuple.Create("fa-", 3970), true)
            
            #line 76 "..\..\Views\Shared\_JobTableRender.cshtml"
, Tuple.Create(Tuple.Create("", 3973), Tuple.Create<System.Object, System.Int32>(jqToken.Item2.JobQueue.Icon
            
            #line default
            #line hidden
, 3973), false)
, Tuple.Create(Tuple.Create(" ", 4003), Tuple.Create("fa-fw", 4004), true)
, Tuple.Create(Tuple.Create(" ", 4009), Tuple.Create("d-", 4010), true)
            
            #line 76 "..\..\Views\Shared\_JobTableRender.cshtml"
                , Tuple.Create(Tuple.Create("", 4012), Tuple.Create<System.Object, System.Int32>(jqToken.Item2.JobQueue.IconColour
            
            #line default
            #line hidden
, 4012), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 4049), Tuple.Create("\"", 4115)
            
            #line 76 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                             , Tuple.Create(Tuple.Create("", 4057), Tuple.Create<System.Object, System.Int32>(jqToken.Item2.JobQueue.Name
            
            #line default
            #line hidden
, 4057), false)
, Tuple.Create(Tuple.Create(" ", 4087), Tuple.Create("[", 4088), true)
            
            #line 76 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                                             , Tuple.Create(Tuple.Create("", 4089), Tuple.Create<System.Object, System.Int32>(jqToken.Item1.Priority
            
            #line default
            #line hidden
, 4089), false)
, Tuple.Create(Tuple.Create("", 4114), Tuple.Create("]", 4114), true)
);

WriteLiteral("></i>\r\n");

            
            #line 77 "..\..\Views\Shared\_JobTableRender.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </div>");

            
            #line 78 "..\..\Views\Shared\_JobTableRender.cshtml"
                                      }

            
            #line default
            #line hidden
WriteLiteral("                            </td>");

            
            #line 79 "..\..\Views\Shared\_JobTableRender.cshtml"
                                 }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 80 "..\..\Views\Shared\_JobTableRender.cshtml"
                         if (Model.ShowLastActivityDate)
                        {
            
            #line default
            #line hidden
WriteLiteral("<td");

WriteLiteral(" class=\"lastActive\"");

WriteLiteral(">");

            
            #line 81 "..\..\Views\Shared\_JobTableRender.cshtml"
                                           Write(CommonHelpers.FriendlyDate(item.LastActivityDate));

            
            #line default
            #line hidden
WriteLiteral("</td>");

            
            #line 81 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                                                       }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 82 "..\..\Views\Shared\_JobTableRender.cshtml"
                         if (Model.ShowDates)
                        {
            
            #line default
            #line hidden
WriteLiteral("<td");

WriteLiteral(" class=\"dates\"");

WriteLiteral(">");

            
            #line 83 "..\..\Views\Shared\_JobTableRender.cshtml"
                                            if (item.ClosedDate.HasValue)
                                           {
            
            #line default
            #line hidden
            
            #line 84 "..\..\Views\Shared\_JobTableRender.cshtml"
                                       Write(CommonHelpers.FriendlyDate(item.ClosedDate.Value));

            
            #line default
            #line hidden
            
            #line 84 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                                              }
                                           else
                                           {
            
            #line default
            #line hidden
            
            #line 86 "..\..\Views\Shared\_JobTableRender.cshtml"
                                       Write(CommonHelpers.FriendlyDate(item.OpenedDate));

            
            #line default
            #line hidden
            
            #line 86 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                                        }
            
            #line default
            #line hidden
WriteLiteral("</td>");

            
            #line 86 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                                              }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 87 "..\..\Views\Shared\_JobTableRender.cshtml"
                         if (Model.ShowType)
                        {
            
            #line default
            #line hidden
WriteLiteral("<td");

WriteLiteral(" class=\"type\"");

WriteLiteral("><span");

WriteAttribute("title", Tuple.Create(" title=\"", 4861), Tuple.Create("\"", 4893)
            
            #line 88 "..\..\Views\Shared\_JobTableRender.cshtml"
, Tuple.Create(Tuple.Create("", 4869), Tuple.Create<System.Object, System.Int32>(item.JobTypeDescription
            
            #line default
            #line hidden
, 4869), false)
);

WriteLiteral(">");

            
            #line 88 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                            Write(item.JobTypeId);

            
            #line default
            #line hidden
WriteLiteral("</span></td>");

            
            #line 88 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                                                            }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 89 "..\..\Views\Shared\_JobTableRender.cshtml"
                         if (Model.ShowDevice)
                        {
            
            #line default
            #line hidden
WriteLiteral("<td");

WriteLiteral(" class=\"device\"");

WriteLiteral(">\r\n");

            
            #line 91 "..\..\Views\Shared\_JobTableRender.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 91 "..\..\Views\Shared\_JobTableRender.cshtml"
                             if (item.DeviceSerialNumber != null)
                            {
                                if (Authorization.Has(Claims.Device.Show))
                                {
            
            #line default
            #line hidden
            
            #line 94 "..\..\Views\Shared\_JobTableRender.cshtml"
                            Write(Html.ActionLink(item.DeviceSerialNumber, MVC.Device.Show(item.DeviceSerialNumber), new { Title = item.DeviceModelDescription }));

            
            #line default
            #line hidden
            
            #line 94 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                                                                                                                 }
                                else
                                {
            
            #line default
            #line hidden
WriteLiteral("<span");

WriteAttribute("title", Tuple.Create(" title=\"", 5433), Tuple.Create("\"", 5469)
            
            #line 96 "..\..\Views\Shared\_JobTableRender.cshtml"
, Tuple.Create(Tuple.Create("", 5441), Tuple.Create<System.Object, System.Int32>(item.DeviceModelDescription
            
            #line default
            #line hidden
, 5441), false)
);

WriteLiteral(">");

            
            #line 96 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                       Write(item.DeviceSerialNumber);

            
            #line default
            #line hidden
WriteLiteral("</span>");

            
            #line 96 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                                                           }
                            }
                            else
                            {
            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">N/A</span>");

            
            #line 99 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                  }
            
            #line default
            #line hidden
WriteLiteral("</td>");

            
            #line 99 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                        }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 100 "..\..\Views\Shared\_JobTableRender.cshtml"
                         if (Model.ShowUser)
                        {
            
            #line default
            #line hidden
WriteLiteral("<td");

WriteLiteral(" class=\"user\"");

WriteLiteral(">\r\n");

            
            #line 102 "..\..\Views\Shared\_JobTableRender.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 102 "..\..\Views\Shared\_JobTableRender.cshtml"
                             if (item.UserId != null)
                            {
                                if (Authorization.Has(Claims.User.Show))
                                {
            
            #line default
            #line hidden
            
            #line 105 "..\..\Views\Shared\_JobTableRender.cshtml"
                            Write(Html.ActionLink(string.Format("{0} ({1})", item.UserDisplayName, item.UserId), MVC.User.Show(item.UserId)));

            
            #line default
            #line hidden
            
            #line 105 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                                                                                            }
                                else
                                {
            
            #line default
            #line hidden
            
            #line 107 "..\..\Views\Shared\_JobTableRender.cshtml"
                             Write(string.Format("{0} ({1})", item.UserDisplayName, item.UserId));

            
            #line default
            #line hidden
            
            #line 107 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                                                 }
                            }
                            else
                            {
            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">N/A</span>");

            
            #line 110 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                  }
            
            #line default
            #line hidden
WriteLiteral("</td>");

            
            #line 110 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                        }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 111 "..\..\Views\Shared\_JobTableRender.cshtml"
                         if (Model.ShowTechnician)
                        {
            
            #line default
            #line hidden
WriteLiteral("<td");

WriteLiteral(" class=\"technician\"");

WriteLiteral("><span");

WriteAttribute("title", Tuple.Create(" title=\"", 6421), Tuple.Create("\"", 6460)
            
            #line 112 "..\..\Views\Shared\_JobTableRender.cshtml"
, Tuple.Create(Tuple.Create("", 6429), Tuple.Create<System.Object, System.Int32>(item.OpenedTechUserDisplayName
            
            #line default
            #line hidden
, 6429), false)
);

WriteLiteral(">");

            
            #line 112 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                                         Write(item.OpenedTechUserId);

            
            #line default
            #line hidden
WriteLiteral("</span></td>");

            
            #line 112 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                                                                                }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 113 "..\..\Views\Shared\_JobTableRender.cshtml"
                         if (Model.ShowLocation)
                        {
            
            #line default
            #line hidden
WriteLiteral("<td");

WriteLiteral(" class=\"location\"");

WriteLiteral("><span>");

            
            #line 114 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                Write(item.DeviceHeldLocation ?? "Unknown");

            
            #line default
            #line hidden
WriteLiteral("</span></td>");

            
            #line 114 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                                                       }

            
            #line default
            #line hidden
WriteLiteral("                    </tr>");

            
            #line 115 "..\..\Views\Shared\_JobTableRender.cshtml"
                         }

            
            #line default
            #line hidden
WriteLiteral("            </tbody>\r\n        </table>\r\n");

            
            #line 118 "..\..\Views\Shared\_JobTableRender.cshtml"
                if (Model.HideClosedJobs && Model.Items.All(j => j.ClosedDate.HasValue))
                {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"allClosed_container\"");

WriteLiteral(">\r\n            <h3>No open jobs</h3>\r\n            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"dataTables_showStatusClosed button small\"");

WriteLiteral(">Show Closed Jobs (");

            
            #line 122 "..\..\Views\Shared\_JobTableRender.cshtml"
                                                                                       Write(Model.Items.Count());

            
            #line default
            #line hidden
WriteLiteral(")</a>\r\n        </div>\r\n");

            
            #line 124 "..\..\Views\Shared\_JobTableRender.cshtml"
                }
    }
    else
    { 

            
            #line default
            #line hidden
WriteLiteral("        <h3>No jobs to display</h3>\r\n");

            
            #line 129 "..\..\Views\Shared\_JobTableRender.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
