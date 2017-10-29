function verificaCampo(nomeCampo, idDiv, caracteres) {

    if ($(nomeCampo).val()
        .replace("(", "")
        .replace(")", "")
        .replace("-", "")
        .replace("_", "")
        .replace("/", "").length < caracteres) {
        $(idDiv).removeClass("has-success").addClass("has-error");
    } else {
        $(idDiv).removeClass("has-error").addClass("has-success");
    }
}