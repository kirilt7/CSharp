jsConsole.writeLine('Write a script that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements<br>');

function task2() {
    var first = parseFloat(document.getElementById('first').value);
    var second = parseFloat(document.getElementById('second').value);
    var third = parseFloat(document.getElementById('third').value);
    var negativeNum = 0;
    var sign = '+';

    if (first < 0) {
        negativeNum++;
    }
    if (second < 0) {
        negativeNum++;
    }
    if (third < 0) {
        negativeNum++;
    };

    if (!(negativeNum % 2 == 0)) {
        sign = '-';
    };

    jsConsole.writeLine('The sign of the product of these three numbers is ' + "'" + sign + "'");
};