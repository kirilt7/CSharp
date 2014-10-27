jsConsole.writeLine('Check if the third bit of the number is equal to 1!<br>');
function isThirdBit1() {
    var inputField = parseInt(document.getElementById('inputField').value);
    var mask = 1 << 3; // 1000 (binary value) the 3rd bit is @ the 4th position
    var equals = inputField & mask; // checks if the 3th bit is equal to 1
    var result = equals >> 3; // moving 3 bits to the right

    if (result.toString(2) == 1) {
        jsConsole.writeLine('The third bit of the number is equal to 1.');
    } else {
        jsConsole.writeLine('Try another one!');
    };
};