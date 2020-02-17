function postForm() {
    // on fait un appel Ajax à la main avec JQuery
    var loading = $("#loading");
    var formulaire = $("#formulaire");
    var résultats = $('#resultats');
    $.ajax({
        url: '/Premier/Action01Post',
        type: 'POST',
        data: formulaire.serialize(),
        dataType: 'html',
        begin: loading.show(),
        success: function (data) {
            loading.hide()
            résultats.html(data);
        }
    })
}