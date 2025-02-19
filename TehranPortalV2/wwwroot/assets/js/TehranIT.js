NavbarActive(NavbarState($(window).width()));
function NavbarState(x) {
    if (x > 991.98) {
        return 1;
    } else if (x < 991.98 && x > 768) {
        return 2;
    } else {
        return 3;
    }
}
function NavbarActive(x) {
    if (x == 1) {
        $('#sidebar').removeClass('half-sidebar close-sidebar open-sidebar');
    } else if (x == 2) {
        $('#sidebar').addClass('half-sidebar');
        $('#sidebar').removeClass('close-sidebar open-sidebar');
    } else if (x == 3) {
        $('#sidebar').addClass('close-sidebar');
        $('#sidebar').removeClass('half-sidebar');
    }
}
$(window).on('resize', function () {
    state = NavbarState($(window).width());
    NavbarActive(state);
});




$(".tehranit-nav-btn").on("click", function () {
    state = NavbarState($(window).width());
    if (state == 1) {
        $("#sidebar").toggleClass("half-sidebar");
    } else if (state == 2) {
        $("#sidebar").toggleClass("half-sidebar");
    } else {
        $("#sidebar").toggleClass("open-sidebar");
    }
});
$(".navbar-btn-close").on("click", function () {
    $("#sidebar").toggleClass("open-sidebar", 1000, "easeOutSine");
});

$(".sub-menu ul").hide();
$(".sub-menu a").on("click", function () {
    $(this).parent(".sub-menu").children("ul").slideToggle("100");
    $(this).find(".sub-menu-icon").toggleClass("bi bi-chevron-up");

});





/*Cookie*/
function setCookie(key, value, expiry) {
    var expires = new Date();
    expires.setTime(expires.getTime() + (expiry * 24 * 60 * 60 * 1000));
    document.cookie = key + '=' + value + ';expires=' + expires.toUTCString();
}

function getCookie(key) {
    var keyValue = document.cookie.match('(^|;) ?' + key + '=([^;]*)(;|$)');
    return keyValue ? keyValue[2] : null;
}

function eraseCookie(key) {
    var keyValue = getCookie(key);
    setCookie(key, keyValue, '-1');
}

function checkCookie() {
     $("body").removeClass();
    if (!getCookie('darkMode')) {
        setCookie('darkMode', 'light', '50');
    } else {
        $("body").addClass(getCookie('darkMode'));
    }
    if (getCookie('darkMode') == "dark") {
        $('#switch-darkMode').attr('checked', 'checked');
    } else {
        $('#switch-darkMode').removeAttr('checked');
    }

    if (!getCookie('themeColor')) {
        setCookie('themeColor', 'blue', '50');
    } else {
        $("body").addClass(getCookie('themeColor'));
    }
    if ($('body').attr('class') == "") {
        $("body").addClass('light blue');
    }
}

checkCookie();

function get_theme(themeColor, darkMode) {
    eraseCookie('themeColor');
    eraseCookie('darkMode');

    setCookie('themeColor',themeColor , '50');
    setCookie('darkMode', darkMode, '50');
    themToast();
    checkCookie();
}

$('#switch-darkMode').on('change', function () {
    console.log($(this).is(':checked'));
    if ($(this).is(':checked')==true) {
        eraseCookie('darkMode');
        setCookie('darkMode', 'dark', '50');
    } else if ($(this).is(':checked') == false) {
        eraseCookie('darkMode');
        setCookie('darkMode', 'light', '50');
    }
    themToast();
    checkCookie();
});


function themToast() {
    var myAlert = document.getElementById('themToast');
    var bsAlert = new bootstrap.Toast(myAlert, { 'autohide': true, 'delay': 4000 });
    bsAlert.show();
}


$('.js-preloader').preloadinator({
    minTime: 100,
    animation: 'fadeOut'
});

(function () {
    var originalAddClassMethod = jQuery.fn.addClass;
    var originalRemoveClassMethod = jQuery.fn.removeClass;
    jQuery.fn.addClass = function () {
        var result = originalAddClassMethod.apply(this, arguments);
        jQuery(this).trigger('classChanged');
        return result;
    }
    jQuery.fn.removeClass = function () {
        var result = originalRemoveClassMethod.apply(this, arguments);
        jQuery(this).trigger('classChanged');
        return result;
    }
})();

function MyTiny() {
    if ($(".dark")[0]) {
        x = "#f7f7f7";
    }
    if ($(".light")[0]) {
        x = "#455a64";
    }
    tinymce.init({
        selector: 'textarea#tiny',
        language: 'fa',
        directionality: 'Rtl',
        content_style: '.mce-content-body{color:' + x + '}',
        plugins: 'code',
        toolbar: "undo redo | blocks fontsize | bold italic underline forecolor backcolor | link image | alignleft aligncenter alignright alignjustify | code"
    });
}

function checkRadioPassword() {
    if ($('#password-radio').is(':checked')) {
        $('#PassPublish').show('fast');
    } else {
        $('#PassPublish').hide('fast');
    }
}
