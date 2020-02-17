// variables globales
var loading;
var content;
function faireSimulation() {
    $.ajax({
        url: "/Pam/FaireSimulation",
        type: "Post",
    
        beforeSend: function () {
            loading.show();
        },
        success: function (data) {
            $("#simulation").html(data);
        },
         complete: function () {
            loading.hide();
        },
        error: function (jqXHR) {
            // affichage réponse serveur
            content.html(jqXHR.responseText);
        }
    })
    console.log("im in ");
}
function effacerSimulation() {
    $("#simulation").html("");

}
function enregistrerSimulation() {
    $.ajax({
        url: '/Pam/EnregistrerSimulation',
        type: 'Post',
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

}
function voirSimulations() {
    $.ajax({
        url: '/Pam/VoirSimulations',
        type: 'Post',
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

}
function retourFormulaire() {
    $.ajax({
        url: '/Pam/Formulaire',
        type: 'Post',
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

}
function terminerSession() {
    $.ajax({
        url: '/Pam/TerminerSession',
        type: 'Post',
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
}
function setMenu(show) {
// on affiche les liens du tableau [show]

}
// au chargement du document
$(document).ready(function () {
    // on récupère les références des différents composants de la page
    loading = $("#loading");
    content = $("#content");
    lnkFaireSimulation = $("#lnkFaireSimulation");
    lnkEffacerSimulation = $("#lnkEffacerSimulation");
    lnkEnregistrerSimulation = $("#lnkEnregistrerSimulation");
    lnkVoirSimulations = $("#lnkVoirSimulations");
    lnkTerminerSession = $("#lnkTerminerSession");
    lnkRetourFormulaire = $("#lnkRetourFormulaire");
    // on les met dans un tableau
    options = [lnkFaireSimulation, lnkEffacerSimulation, lnkEnregistrerSimulation,
        lnkVoirSimulations, lnkTerminerSession, lnkRetourFormulaire];
    // on cache certains éléments de la page
    loading.hide();
    // on fixe le menu
    setMenu([lnkFaireSimulation, lnkVoirSimulations, lnkTerminerSession]);
});
