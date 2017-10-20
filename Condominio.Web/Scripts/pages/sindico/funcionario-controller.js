function excluirFuncionario(id) {
    $.ajax({
        type: "POST",
        data: id,
        url: "ConsultarFuncionario.aspx/Deletar", // url da pagina/nome do metodo 
        contentType: "application/json; charset=utf-8",
        dataType: "json"
    });
}
