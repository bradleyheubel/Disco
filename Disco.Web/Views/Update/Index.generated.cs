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

namespace Disco.Web.Views.Update
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Update/Index.cshtml")]
    public class Index : System.Web.Mvc.WebViewPage<Disco.Web.Models.Update.IndexModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Update\Index.cshtml"
  
    ViewBag.Title = "Disco Post-Update Configuration";
    Layout = "~/Areas/Public/Views/Shared/_Layout.cshtml";
    
    Html.BundleDeferred("~/ClientScripts/Modules/Knockout");
    Html.BundleDeferred("~/ClientScripts/Modules/jQuery-SignalR");
    Html.BundleDeferred("~/Style/Config");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" style=\"min-height: 300px;\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"scheduledTaskStatus\"");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 520px;\"");

WriteLiteral(" data-bind=\"visible: Initialized\"");

WriteLiteral(">\r\n        <h2");

WriteLiteral(" data-bind=\"text: TaskName\"");

WriteLiteral(">&nbsp;</h2>\r\n        <table>\r\n            <tr");

WriteLiteral(" data-bind=\"visible: IsRunning\"");

WriteLiteral(">\r\n                <th");

WriteLiteral(" class=\"process\"");

WriteLiteral(" data-bind=\"text: CurrentProcess\"");

WriteLiteral(">&nbsp;\r\n                </th>\r\n            </tr>\r\n            <tr");

WriteLiteral(" data-bind=\"visible: IsRunning\"");

WriteLiteral(">\r\n                <td");

WriteLiteral(" class=\"description\"");

WriteLiteral(" data-bind=\"text: CurrentDescription\"");

WriteLiteral(">&nbsp;\r\n                </td>\r\n            </tr>\r\n            <tr");

WriteLiteral(" data-bind=\"visible: IsRunning\"");

WriteLiteral(">\r\n                <td");

WriteLiteral(" class=\"progress\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" data-bind=\"progressValue: Progress\"");

WriteLiteral(">\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n        " +
"    <tr");

WriteLiteral(" data-bind=\"visible: FinishedTimestamp\"");

WriteLiteral(">\r\n                <td");

WriteLiteral(" class=\"finishedTimestamp\"");

WriteLiteral(">\r\n                    <h3>Finished: <span");

WriteLiteral(" data-bind=\"text: FinishedTimestampFormatted\"");

WriteLiteral("></span>\r\n                    </h3>\r\n                </td>\r\n            </tr>\r\n  " +
"          <tr");

WriteLiteral(" data-bind=\"visible: FinishedTimestamp() && !TaskExceptionMessage()\"");

WriteLiteral(">\r\n                <td");

WriteLiteral(" class=\"finishedMessage\"");

WriteLiteral(" data-bind=\"css: { finishedRedirect: FinishedUrl }\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" data-bind=\"text: FinishedMessage\"");

WriteLiteral("></span>\r\n                </td>\r\n            </tr>\r\n            <tr");

WriteLiteral(" data-bind=\"visible: TaskExceptionMessage\"");

WriteLiteral(">\r\n                <td");

WriteLiteral(" class=\"exception\"");

WriteLiteral(">Last Error:\r\n                    <div");

WriteLiteral(" class=\"code\"");

WriteLiteral(" data-bind=\"text: TaskExceptionMessage\"");

WriteLiteral(">\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n        " +
"    <tr");

WriteLiteral(" data-bind=\"visible: NextScheduledTimestamp\"");

WriteLiteral(">\r\n                <td");

WriteLiteral(" class=\"nextScheduledTimestamp\"");

WriteLiteral(">Next Scheduled: <span");

WriteLiteral(" data-bind=\"text: NextScheduledTimestampFormatted\"");

WriteLiteral("></span>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n    </div>\r" +
"\n</div>\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    ko.bindingHandlers.progressValue = {\r\n        init: function (element, val" +
"ueAccessor, allBindingsAccessor, viewModel) {\r\n            var $element = $(elem" +
"ent);\r\n            if (!$element.is(\'.ui-progressbar\'))\r\n                $elemen" +
"t.progressbar();\r\n        },\r\n        update: function (element, valueAccessor, " +
"allBindingsAccessor, viewModel) {\r\n            var v = ko.utils.unwrapObservable" +
"(valueAccessor());\r\n            var vInt = parseInt(v);\r\n            if (vInt >=" +
" 0) {\r\n                $(element).progressbar(\'option\', \'value\', vInt);\r\n       " +
"     }\r\n        }\r\n    };\r\n    //* http://webcloud.se/log/JavaScript-and-ISO-860" +
"1/\r\n    Date.prototype.setISO8601 = function (string) {\r\n        var regexp = \"(" +
"[0-9]{4})(-([0-9]{2})(-([0-9]{2})\" +\r\n        \"(T([0-9]{2}):([0-9]{2})(:([0-9]{2" +
"})(\\.([0-9]+))?)?\" +\r\n        \"(Z|(([-+])([0-9]{2}):([0-9]{2})))?)?)?)?\";\r\n     " +
"   var d = string.match(new RegExp(regexp));\r\n\r\n        var offset = 0;\r\n       " +
" var date = new Date(d[1], 0, 1);\r\n\r\n        if (d[3]) { date.setMonth(d[3] - 1)" +
"; }\r\n        if (d[5]) { date.setDate(d[5]); }\r\n        if (d[7]) { date.setHour" +
"s(d[7]); }\r\n        if (d[8]) { date.setMinutes(d[8]); }\r\n        if (d[10]) { d" +
"ate.setSeconds(d[10]); }\r\n        if (d[12]) { date.setMilliseconds(Number(\"0.\" " +
"+ d[12]) * 1000); }\r\n        if (d[14]) {\r\n            offset = (Number(d[16]) *" +
" 60) + Number(d[17]);\r\n            offset *= ((d[15] == \'-\') ? 1 : -1);\r\n       " +
" }\r\n\r\n        offset -= date.getTimezoneOffset();\r\n        time = (Number(date) " +
"+ (offset * 60 * 1000));\r\n        this.setTime(Number(time));\r\n        return th" +
"is;\r\n    }\r\n</script>\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    $(function () {\r\n        var sessionId = \'");

            
            #line 96 "..\..\Views\Update\Index.cshtml"
                     Write(Model.SessionId);

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var sessionStatusUrl = \'");

            
            #line 97 "..\..\Views\Update\Index.cshtml"
                            Write(Url.Action(MVC.API.Logging.ScheduledTaskStatus(Model.SessionId)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n\r\n        // Clear Menu\r\n        $(\'#menu\').empty();\r\n\r\n        var view = $(" +
"\'#scheduledTaskStatus\');\r\n        var vm = null;\r\n\r\n        var liveConnection =" +
" null;\r\n\r\n        var statusViewModel = function (sessionId) {\r\n            var " +
"self = this;\r\n\r\n            self.Initialized = ko.observable(false);\r\n\r\n        " +
"    self.TimestampParse = function (timestamp) {\r\n                if (timestamp)" +
" {\r\n                    if (timestamp.indexOf(\"\\/Date(\") == 0)\r\n                " +
"        return new Date(parseInt(timestamp.substr(6)));\r\n                    els" +
"e\r\n                        return (new Date()).setISO8601(timestamp);\r\n         " +
"       }\r\n                return new Date();\r\n            }\r\n            self.Ti" +
"mestampFormat = function (timestamp) {\r\n                var addZero = function (" +
"v) { v = v + \'\'; if (v.length == 1) v = \'0\' + v; return v; }\r\n                re" +
"turn timestamp.getFullYear() + \'/\' + addZero((1 + timestamp.getMonth())) + \'/\' +" +
" addZero(timestamp.getDate()) + \' \' + addZero(timestamp.getHours()) + \':\' + addZ" +
"ero(timestamp.getMinutes()) + \':\' + addZero(timestamp.getSeconds());\r\n          " +
"  }\r\n\r\n            self.SessionId = sessionId;\r\n            self.TaskName = ko.o" +
"bservable(null);\r\n            self.StatusVersion = -1;\r\n\r\n            self.Progr" +
"ess = ko.observable(0);\r\n            self.CurrentProcess = ko.observable(null);\r" +
"\n            self.CurrentDescription = ko.observable(null);\r\n\r\n            self." +
"IsRunning = ko.observable(null);\r\n\r\n            self.TaskExceptionMessage = ko.o" +
"bservable(null);\r\n\r\n            self.FinishedTimestamp = ko.observable(null);\r\n " +
"           self.NextScheduledTimestamp = ko.observable(null)\r\n\r\n            self" +
".NextScheduledTimestampFormatted = ko.computed(function () {\r\n                re" +
"turn self.TimestampFormat(self.TimestampParse(self.NextScheduledTimestamp()));\r\n" +
"            });\r\n            self.FinishedTimestampFormatted = ko.computed(funct" +
"ion () {\r\n                return self.TimestampFormat(self.TimestampParse(self.F" +
"inishedTimestamp()));\r\n            });\r\n\r\n            self.FinishedUrl = ko.obse" +
"rvable(null);\r\n            self.FinishedMessage = ko.observable(null);\r\n\r\n      " +
"      self.Finished = function () {\r\n                if (self.FinishedTimestamp(" +
")) {\r\n                    if (self.FinishedUrl() && !self.TaskExceptionMessage()" +
") {\r\n                        if (self.FinishedMessage())\r\n                      " +
"      window.setTimeout(function () { window.location.href = self.FinishedUrl();" +
" }, 3000);\r\n                        else\r\n                            window.loc" +
"ation.href = self.FinishedUrl();\r\n                    }\r\n                }\r\n    " +
"        }\r\n\r\n            self.Initialize = function (taskStatus) {\r\n            " +
"    self.TaskName(taskStatus.TaskName);\r\n                self.FinishedUrl(taskSt" +
"atus.FinishedUrl);\r\n\r\n                self.Progress(taskStatus.Progress);\r\n     " +
"           self.CurrentProcess(taskStatus.CurrentProcess);\r\n                self" +
".CurrentDescription(taskStatus.CurrentDescription);\r\n\r\n                self.IsRu" +
"nning(taskStatus.IsRunning);\r\n\r\n                self.TaskExceptionMessage(taskSt" +
"atus.TaskExceptionMessage);\r\n\r\n                self.FinishedTimestamp(taskStatus" +
".FinishedTimestamp);\r\n                self.NextScheduledTimestamp(taskStatus.Nex" +
"tScheduledTimestamp);\r\n\r\n                self.FinishedMessage(taskStatus.Finishe" +
"dMessage);\r\n\r\n                self.Initialized(true);\r\n\r\n                self.Fi" +
"nished();\r\n            }\r\n            self.Update = function (taskStatus) {\r\n   " +
"             if (!self.Initialized())\r\n                    return self.Initializ" +
"e(taskStatus);\r\n\r\n                if (taskStatus.StatusVersion < self.StatusVers" +
"ion)\r\n                    return; // Have Newer Status Update\r\n                s" +
"elf.StatusVersion = taskStatus.StatusVersion;\r\n\r\n                if (taskStatus." +
"ChangedProperties) {\r\n                    for (var changedPropertyIndex = 0; cha" +
"ngedPropertyIndex < taskStatus.ChangedProperties.length; changedPropertyIndex++)" +
" {\r\n                        switch (taskStatus.ChangedProperties[changedProperty" +
"Index]) {\r\n                            case \'Progress\':\r\n                       " +
"         self.Progress(taskStatus.Progress);\r\n                                br" +
"eak;\r\n                            case \'CurrentProcess\':\r\n                      " +
"          self.CurrentProcess(taskStatus.CurrentProcess);\r\n                     " +
"           break;\r\n                            case \'CurrentDescription\':\r\n     " +
"                           self.CurrentDescription(taskStatus.CurrentDescription" +
");\r\n                                break;\r\n                            case \'Is" +
"Running\':\r\n                                self.IsRunning(taskStatus.IsRunning);" +
"\r\n                                break;\r\n                            case \'Task" +
"Exception\':\r\n                                self.TaskExceptionMessage(taskStatu" +
"s.TaskExceptionMessage);\r\n                                break;\r\n              " +
"              case \'NextScheduledTimestamp\':\r\n                                se" +
"lf.NextScheduledTimestamp(taskStatus.NextScheduledTimestamp);\r\n                 " +
"               break;\r\n                            case \'FinishedUrl\':\r\n        " +
"                        self.FinishedUrl(taskStatus.FinishedUrl);\r\n             " +
"                   break;\r\n                            case \'FinishedMessage\':\r\n" +
"                                self.FinishedMessage(taskStatus.FinishedMessage)" +
";\r\n                                break;\r\n                            case \'Fin" +
"ishedTimestamp\':\r\n                                self.FinishedTimestamp(taskSta" +
"tus.FinishedTimestamp);\r\n                                window.setTimeout(self." +
"Finished, 1);\r\n                                break;\r\n                         " +
"   default:\r\n                                // Ignore\r\n                        " +
"}\r\n                    }\r\n                }\r\n            }\r\n        }\r\n\r\n       " +
" vm = new statusViewModel(sessionId);\r\n        ko.applyBindings(vm, view[0]);\r\n\r" +
"\n        // Start Live Connection\r\n        updateWithLive();\r\n\r\n        function" +
" updateWithAjax(onSuccess) {\r\n            $.ajax({\r\n                url: session" +
"StatusUrl,\r\n                dataType: \'json\',\r\n                type: \'POST\',\r\n  " +
"              traditional: true,\r\n                success: update_Received,\r\n   " +
"             error: function (jqXHR, textStatus, errorThrown) {\r\n               " +
"     alert(\'Unable to load Session: \' + errorThrown);\r\n                }\r\n      " +
"      });\r\n        }\r\n        function updateWithLive() {\r\n            liveConne" +
"ction = $.connection(\'");

            
            #line 249 "..\..\Views\Update\Index.cshtml"
                                       Write(Url.Content("~/API/Logging/TaskStatusNotifications"));

            
            #line default
            #line hidden
WriteLiteral(@"');
            liveConnection.received(update_Received);
            liveConnection.start(function () {
                liveConnection.send('/addToGroups:' + sessionId);
                updateWithAjax();
            });
        }
        function update_Received(taskStatus) {
            vm.Update(taskStatus);
        }

    });
</script>
");

        }
    }
}
#pragma warning restore 1591