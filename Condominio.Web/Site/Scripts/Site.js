$(document).ready(function () {

    // Adicione uma rolagem suave para todos os links na barra de navegação + link do rodapé
    $(".navbar a, footer a[href='#myPage']").on("click", function (event) {


        // Certifico-me de que this.hash tenha um valor antes de substituir o comportamento padrão
        if (this.hash !== "") {


            // Prevenção do comportamento do clique da âncora padrão
            event.preventDefault();

            // Store hash
            var hash = this.hash;

            // Usando o método animate () do jQuery para adicionar scroll suave da página
            // O número opcional (900) especifica o número de milissegundos necessários para se deslocar para a área especificada
            $("html, body").animate({
                scrollTop: $(hash).offset().top
            }, 900, function () {

                // Adicionar hash (#) ao URL quando feito rolagem (comportamento de clique padrão)
                window.location.hash = hash;
            });
        }
    });

    //animação de slide suave dos icones
    $(window).scroll(function () {
        $(".slideanim").each(function () {
            var pos = $(this).offset().top;

            var winTop = $(window).scrollTop();
            if (pos < winTop + 600) {
                $(this).addClass("slide");
            }
        });
    });
})


