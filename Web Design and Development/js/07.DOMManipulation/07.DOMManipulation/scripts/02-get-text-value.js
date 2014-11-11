(function () {
    var print = document.getElementById('print');
    print.onclick = function () {
        var textBox = document.getElementById('textBox');
        console.log(textBox.value);
    }

}());