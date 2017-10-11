$(document).ready(function () {

    $(".details").click(function () {

        var id = $(this).attr("data-id");

        $("#modal").load("Details/" + id,
            function () {
                $("#modal").modal("show");
            });
    });

});

