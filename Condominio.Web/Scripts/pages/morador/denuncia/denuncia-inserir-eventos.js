$(document).ready(function () {
    controlaCheckbox();
});

function controlaCheckbox() {
    $(window.ckbAnonimo).is(":checked",
        function () {
            $(":input").prop("disabled", false);
        });
}