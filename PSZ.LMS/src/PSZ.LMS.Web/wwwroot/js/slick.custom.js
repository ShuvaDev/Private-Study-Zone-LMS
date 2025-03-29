$('.slick_slide').slick({
    slidesToShow: 4,
    slidesToScroll: 1,
    autoplay: true,
    speed: 800,
    variableWidth: false,
    infinite: true,
    prevArrow: '<button class="left_arrow"><i class="fa-solid fa-angle-left"></i></button>',
    nextArrow: '<button class="right_arrow"><i class="fa-solid fa-angle-right"></i></button>',
    autoplaySpeed: 2000,
    responsive: [
        {
            breakpoint: 1400,
            settings: {
                slidesToShow: 3
            }
        },
        {
            breakpoint: 992,
            settings: {
                slidesToShow: 2
            }
        },
        {
            breakpoint: 768,
            settings: {
                slidesToShow: 1
            }
        }
    ]
});