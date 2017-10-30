function validaCamposInformativo() {
    var returnBool = true;

         if ($(window.txtTitulo).val().length < 3) {
             exibeModal("Valor incorreto para o campo Título");
             returnBool = false;
         }
         else if ($(window.txtObservacao).val()
             .replace("/", "").length < 8) {
             exibeModal("Valor incorreto para o campo txtObservacao");
             returnBool = false;
         }
         
    return returnBool;
}

function exibeModal(mensagem) {
    BootstrapDialog.show({
        type: BootstrapDialog.TYPE_WARNING,
        title: "Atenção",
        message: mensagem
    });
    
};

