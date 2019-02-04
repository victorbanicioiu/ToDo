$(document).ready(function () {
    $.ajax({
        url: '/Items/buildList',
        success: function (result) {
            $('#tableDiv').html(result);
        }
    });
});