function modalDadosMorador(dados) {
    BootstrapDialog.show({
        title: "<b><i>Detalhes!</i></b>",
        message:
        "<h4><span><i class='fa fa-user-circle-o fa-3x' aria-hidden='true'></i></span> &nbsp;<b>Dados</b> do morador</h4>" +
        "</hr><br>" +
        "<span>" +
        "<label style='width:140px'><b>Nome: </b></label>" +
        "<span>" +
        dados.Nome +
        "</span>" +
        "</br>" +
        "<label style='width:140px'><b>CPF: </b></label>" +
        "<span>" +
        dados.Cpf +
        "</span>" +
        "</br>" +
        "<label style='width:140px'>E-mail: </b></label>" +
        "<span>" +
        dados.Email +
        "</span>" +
        "</br>" +
        "<label style='width:140px'>Telefone: </b></label>" +
        "<span>" +
        dados.Telefone +
        "</span>" +
        "</hr>",
        buttons:
        [
            {
                label: "Fechar",
                cssClass: "btn-default",
                action: function (dialog) {
                    dialog.close();
                }
            }
        ]
    });
    return false;
}