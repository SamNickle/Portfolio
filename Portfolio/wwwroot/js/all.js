!function(){"use strict";$("#Logo").click(function(){window.location.replace("/")}),$(".WorkImg").hover(function(){$(".ImgOverlay").fadeIn()}),$(".SingleClient").first().addClass("active"),$(".ClientLogo").first().addClass("active");var e=$(".SingleClient.active").outerHeight(!0);$(".ClientCarousel").height(e),$(".ClientLogo").click(function(){var e=$(this),i=e.parent().children(),t=i.index(e);$(".SingleClient").removeClass("active").eq(t).addClass("active"),i.removeClass("active"),e.addClass("active")})}();