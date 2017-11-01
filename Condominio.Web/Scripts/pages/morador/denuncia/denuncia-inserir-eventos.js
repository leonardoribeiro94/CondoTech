$(document).ready(function () {

    $(window.ckbAnonimo).click(function () {
        controlaCheckbox();
    });
});

function controlaCheckbox() {
    if ($(window.ckbAnonimo).is(":checked") === true) {
        $(":text").val("");
        $("#div-toogle").fadeOut();
    } else {
        $("#div-toogle").fadeIn();
    }

}