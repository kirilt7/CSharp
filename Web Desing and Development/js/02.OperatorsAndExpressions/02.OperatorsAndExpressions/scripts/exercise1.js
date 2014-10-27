jsConsole.writeLine('Check if the value entered is odd or even!<br>');
function checkOddOrEven() {
    var inputField = parseInt(document.getElementById('inputField').value);

    if ((inputField % 2) === 1) {
        jsConsole.writeLine('The number ' + inputField + ' is odd.');
    } else {
        jsConsole.writeLine('The number ' + inputField + ' is even.');
    }
};