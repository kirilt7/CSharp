jsConsole.writeLine('Check if the third digit (right-to-left) of the given number is 7 e.g. 1732 -> true<br>');
function isThirdDigit7() {
    var inputField = parseFloat(document.getElementById('inputField').value);
    var buffer = parseInt(inputField / 100);

    if ((buffer % 10) == 7) {
        jsConsole.writeLine('The third digit of this number is 7.');
    } else {
        jsConsole.writeLine('The third digit of this number is NOT 7.');
    };
};