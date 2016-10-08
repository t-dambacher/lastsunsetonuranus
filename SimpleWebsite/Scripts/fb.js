window.fbAsyncInit = function () {
    FB.init({
        appId: '1183064048418597',
        xfbml: true,
        version: 'v2.8'
    });
};

function onload() {
}

var TIMEOUT = null;
$(window).on('resize', function () {
    if (TIMEOUT === null) {
        TIMEOUT = window.setTimeout(function () {
            alert('yo');
            TIMEOUT = null;
            //fb_iframe_widget class is added after first FB.FXBML.parse()
            //fb_iframe_widget_fluid is added in same situation, but only for mobile devices (tablets, phones)
            //By removing those classes FB.XFBML.parse() will reset the plugin widths.
            $('.fb-page').removeClass('fb_iframe_widget fb_iframe_widget_fluid');
            FB.XFBML.parse();
        }, 300);
    }
});

(function (d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id)) { return; }
    js = d.createElement(s); js.id = id;
    js.src = "//connect.facebook.net/fr_FR/sdk.js";
    fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));
