jsConsole.writeLine('Check wich of the entered numbers is bigger!<br>');
function task1() {
    var first = parseInt(document.getElementById('first').value);
    var second = parseInt(document.getElementById('second').value);
    var name = document.getElementsByTagName('label');
    //innerText for IE, innerContent for other browsers
    var label = name[1].innerText || name[1].innerContent;

    if (first > second) {
        second = first;
        label = name[0].innerText || name[0].innerContent;;
    };

    jsConsole.writeLine('The bigger number is the ' + label + ' : ' + second);

};