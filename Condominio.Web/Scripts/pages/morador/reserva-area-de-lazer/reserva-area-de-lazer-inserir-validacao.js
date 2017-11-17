function validacaoReserva() {
    BootstrapDialog.show({
        type: BootstrapDialog.TYPE_PRIMARY,
        title: "<h4><b>Atenção!</b></h4>",
        message:  "<h3>Reserva realizada com sucesso!</h3>",
        buttons:
        [{
            label: "&nbsp;Confirmar",
            icon: "fa fa-check-square-o",
            cssClass: "btn btn-primary",
            action: function () {
                $(window.btnSolicitarPedido).click();
            }
        }]

    });
}


function validacaoReserva() {

    BootstrapDialog.show({
        type: BootstrapDialog.TYPE_PRIMARY,
        title: "<h4><b>Atenção!</b></h4>",
        message: "<h3>Deseja  <b>Cancelar</b> sua reserva?</h3>",
        buttons:
        [{
            label: "&nbsp;Confirmar",
            icon: "fa fa-check-square-o",
            cssClass: "btn btn-primary",
            action: function () {
                $(window.btnCancelaReserva).click();
            }
        }]

    });
}