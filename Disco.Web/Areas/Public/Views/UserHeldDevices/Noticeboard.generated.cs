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

namespace Disco.Web.Areas.Public.Views.UserHeldDevices
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
    using Disco.Services;
    using Disco.Services.Authorization;
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Public/Views/UserHeldDevices/Noticeboard.cshtml")]
    public partial class Noticeboard : Disco.Services.Web.WebViewPage<dynamic>
    {
        public Noticeboard()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Public\Views\UserHeldDevices\Noticeboard.cshtml"
  
    Layout = null;
    Html.BundleDeferred("~/ClientScripts/Modules/Knockout");
    Html.BundleDeferred("~/ClientScripts/Modules/jQuery-SignalR");
    Html.BundleDeferred("~/ClientScripts/Core");
    Html.BundleDeferred("~/Style/Public/HeldDevicesNoticeboard");

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(" />\r\n    <title>Disco ICT - Held Devices for Users</title>\r\n");

WriteLiteral("    ");

            
            #line 14 "..\..\Areas\Public\Views\UserHeldDevices\Noticeboard.cshtml"
Write(Html.BundleRenderDeferred());

            
            #line default
            #line hidden
WriteLiteral("\r\n</head>\r\n<body");

WriteLiteral(" class=\"status-connecting\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"page\"");

WriteLiteral(">\r\n        <header");

WriteLiteral(" id=\"header\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\"heading\"");

WriteLiteral(">Held Devices for Users</div>\r\n            <div");

WriteLiteral(" id=\"statusConnecting\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-cog fa-spin\"");

WriteLiteral("></i><span>connecting...</span></div>\r\n            <div");

WriteLiteral(" id=\"statusError\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-cog fa-spin\"");

WriteLiteral("></i><span>disconnected, reconnecting...</span></div>\r\n            <div");

WriteLiteral(" id=\"credits\"");

WriteLiteral(">\r\n                powered by Disco ICT <i");

WriteLiteral(" title=\"Disco ICT - Jobs\"");

WriteLiteral("></i>\r\n            </div>\r\n        </header>\r\n        <section");

WriteLiteral(" id=\"mainSection\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\"inProcess\"");

WriteLiteral(" class=\"list\"");

WriteLiteral(">\r\n                <h3>In Process (<span");

WriteLiteral(" data-bind=\"text: inProcess().length\"");

WriteLiteral("></span>)\r\n                </h3>\r\n                <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n                    <!-- ko if: inProcess().length == 0 -->\r\n                 " +
"   <div");

WriteLiteral(" class=\"noContent\"");

WriteLiteral(">&lt;None&gt;</div>\r\n                    <!-- /ko -->\r\n                    <ul");

WriteLiteral(" data-bind=\"template: { name: \'item-template\', foreach: inProcess, afterRender: o" +
"nAdd, beforeRemove: onRemove }\"");

WriteLiteral("></ul>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" id=\"readyForReturn\"");

WriteLiteral(" class=\"list\"");

WriteLiteral(">\r\n                <h3>Ready for Return (<span");

WriteLiteral(" data-bind=\"text: readyForReturn().length\"");

WriteLiteral("></span>)\r\n                </h3>\r\n                <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n                    <!-- ko if: readyForReturn().length == 0 -->\r\n            " +
"        <div");

WriteLiteral(" class=\"noContent\"");

WriteLiteral(">&lt;None&gt;</div>\r\n                    <!-- /ko -->\r\n                    <ul");

WriteLiteral(" data-bind=\"template: { name: \'item-template\', foreach: readyForReturn, afterRend" +
"er: onAdd, beforeRemove: onRemove }\"");

WriteLiteral("></ul>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" id=\"waitingForUserAction\"");

WriteLiteral(" class=\"list\"");

WriteLiteral(">\r\n                <h3>Waiting for User Action (<span");

WriteLiteral(" data-bind=\"text: waitingForUserAction().length\"");

WriteLiteral("></span>)\r\n                </h3>\r\n                <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n                    <!-- ko if: waitingForUserAction().length == 0 -->\r\n      " +
"              <div");

WriteLiteral(" class=\"noContent\"");

WriteLiteral(">&lt;None&gt;</div>\r\n                    <!-- /ko -->\r\n                    <ul");

WriteLiteral(" data-bind=\"template: { name: \'item-template\', foreach: waitingForUserAction, aft" +
"erAdd: onAdd, beforeRemove: onRemove }\"");

WriteLiteral("></ul>\r\n                </div>\r\n            </div>\r\n            <footer");

WriteLiteral(" id=\"footer\"");

WriteLiteral(">\r\n            </footer>\r\n        </section>\r\n    </div>\r\n    <script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"item-template\"");

WriteLiteral(">\r\n        <li data-bind=\"css: { alert: IsAlert }\">\r\n            <span data-bind=" +
"\"text: UserIdFriendly + \' - \' + UserDisplayName\"></span>\r\n            <!-- ko if" +
": !ReadyForReturn && EstimatedReturnTimeUnixEpoc -->\r\n            <span class=\"s" +
"mall\">(Expected <span data-bind=\"livestamp: EstimatedReturnTimeUnixEpoc\"></span>" +
")</span>\r\n            <!-- /ko -->\r\n            <!-- ko if: WaitingForUserAction" +
" -->\r\n            <span class=\"small\">(Since <span data-bind=\"livestamp: Waiting" +
"ForUserActionSinceUnixEpoc\"></span>)</span>\r\n            <!-- /ko -->\r\n         " +
"   <!-- ko if: ReadyForReturn && !WaitingForUserAction -->\r\n            <span cl" +
"ass=\"small\">(Ready <span data-bind=\"livestamp: ReadyForReturnSinceUnixEpoc\"></sp" +
"an>)</span>\r\n            <!-- /ko -->\r\n        </li>\r\n    </script>\r\n    <script" +
">\r\n        ko.bindingHandlers.livestamp = {\r\n            init: function (element" +
", valueAccessor, allBindings, viewModel, bindingContext) {\r\n                var " +
"value = valueAccessor();\r\n                var valueUnwrapped = ko.unwrap(value);" +
"\r\n\r\n                if (valueUnwrapped)\r\n                    $(element).livestam" +
"p(valueUnwrapped);\r\n                else\r\n                    $(element).livesta" +
"mp(\'destroy\');\r\n            }\r\n        };\r\n    </script>\r\n    <script>\r\n        " +
"$(function () {\r\n            var hub;\r\n            var viewModel;\r\n\r\n           " +
" var rotateSpeed = 3000;\r\n            var itemFilters;\r\n\r\n            var $inPro" +
"cessList = $(\'#inProcess\').find(\'ul\');\r\n            var $readyForReturnList = $(" +
"\'#readyForReturn\').find(\'ul\');\r\n            var $waitingForUserActionList = $(\'#" +
"waitingForUserAction\').find(\'ul\');\r\n\r\n            function noticeboardViewModel(" +
"inProcess, readyForReturn, waitingForUserAction) {\r\n                var self = t" +
"his;\r\n\r\n                self.initialized = false;\r\n\r\n                self.inProc" +
"ess = ko.observableArray(inProcess);\r\n                self.readyForReturn = ko.o" +
"bservableArray(readyForReturn);\r\n                self.waitingForUserAction = ko." +
"observableArray(waitingForUserAction);\r\n\r\n                self.onRemove = functi" +
"on (element, index, data) {\r\n                    $(element).slideUp(400, functio" +
"n () {\r\n                        $(this).remove();\r\n                    });\r\n    " +
"            }\r\n                self.onAdd = function (element, index, data) {\r\n " +
"                   if (self.initialized)\r\n                        $(element).hid" +
"e().slideDown(400);\r\n                }\r\n            }\r\n\r\n            function in" +
"it() {\r\n                // Connect to Hub\r\n                hub = $.connection.no" +
"ticeboardUpdates;\r\n\r\n                // Map Functions\r\n                hub.clien" +
"t.updateHeldDeviceForUser = updateHeldDevice;\r\n\r\n                $.connection.hu" +
"b.qs = { Noticeboard: \'");

            
            #line 127 "..\..\Areas\Public\Views\UserHeldDevices\Noticeboard.cshtml"
                                                  Write(Disco.Services.Jobs.Noticeboards.HeldDevicesForUsers.Name);

            
            #line default
            #line hidden
WriteLiteral(@"' };
                $.connection.hub.error(connectionError);
                $.connection.hub.disconnected(connectionError);
                $.connection.hub.reconnected(connectionError);

                // Start Connection
                $.connection.hub.start().fail(connectionError).done(loadData);
            }

            // Called after SignalR is connected
            function loadData() {
                $.getJSON('");

            
            #line 138 "..\..\Areas\Public\Views\UserHeldDevices\Noticeboard.cshtml"
                       Write(Url.Action(MVC.Public.UserHeldDevices.UserHeldDevices()));

            
            #line default
            #line hidden
WriteLiteral("\', null, function (data) {\r\n\r\n                    var inProcess = [];\r\n          " +
"          var readyForReturn = [];\r\n                    var waitingForUserAction" +
" = [];\r\n\r\n                    data.filter(function (heldDeviceItem) {\r\n         " +
"               return includeItem(heldDeviceItem)\r\n                    }).forEac" +
"h(function (heldDeviceItem) {\r\n                        if (isWaitingForUserActio" +
"n(heldDeviceItem))\r\n                            waitingForUserAction.push(heldDe" +
"viceItem);\r\n                        else if (isReadyForReturn(heldDeviceItem))\r\n" +
"                            readyForReturn.push(heldDeviceItem);\r\n              " +
"          else if (isInProcess(heldDeviceItem))\r\n                            inP" +
"rocess.push(heldDeviceItem);\r\n                    });\r\n\r\n                    inP" +
"rocess.sort(sortFunction);\r\n                    readyForReturn.sort(sortFunction" +
");\r\n                    waitingForUserAction.sort(sortFunction);\r\n\r\n            " +
"        viewModel = new noticeboardViewModel(inProcess, readyForReturn, waitingF" +
"orUserAction);\r\n\r\n                    ko.applyBindings(viewModel);\r\n            " +
"        viewModel.initialized = true;\r\n\r\n                    $(\'body\').removeCla" +
"ss(\'status-connecting\');\r\n\r\n                    window.setTimeout(scheduleRotati" +
"on, rotateSpeed);\r\n                });\r\n                buildFilters();\r\n       " +
"     }\r\n\r\n            // Called by SignalR\r\n            function updateHeldDevic" +
"e(updates) {\r\n                if (viewModel) {\r\n\r\n                    $.each(upd" +
"ates, function (UserId, heldDeviceItem) {\r\n                        // Remove Exi" +
"sting\r\n                        removeItem(UserId);\r\n\r\n                        //" +
" Add Item\r\n                        addItem(heldDeviceItem);\r\n                   " +
" });\r\n                }\r\n            }\r\n\r\n            function removeItem(UserId" +
") {\r\n                removeItemFromArray(viewModel.inProcess, UserId);\r\n        " +
"        removeItemFromArray(viewModel.readyForReturn, UserId);\r\n                " +
"removeItemFromArray(viewModel.waitingForUserAction, UserId);\r\n            }\r\n\r\n " +
"           function addItem(heldDeviceItem) {\r\n                if (heldDeviceIte" +
"m !== null &&\r\n                    heldDeviceItem !== undefined &&\r\n            " +
"        includeItem(heldDeviceItem)) {\r\n\r\n                    var array;\r\n\r\n    " +
"                if (isWaitingForUserAction(heldDeviceItem))\r\n                   " +
"     array = viewModel.waitingForUserAction;\r\n                    else if (isRea" +
"dyForReturn(heldDeviceItem))\r\n                        array = viewModel.readyFor" +
"Return;\r\n                    else if (isInProcess(heldDeviceItem))\r\n            " +
"            array = viewModel.inProcess;\r\n\r\n                    if (array().leng" +
"th === 0) {\r\n                        array.push(heldDeviceItem);\r\n              " +
"      } else {\r\n                        var index = findSortedInsertIndex(array," +
" heldDeviceItem);\r\n                        if (index === -1)\r\n                  " +
"          array.push(heldDeviceItem);\r\n                        else\r\n           " +
"                 array.splice(index, 0, heldDeviceItem);\r\n                    }\r" +
"\n                }\r\n            }\r\n\r\n            function rotateArrays() {\r\n    " +
"            rotateArray(viewModel.inProcess, $inProcessList);\r\n                r" +
"otateArray(viewModel.readyForReturn, $readyForReturnList);\r\n                rota" +
"teArray(viewModel.waitingForUserAction, $waitingForUserActionList);\r\n           " +
" }\r\n\r\n            function scheduleRotation() {\r\n                rotateArrays();" +
"\r\n\r\n                window.setTimeout(scheduleRotation, rotateSpeed);\r\n         " +
"   }\r\n\r\n            function includeItem(heldDeviceItem) {\r\n                if (" +
"itemFilters == null || itemFilters.length == 0)\r\n                    return true" +
";\r\n\r\n                return itemFilters.reduce(function (previousValue, currentV" +
"alue, index, array) {\r\n                    if (previousValue === false)\r\n       " +
"                 return false;\r\n                    return currentValue(heldDevi" +
"ceItem);\r\n                }, true);\r\n            }\r\n\r\n            function build" +
"Filters() {\r\n                var filters = [];\r\n                var queryStringP" +
"arameters = getQueryStringParameters();\r\n\r\n                if (queryStringParame" +
"ters !== null) {\r\n                    $.each(queryStringParameters, function (ke" +
"y, value) {\r\n                        switch (key.toLowerCase()) {\r\n             " +
"               case \'deviceaddressinclude\':\r\n                                var" +
" deviceAddresses = value.split(\",\").map(function (v) { return v.toLowerCase(); }" +
");\r\n                                if (deviceAddresses.length > 0) {\r\n         " +
"                           filters.push(function (heldDeviceItem) {\r\n           " +
"                             // false if DeviceAddressShortName is null\r\n       " +
"                                 if (!heldDeviceItem.DeviceAddressShortName)\r\n  " +
"                                          return false;\r\n\r\n                     " +
"                   // true if DeviceAddressShortName is included\r\n              " +
"                          return $.inArray(heldDeviceItem.DeviceAddressShortName" +
".toLowerCase(), deviceAddresses) >= 0;\r\n                                    });\r" +
"\n                                }\r\n                                break;\r\n    " +
"                        case \'deviceaddressexclude\':\r\n                          " +
"      var deviceAddresses = value.split(\",\").map(function (v) { return v.toLower" +
"Case(); });\r\n                                if (deviceAddresses.length > 0) {\r\n" +
"                                    filters.push(function (heldDeviceItem) {\r\n  " +
"                                      // true if DeviceAddressShortName is null\r" +
"\n                                        if (!heldDeviceItem.DeviceAddressShortN" +
"ame)\r\n                                            return true;\r\n\r\n              " +
"                          // true if DeviceAddressShortName is excluded\r\n       " +
"                                 return $.inArray(heldDeviceItem.DeviceAddressSh" +
"ortName.toLowerCase(), deviceAddresses) < 0;\r\n                                  " +
"  });\r\n                                }\r\n                                break;" +
"\r\n                            case \'deviceprofileinclude\':\r\n                    " +
"            var deviceProfiles = value.split(\",\").map(function (v) { return pars" +
"eInt(v); });\r\n                                if (deviceProfiles.length > 0) {\r\n" +
"                                    filters.push(function (heldDeviceItem) {\r\n  " +
"                                      // true if DeviceProfileId is included\r\n  " +
"                                      return $.inArray(heldDeviceItem.DeviceProf" +
"ileId, deviceProfiles) >= 0;\r\n                                    });\r\n         " +
"                       }\r\n                                break;\r\n              " +
"              case \'deviceprofileexclude\':\r\n                                var " +
"deviceProfiles = value.split(\",\").map(function (v) { return parseInt(v); });\r\n  " +
"                              if (deviceProfiles.length > 0) {\r\n                " +
"                    filters.push(function (heldDeviceItem) {\r\n                  " +
"                      // true if DeviceProfileId is excluded\r\n                  " +
"                      return $.inArray(heldDeviceItem.DeviceProfileId, devicePro" +
"files) < 0;\r\n                                    });\r\n                          " +
"      }\r\n                                break;\r\n                        }\r\n    " +
"                });\r\n                }\r\n\r\n                if (filters.length > 0" +
")\r\n                    itemFilters = filters;\r\n                else\r\n           " +
"         itemFilters = null;\r\n            }\r\n\r\n            function connectionEr" +
"ror() {\r\n                try {\r\n                    $(\'body\').addClass(\'status-e" +
"rror\');\r\n                    $.connection.hub.stop();\r\n                } catch (" +
"e) {\r\n                    // Ignore\r\n                }\r\n\r\n                window" +
".setTimeout(function () {\r\n                    window.location.href = window.loc" +
"ation.href;\r\n                }, 10000);\r\n            }\r\n\r\n            // Helpers" +
"\r\n            function rotateArray(koArray, element) {\r\n                var item" +
"s = koArray();\r\n\r\n                if (items.length <= 1)\r\n                    re" +
"turn 0;\r\n\r\n                if (element.height() < (element.parent().height() - 3" +
"0)) {\r\n\r\n                    if (findUnsortedArrayTopIndex(items) !== 0)\r\n      " +
"                  koArray.sort(sortFunction);\r\n\r\n                    // Don\'t ro" +
"tate if small & sorted correctly\r\n                    return;\r\n                }" +
"\r\n\r\n                // Move Last Item to Top\r\n                var item = koArray" +
".pop();\r\n                koArray.unshift(item);\r\n            }\r\n            func" +
"tion removeItemFromArray(koArray, UserId) {\r\n                var items = koArray" +
"();\r\n                for (var i = 0; i < items.length; i++) {\r\n                 " +
"   if (items[i].UserId == UserId) {\r\n                        koArray.splice(i, 1" +
");\r\n                        items = koArray();\r\n                        i--;\r\n  " +
"                  }\r\n                }\r\n            }\r\n            function find" +
"UnsortedArrayTopIndex(items) {\r\n                // Only one Item\r\n              " +
"  if (items.length <= 1)\r\n                    return 0;\r\n\r\n                for (" +
"var i = 1; i < items.length; i++) {\r\n                    var s = sortFunction(it" +
"ems[i - 1], items[i]);\r\n                    if (s > 0)\r\n                        " +
"return i;\r\n                }\r\n\r\n                return 0;\r\n            }\r\n      " +
"      function findSortedInsertIndex(koArray, heldDeviceItem) {\r\n               " +
" var items = koArray();\r\n                var startIndex = findUnsortedArrayTopIn" +
"dex(items);\r\n                for (var i = startIndex; i < items.length; i++) {\r\n" +
"                    var s = sortFunction(heldDeviceItem, items[i]);\r\n           " +
"         if (s <= 0)\r\n                        return i;\r\n                }\r\n    " +
"            if (startIndex !== 0) {\r\n                    for (var i = 0; i < sta" +
"rtIndex; i++) {\r\n                        var s = sortFunction(heldDeviceItem, it" +
"ems[i]);\r\n                        if (s <= 0)\r\n                            retur" +
"n i;\r\n                    }\r\n                    return startIndex;\r\n           " +
"     } else {\r\n                    return -1;\r\n                }\r\n            }\r" +
"\n            function sortFunction(l, r) {\r\n                return l.UserIdFrien" +
"dly.toLowerCase() == r.UserIdFriendly.toLowerCase() ? 0 : (l.UserIdFriendly.toLo" +
"werCase() < r.UserIdFriendly.toLowerCase() ? -1 : 1)\r\n            }\r\n           " +
" function isInProcess(i) {\r\n                return !i.ReadyForReturn && !i.Waiti" +
"ngForUserAction;\r\n            }\r\n            function isReadyForReturn(i) {\r\n   " +
"             return i.ReadyForReturn && !i.WaitingForUserAction;\r\n            }\r" +
"\n            function isWaitingForUserAction(i) {\r\n                return i.Wait" +
"ingForUserAction;\r\n            }\r\n            function getQueryStringParameters(" +
") {\r\n\r\n                if (window.location.search.length === 0)\r\n               " +
"     return null;\r\n\r\n                var params = {};\r\n                window.lo" +
"cation.search.substr(1).split(\"&\").forEach(function (pair) {\r\n                  " +
"  if (pair === \"\") return;\r\n                    var parts = pair.split(\"=\");\r\n  " +
"                  params[parts[0]] = parts[1] && decodeURIComponent(parts[1].rep" +
"lace(/\\+/g, \" \"));\r\n                });\r\n                return params;\r\n       " +
"     }\r\n\r\n            init();\r\n        });\r\n    </script>\r\n</body>\r\n</html>");

        }
    }
}
#pragma warning restore 1591
