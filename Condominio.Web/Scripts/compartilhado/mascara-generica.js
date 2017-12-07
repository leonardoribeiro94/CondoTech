$(document).ready(function () {
    $(".campo-data").mask("99/99/9999");
    $(".campo-cpf").mask("99999999999");
    $(".campo-telefone").mask("(99)9999-9999");
    $(".campo-celular").mask("(99)99999-9999");
    dataCalendario();
    dataCalendarioGenerico();
});

function dataCalendario(datas) {

    var data = new Date();
    var mes = data.getMonth() + 2; //adiciona um mês a mais referente ao atual.

     $(".calendario").mask("99/99/9999").datepicker({
        language: "pt-BR",
        format: "dd/mm/yyyy",
        datesDisabled: datas,
        orientation: "bottom left",
        startDate: 1 + "/" + mes + "/" + data.getFullYear()
    });
};

function dataCalendarioGenerico() {

    var data = new Date();
    var mes = data.getMonth() + 1;

    $(".calendario-generico").mask("99/99/9999").datepicker({
        language: "pt-BR",
        format: "dd/mm/yyyy",
        orientation: "bottom left"
    });
};

