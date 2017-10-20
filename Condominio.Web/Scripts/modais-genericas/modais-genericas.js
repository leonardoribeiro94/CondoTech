function fn_ModalError(mensagemDeExcessao) {
    BootstrapDialog.show({
        type: BootstrapDialog.TYPE_WARNING,
        title: "<h4><b>Atenção!</b></h4>",
        message: "Houve um imprevisto ao realizar esta operação, " +
        "Tente novamente!. Em caso de dúvidas entre em contato com o suporte do sistema."
        + "<br><br>"
        + "Mensagem: " + mensagemDeExcessao,
        buttons:
        [{
            label: "Close",
            action: function (dialog) {
                dialog.close();
            }
        }]

    });
}