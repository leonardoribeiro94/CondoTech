function validacaoReserva() {
    BootstrapDialog.show({
        type: BootstrapDialog.TYPE_WARNING,
        title: "<h4><b>Atenção!</b></h4>",
        message:  "Mensagem: <h3>Sua solicitação será avaliada pelo síndico!<br><br>Você pode acompanhar o status do pedido em 'minhas reservas' da tela anterior.</h3>",
        buttons:
        [{
            label: "&nbsp;Confirmar",
            icon: "fa fa-check-square-o",
            cssClass: "btn btn-primary",
            action: function (dialog) {
                $(window.btnSolicitarPedido).click();
            }
        }]

    });
}
