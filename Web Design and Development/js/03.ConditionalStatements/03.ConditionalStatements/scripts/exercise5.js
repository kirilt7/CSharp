jsConsole.writeLine('Check the digit\'s name! Please enter digits from 0 - 9<br>');

function task5() {
    var digit = jsConsole.readInteger('#first');
    var name;

    switch (digit) {
        case 0:
            name = "Zero";
            break;

        case 1:
            name = "One";
            break;

        case 2:
            name = "Two";
            break;

        case 3:
            name = "Three";
            break;

        case 4:
            name = "Four";
            break;

        case 5:
            name = "Five";
            break;

        case 6:
            name = "Six";
            break;

        case 7:
            name = "Seven";
            break;

        case 8:
            name = "Eight";
            break;

        case 9:
            name = "Nine";
            break;

        default:
            name = "Enter a valid digit";
            break;
    };

    jsConsole.writeLine('The digit\'s name is: ' + name);

};