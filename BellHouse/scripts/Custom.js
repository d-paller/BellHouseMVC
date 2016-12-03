$(document).ready(function () {

    $(".menu-tab-btn").click(function () {
        window.scrollTo(0, 0);
    });

    $(window).on('scroll', function () {
        var x = $(document).scrollTop();
        x = x / 100;
        $(".backdrop").css({ "-webkit-filter": "blur(" + x + "px)", "filter": "blur(" + x + "px)" })
    })
});

