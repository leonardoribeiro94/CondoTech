function validaCamposFuncionario() {
    var returnBool = true;

         if ($(window.txtNome).val().length < 3) {
             exibeModal("Valor incorreto para o campo Nome");
             returnBool = false;
         }
         else if ($(window.txtDataNascimento).val()
             .replace("/", "").length < 8) {
             exibeModal("Valor incorreto para o campo Data de Nascimento");
             returnBool = false;
         }
         else if ($(window.txtTelefone).val()
             .replace("(", "")
             .replace(")", "")
             .replace("-", "").length < 8) {
             exibeModal("Valor incorreto para o campo Telefone");
             returnBool = false;
         }
         else if ($(window.txtCelular).val()
             .replace("(", "")
             .replace(")", "")
             .replace("-", "").length < 8) {
             exibeModal("Valor incorreto para o campo Celular");
         }
         else if ($(window.txtEmail).val().length < 5) {
             exibeModal("Valor incorreto para o campo E-mail");
             returnBool = false;
         };

    return returnBool;
}

function exibeModal(mensagem) {
    BootstrapDialog.show({
        type: BootstrapDialog.TYPE_WARNING,
        title: "Atenção",
        message: mensagem
    });
    
};

function verificaCampo(nomeCampo, idDiv, caracteres) {

    if ($(nomeCampo).val()
        .replace("(", "")
        .replace(")", "")
        .replace("-", "")
        .replace("_", "")
        .replace("/","").length < caracteres) {
        $(idDiv).removeClass("has-success").addClass("has-error");
    } else {
        $(idDiv).removeClass("has-error").addClass("has-success");
    }
}