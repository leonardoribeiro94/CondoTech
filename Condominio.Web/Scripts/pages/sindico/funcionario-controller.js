function excluirFuncionario(id) {
    $.ajax({
        type: "POST",
        url: "ConsultarFuncionario.aspx/Deletar", // url da pagina/nome do metodo 
        data: JSON.stringify(id),
        contentType: "application/json; charset=utf-8",
        dataType: "json"
    });
}

function listarFucionarios()
{
    $.ajax({
        type: "POST",
        url: "ConsultarFuncionario.aspx/Deletar", // url da pagina/nome do metodo 
        data: JSON.stringify(id),
        contentType: "application/json; charset=utf-8",
        dataType: "json"
    });
}