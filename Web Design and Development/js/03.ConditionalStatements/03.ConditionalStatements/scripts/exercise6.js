jsConsole.writeLine('Write a script that enters the coefficients a, b and c of a quadratic equation <br><br><center>a*x^2 + b*x + c = 0</center><br> and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.<br><br>');

function task6() {
    var first = jsConsole.readInteger('#first');
    var second = jsConsole.readInteger('#second');
    var third = jsConsole.readInteger('#third');
    var discr = second * second - 4 * first * third; // Discriminant
    var result;
    console.log(discr);
    if (discr < 0) {
        jsConsole.writeLine('There no real roots!');

    } else if (discr > 0) {
        result = [];
        result[0] = (-second + Math.sqrt(discr)) / (2 * first);
        result[1] = (-second - Math.sqrt(discr)) / (2 * first);

        jsConsole.writeLine('There are 2 real roots and they are:<br>first-root(+) = ' + result[0] + '<br>second-root(-) = ' + result[1] + '<br>');

    } else {
        result = -second / 2 * first;

        jsConsole.writeLine('There is 1 real root and he is: root = ' + result + '<br>');

    };

};