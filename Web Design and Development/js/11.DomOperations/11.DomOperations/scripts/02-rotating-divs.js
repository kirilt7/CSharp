window.onload = function () {
    var divs = document.getElementsByTagName('div');

    var r = 300;
    angleOfRotation = 0;
    function rotate() {
        for (i = 0; i < divs.length; i++) {
            var angleOfDiv = angleOfRotation + (i * 2 * Math.PI / divs.length);

            divs[i].style.top = r + (Math.sin(angleOfDiv) * r) + 'px';
            divs[i].style.left = r + (Math.cos(angleOfDiv) * r) + 'px';
        }

        angleOfRotation +=0.02;

        setTimeout(rotate, 100);
    }
    rotate();
}