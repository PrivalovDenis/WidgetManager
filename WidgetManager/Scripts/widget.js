$(document).ready(function () {
    $("#getVidgetBtn").click(function () {
        $("#employees_list").remove();
        var url = window.location.origin.toString() + "/Home/Widget";
        var jqxhr = $.ajax(url)
            .done(function (response) {
                $("body").append(response);
            }).fail(function () {
            }).always(function () { });
    });
});