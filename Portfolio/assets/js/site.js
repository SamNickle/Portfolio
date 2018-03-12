(function () {
    "use strict";

    // Makes first class of it's kind in an active state
    $('.SingleClient').first().addClass('active');
    $('.ClientLogo').first().addClass('active');

    // Creates reuseable function that sets the height of absolutely positioned elements
    function ClientQuoteHeight() {
        var ClientHeight = $('.SingleClient.active').outerHeight(true);
        $('.ClientCarousel').height(ClientHeight);
    }

    // Sets height of absolutely positioned elements on load and on screen resize
    ClientQuoteHeight();
    $(window).resize(function () {
        ClientQuoteHeight();
    });

    // Gives the clicked client a state of active and removes active state from other elements
    $('.ClientLogo').click(function () {
        var $this = $(this),
            $siblings = $this.parent().children(),
            position = $siblings.index($this);

        $('.SingleClient').removeClass('active').eq(position).addClass('active');
        $siblings.removeClass('active');
        $this.addClass('active');
        ClientQuoteHeight();
    });

    $("a").on('click', function (event) {

        if (this.hash !== "") {
            event.preventDefault();

            var hash = this.hash;

            $('html, body').animate({
                scrollTop: $(hash).offset().top
            }, 800, function () {
                window.location.hash = hash;
            });
        }
    });
})();