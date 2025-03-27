$('.slick_slide').slick({
    slidesToShow: 4,
    slidesToScroll: 1,
    autoplay: true,
    speed: 800,
    prevArrow: '<button class="left_arrow"><i class="fa-solid fa-angle-left"></i></button>',
    nextArrow: '<button class="right_arrow"><i class="fa-solid fa-angle-right"></i></button>',
    autoplaySpeed: 2000,
    responsive: [
        {
            breakpoint: 1400,
            settings: {
                slidesToShow: 3,
                slidesToScroll: 1
            }
        },
        {
            breakpoint: 992,
            settings: {
                slidesToShow: 2,
                slidesToScroll: 1,
                centerMode: true,
                centerPadding: '25px'
            }
        },
        {
            breakpoint: 768,
            settings: {
                slidesToShow: 1,
                slidesToScroll: 1,
                centerMode: true,
                centerPadding: '70px'
            }
        },
        {
            breakpoint: 460,
            settings: {
              slidesToShow: 1,
              slidesToScroll: 1, 
              variableWidth: false
            }
        }
    ]
});