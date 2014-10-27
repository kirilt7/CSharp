jsConsole.writeLine('Calculate trapezoid\'s area');
function calcTrapezoid() {
    var aSide = parseInt(document.getElementById('aSide').value);
    var bSide = parseInt(document.getElementById('bSide').value);
    var height = parseInt(document.getElementById('height').value);
    var area = ((aSide + bSide) * height) / 2;

    jsConsole.writeLine('The rectangle’s area is: ' + area);
};