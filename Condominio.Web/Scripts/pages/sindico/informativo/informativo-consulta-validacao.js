function confirmarExcluir() {

    new BootstrapDialog({
        type: BootstrapDialog.TYPE_DANGER,
        title: "<b><i>Atenção!</i></b>",
        message: "<h4>Deseja realmente <b>Deletar</b> este informativo? </h4>",

        buttons:
        [{
                label: "<b>confirmar</b>",
                icon: "fa fa-check-square-o",
                cssClass: "btn btn-primary",
                action: function (dialog) {
                    dialog.close();
                    $(window.btnDeletarInformativo).click();
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

