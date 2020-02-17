// données globales
var content;
var loading;
function calculer() {
    // d'abord les références sur le DOM
    var formulaire = $("#formulaire");
    // ensuite validation du formulaire
    if (!formulaire.validate().form()) {
        // formulaire invalide - terminé
        return;
    }
    // on fait un appel Ajax à la main
    $.ajax({
        url: '/Premier/Action05FaireCalcul',
        type: 'POST',
        data: formulaire.serialize(),
        dataType: 'html',
        beforeSend: function () {
            loading.show();
        },
        success: function (data) {
            content.html(data);
        },
        complete: function () {
            loading.hide();
        },
        error: function (jqXHR) {
            // affichage réponse serveur
            content.html(jqXHR.responseText);
        }
    })
    console.log("im in calcul");
}
function retourSaisies() {
    $.ajax({
        url: '/Premier/Action05RetourSaisies',
        type: 'POST',
        dataType: 'html',
        beforeSend: function () {
            loading.show();
        },
        success: function (data) {
            content.html(data);
        },
        complete: function () {
            loading.hide();
            // IMPORTANT !! validation
            $.validator.unobtrusive.parse($("#formulaire"));
        },
        error: function (jqXHR) {
            content.html(jqXHR.responseText);
        }
    })
}
function effacer() {
    // d'abord les références sur le DOM
    var formulaire = $("#formulaire");
    var A = $("#A");
    var B = $("#B");
    // on affecte des valeurs valides aux saisies
    A.val("0");
    B.val("0");
    // puis on valide le formulaire pour faire disparaître
    // les éventuels msg d'erreur
    formulaire.validate().form();
    // puis on affecte des chaînes vides aux champs de saisie
    A.val("");
    B.val("");
}
// au chargement du document
$(document).ready(function () {
    // on récupère les références des différents composants de la page
    loading = $("#loading");
    content = $("#content");
    // on cache l'image animée
    loading.hide();
});