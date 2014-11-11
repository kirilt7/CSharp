(function () {
    var $slide = $('.slider-child');
    var i = 0;
    $('.left').on('click', function () {
        i -= 1;
        if (i < 0) {
            i = $slide.length-1;
        }
        $slide.get(i).addClass('current');
    });
    //setTimeout(function () {
    //    var i = 0;
    //    $slides.get(i % ($slides.length)).show();
    //}, 1000);

}())
