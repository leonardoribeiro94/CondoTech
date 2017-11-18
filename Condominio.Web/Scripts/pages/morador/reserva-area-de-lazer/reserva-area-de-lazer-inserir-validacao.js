function validacaoReserva() {

    if ($(window.txtDataReserva).val().length < 10) {
        BootstrapDialog.show({
            type: BootstrapDialog.TYPE_DANGER,
            title: "<h4><b>Atenção!</b></h4>",
            message: "<h3>Informe a <b>Data</b> da sua reserva! </h3>",
        });
    } else {
        BootstrapDialog.show({
            type: BootstrapDialog.TYPE_PRIMARY,
            title: "<h4><b>Atenção!</b></h4>",
            message: "<h3>Ao solicitar esta reserva o Síndico poderá entrar em contato através do seu telefone ou e-mail! </h3>",
            buttons:
            [
                {
                    label: "&nbsp;Confirmar",
                    icon: "fa fa-check-square-o",
                    cssClass: "btn btn-primary",
                    action: function () {
                        $(window.btnSolicitarPedido).click();
                    }
                }
            ]

        });
    }
}