jsConsole.writeLine('Write a script that finds the greatest of given 5 variables.<br>');

function task7() {
    var first = jsConsole.readInteger('#first');
    var second = jsConsole.readInteger('#second');
    var third = jsConsole.readInteger('#third');
    var fourth = jsConsole.readInteger('#fourth');
    var fifth = jsConsole.readInteger('#fifth');
    var num = [first, second, third, fourth, fifth];
    var biggest = num[0];

    if (isNaN(num[0]) || isNaN(num[1]) || isNaN(num[2]) || isNaN(num[3]) || isNaN(num[4])) {
        jsConsole.writeLine('Please insert a integer into the input fields.');
    };

    for (var i = 0; i < num.length; i++) {
        if (biggest < num[i]) {
            biggest = num[i];
        };
    };

    jsConsole.writeLine('The biggest number is: ' + biggest);

};