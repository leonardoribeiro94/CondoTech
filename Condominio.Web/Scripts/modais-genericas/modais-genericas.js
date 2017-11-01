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


function fn_ModalExibirImagem(imagem) {
    BootstrapDialog.show({
        type: BootstrapDialog.TYPE_PRIMARY,
        title: "<h4><b>Visualização da Imagem</b></h4>",
        message:
        "</hr>" +
        "<div>" +
        "<img src='" + imagem + "'class='modal-imagem-ajuste img-thumbnail center-block'/>" +
        "</div>" +
        "</br>",
        buttons:
        [
            {
                label: "Close",
                action: function (dialog) {
                    dialog.close();
                }
            }
        ]
    });
}