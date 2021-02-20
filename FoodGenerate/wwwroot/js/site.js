// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function(e) {
    $("#vote-group p > button").each(function(index, item) {
        $(item).click(function() {
            var vote = $(item).attr("value");
            $.ajax({
                url: "/Home/Result",
                datatype: "text",
                data: {
                    value: vote
                },
                type: "POST",
                success: function(result) {
                    $("#vote-results").html(result);
                },
                error: function() {
                    $("#vote-results").html("ERROR");
                }
            });
        });
    });
});