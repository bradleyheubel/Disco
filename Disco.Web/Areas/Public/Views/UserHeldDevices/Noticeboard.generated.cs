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
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Public/Views/UserHeldDevices/Noticeboard.cshtml")]
    public class Noticeboard : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Noticeboard()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Public\Views\UserHeldDevices\Noticeboard.cshtml"
  
    Layout = null;
    Html.BundleDeferred("~/ClientScripts/Modules/jQuery-SignalR");
    Html.BundleDeferred("~/ClientScripts/Core");
    Html.BundleDeferred("~/Style/Public/UserHeldDevicesNoticeboard");

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(" />\r\n    <title>Disco - Technician Held Devices</title>\r\n");

WriteLiteral("    ");

            
            #line 13 "..\..\Areas\Public\Views\UserHeldDevices\Noticeboard.cshtml"
Write(Html.BundleRenderDeferred());

            
            #line default
            #line hidden
WriteLiteral("\r\n</head>\r\n<body>\r\n    <div");

WriteLiteral(" id=\"page\"");

WriteLiteral(">\r\n        <header");

WriteLiteral(" id=\"mainHeader\"");

WriteLiteral(">\r\n    Technician Held Devices\r\n    </header>\r\n        <section");

WriteLiteral(" id=\"mainSection\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\"inProcess\"");

WriteLiteral(" class=\"list\"");

WriteLiteral(">\r\n                <h3>\r\n                    In Process <span");

WriteLiteral(" id=\"inProcessCount\"");

WriteLiteral("></span>\r\n                </h3>\r\n                <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n                    <ul>\r\n                    </ul>\r\n                </div>\r\n " +
"           </div>\r\n            <div");

WriteLiteral(" id=\"readyForReturn\"");

WriteLiteral(" class=\"list\"");

WriteLiteral(">\r\n                <h3>\r\n                    Ready for Return <span");

WriteLiteral(" id=\"readyForReturnCount\"");

WriteLiteral("></span>\r\n                </h3>\r\n                <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n                    <ul>\r\n                    </ul>\r\n                </div>\r\n " +
"           </div>\r\n            <div");

WriteLiteral(" id=\"waitingForUserAction\"");

WriteLiteral(" class=\"list\"");

WriteLiteral(">\r\n                <h3>\r\n                    Waiting for User Action <span");

WriteLiteral(" id=\"waitingForUserActionCount\"");

WriteLiteral("></span>\r\n                </h3>\r\n                <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n                    <ul>\r\n                    </ul>\r\n                </div>\r\n " +
"           </div>\r\n        </section>\r\n        <footer>\r\n        </footer>\r\n    " +
"</div>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        // Resizing\r\n        $(function () {\r\n            var $inProcess = $(\'" +
"#inProcess\');\r\n            var $inProcessContent = $inProcess.find(\'.content\');\r" +
"\n            var $inProcessHeader = $inProcess.find(\'.h3\');\r\n            var $re" +
"adyForReturn = $(\'#readyForReturn\');\r\n            var $readyForReturnContent = $" +
"readyForReturn.find(\'.content\');\r\n            var $readyForReturnHeader = $ready" +
"ForReturn.find(\'.h3\');\r\n            var $waitingForUserAction = $(\'#waitingForUs" +
"erAction\');\r\n            var $waitingForUserActionContent = $waitingForUserActio" +
"n.find(\'.content\');\r\n            var $waitingForUserActionHeader = $waitingForUs" +
"erAction.find(\'.h3\');\r\n            var $mainSection = $(\'#mainSection\');\r\n      " +
"      var $mainHeader = $(\'#mainHeader\');\r\n            var $mainFooter = $(\'#mai" +
"nFooter\');\r\n\r\n            var onResize = function () {\r\n                var widt" +
"h = $mainSection.width();\r\n                var height = $(window).height() - $ma" +
"inHeader.outerHeight() - $mainFooter.outerHeight() - 25;\r\n\r\n                $inP" +
"rocess.height(height);\r\n                $inProcess.width((width * .28) - 11);\r\n " +
"               $inProcessContent.height(height - $inProcessHeader.outerHeight() " +
"- 56);\r\n\r\n                $readyForReturn.height(height);\r\n                $read" +
"yForReturn.width((width * .36) - 11);\r\n                $readyForReturnContent.he" +
"ight(height - $readyForReturnHeader.outerHeight() - 56);\r\n\r\n                $wai" +
"tingForUserAction.height(height);\r\n                $waitingForUserAction.width((" +
"width * .36) - 11);\r\n                $waitingForUserActionContent.height(height " +
"- $waitingForUserActionHeader.outerHeight() - 56);\r\n            };\r\n\r\n          " +
"  $(window).resize(onResize);\r\n            onResize();\r\n        });\r\n    </scrip" +
"t>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        // Hide Mouse Mouse
        $(function () {
            var mouseVisible = true;
            var mouseHideToken;
            var documentBody = $('body');

            var hideMouse = function () {
                if (mouseVisible) {
                    documentBody.css('cursor', 'none');
                    mouseVisible = false;
                }
            };
            var showMouse = function () {
                if (!mouseVisible) {
                    documentBody.css('cursor', 'auto');
                    mouseVisible = true;
                }
            };

            $(document).mousemove(function () {
                showMouse();
                if (mouseHideToken)
                    window.clearTimeout(mouseHideToken);
                mouseHideToken = window.setTimeout(hideMouse, 2000);
            });
        });
    </script>
    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(function () {\r\n            var models = {};\r\n            var modelsI" +
"nProcessSorted = [];\r\n            var modelsInProcessCount = 0;\r\n            var" +
" modelsReadyForReturnSorted = [];\r\n            var modelsReadyForReturnCount = 0" +
";\r\n            var modelsWaitingForUserActionSorted = [];\r\n            var model" +
"sWaitingForUserActionCount = 0;\r\n            var $inProcess = $(\'#inProcess\');\r\n" +
"            var $inProcessContent = $inProcess.find(\'.content ul\');\r\n           " +
" var $readyForReturn = $(\'#readyForReturn\');\r\n            var $readyForReturnCon" +
"tent = $readyForReturn.find(\'.content ul\');\r\n            var $waitingForUserActi" +
"on = $(\'#waitingForUserAction\');\r\n            var $waitingForUserActionContent =" +
" $waitingForUserAction.find(\'.content ul\');\r\n            var modelsInProcessInde" +
"xOffset = 0;\r\n            var scrollInProcessToken = null;\r\n            var mode" +
"lsReadyForReturnIndexOffset = 0;\r\n            var scrollReadyForReturnToken = nu" +
"ll;\r\n            var modelsWaitingForUserActionIndexOffset = 0;\r\n            var" +
" scrollWaitingForUserActionToken = null;\r\n            var scrollSpeed = 3000;\r\n " +
"           var persistantConnection = null;\r\n            var filterDeviceAddress" +
"Include;\r\n            var filterDeviceAddressExclude;\r\n            var filterDev" +
"iceProfileInclude;\r\n            var filterDeviceProfileExclude;\r\n            \r\n " +
"           var getParameterByName = function (name) {\r\n                name = na" +
"me.replace(/[\\[]/, \"\\\\\\[\").replace(/[\\]]/, \"\\\\\\]\");\r\n                var regexS " +
"= \"[\\\\?&]\" + name + \"=([^&#]*)\";\r\n                var regex = new RegExp(regexS)" +
";\r\n                var results = regex.exec(window.location.search);\r\n          " +
"      if (results == null)\r\n                    return \"\";\r\n                else" +
"\r\n                    return decodeURIComponent(results[1].replace(/\\+/g, \" \"));" +
"\r\n            }\r\n\r\n            var buildFilters = function () {\r\n               " +
" var deviceAddressInclude = getParameterByName(\'deviceAddressInclude\');\r\n       " +
"         if (deviceAddressInclude) {\r\n                    filterDeviceAddressInc" +
"lude = {};\r\n                    var split = deviceAddressInclude.split(\",\");\r\n  " +
"                  for (var i = 0; i < split.length; i++) {\r\n                    " +
"    filterDeviceAddressInclude[split[i].toLowerCase()] = true;\r\n                " +
"    }\r\n                } else {\r\n                    var deviceAddressExclude = " +
"getParameterByName(\'deviceAddressExclude\');\r\n                    if (deviceAddre" +
"ssExclude) {\r\n                        filterDeviceAddressExclude = {};\r\n        " +
"                var split = deviceAddressExclude.split(\",\");\r\n                  " +
"      for (var i = 0; i < split.length; i++) {\r\n                            filt" +
"erDeviceAddressExclude[split[i].toLowerCase()] = true;\r\n                        " +
"}\r\n                    } else {\r\n                        var deviceProfileInclud" +
"e = getParameterByName(\'deviceProfileInclude\');\r\n                        if (dev" +
"iceProfileInclude) {\r\n                            filterDeviceProfileInclude = {" +
"};\r\n                            var deviceProfileIncludeSplit = deviceProfileInc" +
"lude.split(\",\");\r\n                            for (var i = 0; i < deviceProfileI" +
"ncludeSplit.length; i++) {\r\n                                filterDeviceProfileI" +
"nclude[parseInt(deviceProfileIncludeSplit[i])] = true;\r\n                        " +
"    }\r\n                        } else {\r\n                            var deviceP" +
"rofileExclude = getParameterByName(\'deviceProfileExclude\');\r\n                   " +
"         if (deviceProfileExclude) {\r\n                                filterDevi" +
"ceProfileExclude = {};\r\n                                var deviceProfileExclude" +
"Split = deviceProfileExclude.split(\",\");\r\n                                for (v" +
"ar i = 0; i < deviceProfileExcludeSplit.length; i++) {\r\n                        " +
"            filterDeviceProfileExclude[parseInt(deviceProfileExcludeSplit[i])] =" +
" true;\r\n                                }\r\n                            }\r\n      " +
"                  }\r\n                    }\r\n                }\r\n            }\r\n  " +
"          var calculateFilter = function (model) {\r\n                if (model) {" +
"\r\n                    if (filterDeviceAddressInclude) {\r\n                       " +
" return (filterDeviceAddressInclude[model.DeviceAddress.toLowerCase()] == true)\r" +
"\n                    }\r\n                    if (filterDeviceAddressExclude) {\r\n " +
"                       return (!filterDeviceAddressExclude[model.DeviceAddress.t" +
"oLowerCase()])\r\n                    }\r\n                    if (filterDeviceProfi" +
"leInclude) {\r\n                        return (filterDeviceProfileInclude[model.D" +
"eviceProfileId] == true)\r\n                    }\r\n                    if (filterD" +
"eviceProfileExclude) {\r\n                        return (!filterDeviceProfileExcl" +
"ude[model.DeviceProfileId])\r\n                    }\r\n                    return t" +
"rue;\r\n                }\r\n                return false;\r\n            }\r\n\r\n       " +
"     var sortModels = function () {\r\n                modelsInProcessSorted = [];" +
"\r\n                modelsReadyForReturnSorted = [];\r\n                modelsWaitin" +
"gForUserActionSorted = [];\r\n                var modelSortFunc = function (a, b) " +
"{\r\n                    if (a.UserId.toUpperCase() == b.UserId.toUpperCase()) {\r\n" +
"                        return 0;\r\n                    } else {\r\n               " +
"         if (a.UserId.toUpperCase() < b.UserId.toUpperCase()) {\r\n               " +
"             return -1\r\n                        } else {\r\n                      " +
"      return 1\r\n                        }\r\n                    }\r\n              " +
"  };\r\n                for (var key in models) {\r\n                    var model =" +
" models[key];\r\n                    if (model) {\r\n                        if (mod" +
"el.WaitingForUserAction) {\r\n                            modelsWaitingForUserActi" +
"onSorted.push(model);\r\n                        } else {\r\n                       " +
"     if (model.ReadyForReturn) {\r\n                                modelsReadyFor" +
"ReturnSorted.push(model);\r\n                            } else {\r\n               " +
"                 modelsInProcessSorted.push(model);\r\n                           " +
" }\r\n                        }\r\n                    }\r\n                }\r\n       " +
"         modelsReadyForReturnSorted = modelsReadyForReturnSorted.sort(modelSortF" +
"unc);\r\n                modelsInProcessSorted = modelsInProcessSorted.sort(modelS" +
"ortFunc);\r\n                modelsWaitingForUserActionSorted = modelsWaitingForUs" +
"erActionSorted.sort(modelSortFunc);\r\n\r\n                if (modelsInProcessSorted" +
".length != modelsInProcessCount) {\r\n                    modelsInProcessCount = m" +
"odelsInProcessSorted.length;\r\n                    $(\'#inProcessCount\').text(\'(\' " +
"+ modelsInProcessCount + \')\');\r\n                }\r\n                if (modelsRea" +
"dyForReturnSorted.length != modelsReadyForReturnCount) {\r\n                    mo" +
"delsReadyForReturnCount = modelsReadyForReturnSorted.length;\r\n                  " +
"  $(\'#readyForReturnCount\').text(\'(\' + modelsReadyForReturnCount + \')\');\r\n      " +
"          }\r\n                if (modelsWaitingForUserActionSorted.length != mode" +
"lsWaitingForUserActionCount) {\r\n                    modelsWaitingForUserActionCo" +
"unt = modelsWaitingForUserActionSorted.length;\r\n                    $(\'#waitingF" +
"orUserActionCount\').text(\'(\' + modelsWaitingForUserActionCount + \')\');\r\n        " +
"        }\r\n\r\n            };\r\n\r\n            var scrollReadyForReturn = function (" +
") {\r\n                $readyForReturnContent.find(\'li\').last().detach().prependTo" +
"($readyForReturnContent).hide().slideDown(\'slow\');\r\n                modelsReadyF" +
"orReturnIndexOffset++;\r\n                if (modelsReadyForReturnIndexOffset >= m" +
"odelsReadyForReturnSorted.length) {\r\n                    modelsReadyForReturnInd" +
"exOffset = 0;\r\n                }\r\n                scrollReadyForReturnToken = wi" +
"ndow.setTimeout(scrollReadyForReturn, scrollSpeed);\r\n            };\r\n           " +
" var updateScrollReadyForReturn = function () {\r\n                var containerHe" +
"ight = $readyForReturn.find(\'.content\').height();\r\n                var contentHe" +
"ight = $readyForReturnContent.height();\r\n                if (containerHeight >= " +
"contentHeight && scrollReadyForReturnToken) {\r\n                    window.clearT" +
"imeout(scrollReadyForReturnToken);\r\n                    return;\r\n               " +
" }\r\n                if (containerHeight < contentHeight && scrollReadyForReturnT" +
"oken == null) {\r\n                    scrollReadyForReturnToken = window.setTimeo" +
"ut(scrollReadyForReturn, scrollSpeed);\r\n                }\r\n            };\r\n     " +
"       var scrollInProcess = function () {\r\n                $inProcessContent.fi" +
"nd(\'li\').last().detach().prependTo($inProcessContent).hide().slideDown(\'slow\');\r" +
"\n                modelsInProcessIndexOffset++;\r\n                if (modelsInProc" +
"essIndexOffset >= modelsInProcessSorted.length) {\r\n                    modelsInP" +
"rocessIndexOffset = 0;\r\n                }\r\n                scrollInProcessToken " +
"= window.setTimeout(scrollInProcess, scrollSpeed);\r\n            };\r\n            " +
"var updateScrollInProcess = function () {\r\n                var containerHeight =" +
" $inProcess.find(\'.content\').height();\r\n                var contentHeight = $inP" +
"rocessContent.height();\r\n                if (containerHeight >= contentHeight &&" +
" scrollInProcessToken) {\r\n                    window.clearTimeout(scrollInProces" +
"sToken);\r\n                    return;\r\n                }\r\n                if (co" +
"ntainerHeight < contentHeight && scrollInProcessToken == null) {\r\n              " +
"      scrollInProcessToken = window.setTimeout(scrollInProcess, scrollSpeed);\r\n " +
"               }\r\n            };\r\n            var scrollWaitingForUserAction = f" +
"unction () {\r\n                $waitingForUserActionContent.find(\'li\').last().det" +
"ach().prependTo($waitingForUserActionContent).hide().slideDown(\'slow\');\r\n       " +
"         modelsInProcessIndexOffset++;\r\n                if (modelsWaitingForUser" +
"ActionIndexOffset >= modelsWaitingForUserActionSorted.length) {\r\n               " +
"     modelsWaitingForUserActionIndexOffset = 0;\r\n                }\r\n            " +
"    scrollWaitingForUserActionToken = window.setTimeout(scrollWaitingForUserActi" +
"on, scrollSpeed);\r\n            };\r\n            var updateScrollWaitingForUserAct" +
"ion = function () {\r\n                var containerHeight = $waitingForUserAction" +
".find(\'.content\').height();\r\n                var contentHeight = $waitingForUser" +
"ActionContent.height();\r\n                if (containerHeight >= contentHeight &&" +
" scrollWaitingForUserActionToken) {\r\n                    window.clearTimeout(scr" +
"ollWaitingForUserActionToken);\r\n                    return;\r\n                }\r\n" +
"                if (containerHeight < contentHeight && scrollWaitingForUserActio" +
"nToken == null) {\r\n                    scrollWaitingForUserActionToken = window." +
"setTimeout(scrollWaitingForUserAction, scrollSpeed);\r\n                }\r\n       " +
"     };\r\n\r\n            var modelInsertIndex = function (model) {\r\n              " +
"  sortModels();\r\n                var findIndex = function (model, array, offset)" +
" {\r\n                    for (var i = 0; i < array.length; i++) {\r\n              " +
"          if (model.UserId == array[i].UserId) {\r\n                            va" +
"r index = i + offset;\r\n                            if (index > (array.length - 1" +
")) {\r\n                                index = index - (array.length - 1);\r\n     " +
"                       }\r\n                            return index;\r\n           " +
"             }\r\n                    };\r\n                };\r\n                if (" +
"model.WaitingForUserAction) {\r\n                    return findIndex(model, model" +
"sWaitingForUserActionSorted, modelsWaitingForUserActionIndexOffset);\r\n          " +
"      } else {\r\n                    if (model.ReadyForReturn) {\r\n               " +
"         return findIndex(model, modelsReadyForReturnSorted, modelsReadyForRetur" +
"nIndexOffset);\r\n                    } else {\r\n                        return fin" +
"dIndex(model, modelsInProcessSorted, modelsInProcessIndexOffset);\r\n             " +
"       }\r\n                }\r\n            }\r\n            var modelInsert = functi" +
"on (model) {\r\n                var index = modelInsertIndex(model);\r\n            " +
"    var insertTo = function (model, host) {\r\n                    var hostLi = ho" +
"st.children(\'li\');\r\n                    if (hostLi.length == 0 || hostLi.length " +
"< index) {\r\n                        host.append(model.htmlLi);\r\n                " +
"    } else {\r\n                        if (index == 0) {\r\n                       " +
"     host.prepend(model.htmlLi);\r\n                        } else {\r\n            " +
"                $(hostLi.get(index - 1)).after(model.htmlLi);\r\n                 " +
"       }\r\n                    }\r\n                }\r\n                if (model.Wa" +
"itingForUserAction) {\r\n                    insertTo(model, $waitingForUserAction" +
"Content);\r\n                    window.setTimeout(updateScrollWaitingForUserActio" +
"n, 100);\r\n                } else {\r\n                    if (model.ReadyForReturn" +
") {\r\n                        insertTo(model, $readyForReturnContent);\r\n         " +
"               window.setTimeout(updateScrollReadyForReturn, 100);\r\n            " +
"        } else {\r\n                        insertTo(model, $inProcessContent);\r\n " +
"                       window.setTimeout(updateScrollInProcess, 100);\r\n         " +
"           }\r\n                }\r\n            }\r\n\r\n            var removeModel = " +
"function (model) {\r\n                if (model) {\r\n                    if (model." +
"updateAtToken) {\r\n                        window.clearTimeout(model.updateAtToke" +
"n);\r\n                    };\r\n                    model.htmlLi.slideUp(\'fast\', fu" +
"nction () {\r\n                        model.htmlLi.remove();\r\n                   " +
" });\r\n                }\r\n            };\r\n\r\n            var scheduleModelUpdate =" +
" function (model) {\r\n                if (model.updateAtToken) {\r\n               " +
"     window.clearTimeout(model.updateAtToken);\r\n                };\r\n            " +
"    if (model.UpdateAt) {\r\n                    if (typeof model.UpdateAt == \'str" +
"ing\' && model.UpdateAt.indexOf(\'\\/Date(\') == 0) {\r\n                        model" +
".UpdateAt = new Date(parseInt(model.UpdateAt.substr(6)));\r\n                    }" +
"\r\n                    var nowMilliseconds = new Date().getTime();\r\n             " +
"       var updateAtMilliseconds = (model.UpdateAt - nowMilliseconds);\r\n         " +
"           if (updateAtMilliseconds > 0) {\r\n                        model.update" +
"AtToken = window.setTimeout(function () { updatedModel(model.UserId); }, updateA" +
"tMilliseconds);\r\n                    } else {\r\n                        model.Upd" +
"ateAt = null;\r\n                    }\r\n                }\r\n            };\r\n\r\n     " +
"       var processModel = function (id, model, init) {\r\n                if (!cal" +
"culateFilter(model)) {\r\n                    removeModel(models[id]);\r\n          " +
"          delete models[id];\r\n                    sortModels();\r\n               " +
" } else {\r\n                    var existing = models[id];\r\n                    m" +
"odels[id] = model;\r\n\r\n                    // Add\r\n                    model.html" +
"Content = $(\'<div>\').text(model.UserId + \' - \' + model.UserDisplayName);\r\n      " +
"              if (!model.ReadyForReturn && model.EstimatedReturnTime) {\r\n       " +
"                 model.htmlContent.append($(\'<span class=\"small\">\').text(\' (Expe" +
"cted: \' + model.EstimatedReturnTime + \')\'));\r\n                    }\r\n           " +
"         if (model.WaitingForUserAction) {\r\n                        model.htmlCo" +
"ntent.append($(\'<span class=\"small\">\').text(\' (Since \' + model.WaitingForUserAct" +
"ionSince + \')\'));\r\n                    } else {\r\n                        if (mod" +
"el.ReadyForReturn && model.ReadyForReturnSince) {\r\n                            m" +
"odel.htmlContent.append($(\'<span class=\"small\">\').text(\' (Ready \' + model.ReadyF" +
"orReturnSince + \')\'));\r\n                        }\r\n                    }\r\n\r\n    " +
"                if (existing) {\r\n                        if (existing.ReadyForRe" +
"turn != model.ReadyForReturn || existing.WaitingForUserAction != model.WaitingFo" +
"rUserAction) {\r\n                            removeModel(existing);\r\n            " +
"                model.htmlLi = $(\'<li>\').html(model.htmlContent).data(\'ModelId\'," +
" id).hide();\r\n                            modelInsert(model);\r\n                 " +
"           if (init) {\r\n                                model.htmlLi.fadeIn();\r\n" +
"                            } else {\r\n                                model.html" +
"Li.slideDown();\r\n                            }\r\n                        } else {" +
"\r\n                            if (existing.updateAtToken) {\r\n                   " +
"             window.clearTimeout(existing.updateAtToken);\r\n                     " +
"       };\r\n                            model.htmlLi = existing.htmlLi;\r\n        " +
"                    model.htmlLi.slideUp(\'fast\', function () {\r\n                " +
"                model.htmlLi.html(model.htmlContent).slideDown();\r\n             " +
"               });\r\n                        }\r\n                    } else {\r\n   " +
"                     model.htmlLi = $(\'<li>\').html(model.htmlContent).data(\'Mode" +
"lId\', id).hide();\r\n                        modelInsert(model);\r\n                " +
"        if (init) {\r\n                            model.htmlLi.fadeIn();\r\n       " +
"                 } else {\r\n                            model.htmlLi.slideDown(\'s" +
"low\');\r\n                        }\r\n                    }\r\n                    if" +
" (model.htmlLi && model.IsAlert) {\r\n                        model.htmlLi.addClas" +
"s(\'alert\');\r\n                    }\r\n                    scheduleModelUpdate(mode" +
"l);\r\n                }\r\n            };\r\n\r\n            var updatedModel = functio" +
"n (id) {\r\n                var UserId = id.toString();\r\n                $.getJSON" +
"(\'");

            
            #line 457 "..\..\Areas\Public\Views\UserHeldDevices\Noticeboard.cshtml"
                       Write(Url.Action(MVC.Public.UserHeldDevices.UserHeldDevice()));

            
            #line default
            #line hidden
WriteLiteral(@"', { id: UserId }, function (data) {
                    processModel(UserId, data, false);
                });
            };

            var connectionError = function () {
                if (persistantConnection) {
                    persistantConnection.stop();
                    persistantConnection = null;
                    window.setTimeout(function () {
                        window.location.href = '");

            
            #line 467 "..\..\Areas\Public\Views\UserHeldDevices\Noticeboard.cshtml"
                                            Write(Url.Action(MVC.Public.UserHeldDevices.Noticeboard()));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n                    }, 10000);\r\n                }\r\n            }\r\n\r\n         " +
"   var init = function () {\r\n                buildFilters();\r\n                pe" +
"rsistantConnection = $.connection(\'");

            
            #line 474 "..\..\Areas\Public\Views\UserHeldDevices\Noticeboard.cshtml"
                                                 Write(Url.Content("~/Public/UserHeldDevices/Notifications"));

            
            #line default
            #line hidden
WriteLiteral("\');\r\n                persistantConnection.received(updatedModel);\r\n              " +
"  persistantConnection.error(connectionError);\r\n                persistantConnec" +
"tion.start(function () {\r\n                    $.getJSON(\'");

            
            #line 478 "..\..\Areas\Public\Views\UserHeldDevices\Noticeboard.cshtml"
                           Write(Url.Action(MVC.Public.UserHeldDevices.UserHeldDevices()));

            
            #line default
            #line hidden
WriteLiteral(@"', null, function (data) {
                        for (var i = 0; i < data.length; i++) {
                            processModel(data[i].UserId, data[i], true);
                        }
                    });
                });
            };
            init();

        });
    </script>
    <div");

WriteLiteral(" id=\"mainFooter\"");

WriteLiteral(">\r\n        <img");

WriteLiteral(" style=\"width: 32px; height: 32px; margin-top: -5px; margin-bottom: -15px;\"");

WriteAttribute("src", Tuple.Create(" src=\"", 23515), Tuple.Create("\"", 23564)
            
            #line 490 "..\..\Areas\Public\Views\UserHeldDevices\Noticeboard.cshtml"
            , Tuple.Create(Tuple.Create("", 23521), Tuple.Create<System.Object, System.Int32>(Links.ClientSource.Style.Images.Icon32_png
            
            #line default
            #line hidden
, 23521), false)
);

WriteLiteral(" alt=\"Disco Logo\"");

WriteLiteral(" />\r\n        powered by Disco\r\n    </div>\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591
