(function () {
    "use strict";

    $('#Logo').click(function () {
        window.location.replace("/");
    });

    $('.WorkImg').hover(function () {
        $('.ImgOverlay').fadeIn();
    });

    // Sets height of absolute positined divs
    $('.SingleClient').first().addClass('active');
    $('.ClientLogo').first().addClass('active');

    var ClientHeight = $('.SingleClient.active').outerHeight(true);
    $('.ClientCarousel').height(ClientHeight);

    $('.ClientLogo').click(function () {
        var $this = $(this),
            $siblings = $this.parent().children(),
            position = $siblings.index($this);

        $('.SingleClient').removeClass('active').eq(position).addClass('active');
        $siblings.removeClass('active');
        $this.addClass('active');
    });
})();