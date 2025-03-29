// Preloader JQUERY
$("body").removeClass("preload");
$(window).on("load", function() {
    $(".loader-wrapper").fadeOut("slow");
});