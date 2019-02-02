//Scroll to section destination
$('.scroll-to').click(function () {
    var anchor = $(this).attr("dest");
    $('.link-wrap').removeClass('visible');

    $('html, body').animate({
        scrollTop: $('#' + anchor).offset().top
    }, 400);
});


// Track nav bar position.
var navPos = $('.main-header')[0].getBoundingClientRect().top - document.body.getBoundingClientRect().top - 10;
var lastPos = 0;

$(window).on('scroll', function () {

    var pos = $(window).scrollTop();

    if (pos >= navPos && lastPos < pos) {
        $('.main-header').addClass('fixed');
        $('.main-footer').addClass('fixed');
        $('.background-image').addClass('about');
    }
    if (pos + $('.main-footer').height() < navPos && lastPos > pos) {
        $('.main-header').removeClass('fixed');
        $('.main-footer').removeClass('fixed');
        $('.background-image').remove('about');
    }
    lastPos = pos;
});
