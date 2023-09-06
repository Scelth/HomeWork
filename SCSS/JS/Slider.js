
  $(".middle-slider .slides").slick({
    dots: true,
    arrows: true,
    infinite: true,
    loop: true,
    speed: 1000,
    autoplay: false,
    focusOnSelect: true,
    autoplaySpeed: 3000,
    centerMode: true,
    slidesToShow: 3,
    slidesToScroll: 1,
    asNavFor:
      ".top-slider .slides, .bottom-slider .slides, .three-slide-slider .slides",
    responsive: [
      {
        breakpoint: 1450,
        settings: {
          slidesToShow: 1
        }
      }
    ]
  });
  $(".bottom-slider .slides").slick({
    fade: true,
    dots: false,
    arrows: false,
    infinite: true,
    loop: true,
    speed: 1000,
    autoplay: false,
    focusOnSelect: true,
    autoplaySpeed: 3000,
    slidesToShow: 1,
    slidesToScroll: 1,
    asNavFor:
      ".top-slider .slides, .middle-slider .slides, .three-slide-slider .slides"
  });