function loadView(name) {
    $.ajax({
        url: '/' + name + '/Detail/',
        type: 'GET',
        cache: false,
        data: {}
    }).done(function (result) {
        $('#view-container').html(result);
    }).fail(function (jqXHR, exception) {
        alert(jqXHR.responseText);
    });

    return false;
}