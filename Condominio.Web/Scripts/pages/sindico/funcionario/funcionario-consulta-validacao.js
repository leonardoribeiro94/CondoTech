function confirmarExcluir() {

    new BootstrapDialog({
        type: BootstrapDialog.TYPE_DANGER,
        title: "<b><i>Atenção!</i></b>",
        message: "<h4>Deseja realmente <b>Deletar</b> este funcionário? </h4>",

        buttons:
        [{
            label: "<b>confirmar</b>",
            icon: "fa fa-check-square-o",
            cssClass: "btn btn-primary",
            action: function () {
                dialog.close();
                $(window.btnDeletarFuncionario).click();
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