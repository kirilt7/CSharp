jsConsole.writeLine('Check if the value entered can be divided by 7 and 5 at the same time without remainder!<br>');
function dividedBy7And5() {
    var inputField = parseInt(document.getElementById('inputField').value);

    if (((inputField % 5) == 0) && ((inputField % 7) == 0)) {
        jsConsole.writeLine('True!');
    } else {
        jsConsole.writeLine('False!');
    };
};