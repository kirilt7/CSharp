jsConsole.writeLine('Check if the given print(X, Y) are within a circle K(0, 5)<br>');
function isWithinCircle() {
    var xValue = parseInt(document.getElementById('xValue').value);
    var yValue = parseInt(document.getElementById('yValue').value);
    var radius = 5;

    /* Using the Pythagorean theorem (a^2) + (b^2) = (c^2) to check if the point(X, Y) is in the circle */
    if ((xValue * xValue) + (yValue * yValue) <= (radius * radius)) {
        jsConsole.writeLine('The print(' + xValue + ', ' + yValue + ') is In the circle K(0, 5)');
    } else {
        jsConsole.writeLine('The print(' + xValue + ', ' + yValue + ') is OUTSIDE the circle K(0, 5)')
    };
};