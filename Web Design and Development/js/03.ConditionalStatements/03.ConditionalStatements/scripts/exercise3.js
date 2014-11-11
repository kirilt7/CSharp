jsConsole.writeLine('Write a script that finds the biggest of three integers using nested if statements.<br>');

function task3() {
    var first = parseFloat(document.getElementById('first').value);
    var second = parseFloat(document.getElementById('second').value);
    var third = parseFloat(document.getElementById('third').value);
    var biggest;

    if (first > second) {
        biggest = first;
        if (first < third) {
            biggest = third;
        };
    } else {
        biggest = second;
        if (second < third) {
            biggest = third;
        };
    };

    jsConsole.writeLine('The biggest number is: ' + biggest);
};