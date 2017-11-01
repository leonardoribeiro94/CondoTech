function confirmarEnvio() {
    var opcaobool = false;

    new BootstrapDialog({
        type: BootstrapDialog.TYPE_DANGER,
        title: "<b><i>Atenção!</i></b>",
        message: "<h4>Deseja realmente <b>Enviar</b> esta denuncia? </h4>" +
        "<p>" +
        "O conteúdo informado será enviado e analizado pelos administradores do condomínio" +
        "</p>",

        buttons:
        [{
            label: "<b>confirmar</b>",
            icon: "fa fa-check-square-o",
            cssClass: "btn btn-primary",
            action: function () {
                dialog.close();
                opcaobool = true;
            }
        },
        {
            label: "Cancelar",
            cssClass: "btn-default",
            action: function (dialog) {
                opcaobool = false;
                dialog.close();
            }
        }]
    }).open();

    return opcaobool;
}