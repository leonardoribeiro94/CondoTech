function confirmarEnvio() {
   

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
            action: function (dialog) {
                dialog.close();
                $(window.btnEnviarDenuncia).click();
            }
        },
        {
            label: "Cancelar",
            cssClass: "btn-default",
            action: function (dialog) {
                dialog.close();
            }
        }]
    }).open();

    return false;
}