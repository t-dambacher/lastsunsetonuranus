function loadView(name) {
    $.ajax({
        url: '/' + name + '/Default/',
        type: 'GET',
        cache: true,
        data: {}
    }).done(function (result) {
        $('#view-container').html(result);
        addToHistory(name);
    }).fail(function (jqXHR, exception) {
        alert(jqXHR.responseText);
    });

    return false;
}

function addToHistory(name) {
    var stateObj = { foo: name };
    history.pushState(stateObj, name, "/" + name);
}