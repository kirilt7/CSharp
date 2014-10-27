jsConsole.writeLine('Sort 3 real values in descending order using nested if statements.<br>');

function task3() {
    var first = parseFloat(document.getElementById('first').value);
    var second = parseFloat(document.getElementById('second').value);
    var third = parseFloat(document.getElementById('third').value);
    var order;

    if ((first > second) && (first > third)) {
        order = first + ' ';
        if (second >= third) {
            order += second + ' ' + third;
        } else {
            order += third + ' ' + second;
        };
    };

    if ((second > first) && (second > third)) {
        order = second + ' ';
        if (first >= third) {
            order += first + ' ' + third;
        } else {
            order += third + ' ' + first;
        };
    };

    if ((third > second) && (third > first)) {
        order = third + ' ';
        if (first >= second) {
            order += first + ' ' + second;
        } else {
            order += second + ' ' + first;
        };
    };

    if ((first == second) && (first == third)) {
        order = first + ' ' + second + ' ' + third;
    };

    jsConsole.writeLine('The descending order of the numbers is: ' + order);
};