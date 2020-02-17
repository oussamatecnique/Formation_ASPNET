// données globales
var entete;
var loading;
var résultats;
var erreur;
var heureCalcul;
var msg;
var AplusB;
var AmoinsB;
var AmultipliéparB;
var AdiviséparB;
var formulaire;
function postForm() {
    // on fait un appel Ajax à la main avec JQuery
    $.ajax({
        url: '/Premier/Action02Post',
        type: 'POST',
        data: formulaire.serialize(),
        dataType: 'json',
        beforeSend: OnBegin,
        success: OnSuccess,
        error: OnFailure,
        complete: OnComplete
    })
}
// au chargement du document
$(document).ready(function () {
    formulaire = $("#formulaire");
    entete = $("#entete");
    loading = $("#loading");
    erreur = $("#erreur");
    résultats = $('#résultats');
    heureCalcul = $("#heureCalcul");
    msg = $("#msg");
    AplusB = $("#AplusB");
    AmoinsB = $("#AmoinsB");
    AmultipliéparB = $("#AmultipliéparB");
    AdiviséparB = $("#AdiviséparB");
    // on cache certains éléments de la page
    entete.hide();
    résultats.hide();
    erreur.hide();
});
// démarrage
function OnBegin() {
    // signal d'attente allumé
    loading.show();
    // on cache certains éléments de la page
    entete.hide();
    résultats.hide();
    erreur.hide();  
}
// fin de la requête
function OnComplete() {
    // signal d'attente éteint
    loading.hide();
}
// réussite
function OnSuccess(data) {
    // affichage résultats
    heureCalcul.text(data.HeureCalcul);
    entete.show();
    if (data.Erreur != '') {
        msg.text(data.Erreur);
        erreur.show();
        return;
    }
    // pas d'erreur
    AplusB.text(data.AplusB);
    AmoinsB.text(data.AmoinsB);
    AmultipliéparB.text(data.AmultipliéparB);
    AdiviséparB.text(data.AdiviséparB);
    résultats.show();
}
// erreur
function OnFailure(request, error) {
    alert("L'erreur suivante s'est produite :" + error);
}