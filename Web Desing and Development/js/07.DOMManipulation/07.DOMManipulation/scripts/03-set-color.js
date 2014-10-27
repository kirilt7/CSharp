(function () {
    var setColor = document.getElementById('setColor');
    setColor.onclick = function () {
        var color = document.getElementById('color').value;
        document.body.style.background = color;
    }

}());