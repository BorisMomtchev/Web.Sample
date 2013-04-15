var StyleCookie = {};

StyleCookie.createCookie = function(name, value, days) {
    var expires;
    if (days) {
        var date = new Date();
        date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
        expires = "; expires=" + date.toGMTString();
    } else {
        expires = "";
    }
    document.cookie = name + "=" + value + expires + "; path=/";
};

StyleCookie.readCookie = function(name) {
    var nameEq = name + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') c = c.substring(1, c.length);
        if (c.indexOf(nameEq) == 0) return c.substring(nameEq.length, c.length);
    }
    return null;
};

StyleCookie.eraseCookie = function(name) {
    StyleCookie.createCookie(name, "", -1);
};

document.addEventListener('DOMContentLoaded', function() {

    if (StyleCookie.readCookie('theme')) {
        var e = document.getElementById('bootstrap'); // <link href="..." id="test-css"/>
        e.href = StyleCookie.readCookie('theme');
    }
}, false);