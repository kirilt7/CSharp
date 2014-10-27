jsConsole.writeLine('Calculate rectangle\'s area<br>');
function calcRectArea() {
    var width = parseInt(document.getElementById('width').value);
    var height = parseInt(document.getElementById('height').value);

    jsConsole.writeLine('The rectangle’s area is: ' + (width * height));
};