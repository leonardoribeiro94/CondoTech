$(document).ready(function () {
});

function chamaModal(operacao) {
    var id;

    if (operacao.toLowerCase() === "i") {

        id = $(".details").attr("data-id");

        $("#divConteudo").load("Details?id=" + id, function () {

            $("#ModalLabel").text("Detalhes");
            $("#minhaModal").modal("show");
            $("#footerModalFuncionario").hide();
        });
    }

    if (operacao.toLowerCase() === "u") {

        id = $(".edit").attr("data-id");

        $("#divConteudo").load("Edit?id=" + id, function () {

            $("#ModalLabel").text("Editar");
            $("#minhaModal").modal("show");
            $("#footerModalFuncionario").show();
        });
    }
}