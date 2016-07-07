/// <autosync enabled="true" />
/// <reference path="jquery-2.2.4" />
/// <reference path="bootstrap.js" />

(function () {
    var div = {
        fulldiv: function (zindex) {
            var idname = "__full",
                div = $("#" + idname + "");
            if (div.length == 0) {
                var div = $("<div id='" + idname + "' class='max full' style='z-index:" + (zindex || 9000) + "'></div>");
                $("body").append(div);
                return div;
            } else {
                return div;
            }
        },
        loginform: function () {
            global.ajaxwithblock({
                url: 'Identity/Account/LoginForm',
                success: function (response) {
                    if ($("#loginform").length == 0) {
                        $("body").append($(response));
                    }
                }
            });
        },
    };

    var global = {
        ajaxwithblock: function (ops) {
            div.fulldiv().block(); $.ajax(ops).done(function () { div.fulldiv().remove(); });
        },
        ldentity: {
            login: function () {

            }
        },
    };

    window.div = div;
    window.global = global;
})();