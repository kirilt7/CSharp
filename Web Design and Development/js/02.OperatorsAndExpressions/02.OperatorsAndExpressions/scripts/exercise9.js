jsConsole.writeLine('Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2) <br>');
function isWithinCircle() {
    var x = parseInt(document.getElementById('xValue').value);
    var y = parseInt(document.getElementById('yValue').value);

    // Circle values
    var Cx = 1; // Center of the circle by X coordinate
    var Cy = 1; // Center of the circle by Y coordinate
    var Cr = 3; // radius of the circle

    // Rectangle values
    var Rt = 1;  		// top (+y)
    var Rl = -1; 		// left (-x)
    var Rw = 6;  		// width
    var Rh = 2;  		// height
    var Rb = Rt - Rh;   // bottom (-y)
    var Rr = Rl + Rw;   // right (+x)

    if (Math.pow((x - Cx), 2) + Math.pow((y - Cy), 2) <= Math.pow((Cr), 2)) {
        // IN the circle
        jsConsole.writeLine('The point(' + x + ',' + y + ') is IN the circle K((' + Cx + ',' + Cy + '),' + Cr + ')');

        if (((x > Rl) && (x < Rr)) && ((y < Rt) && (y > Rb))) {
            // IN the circle and IN the rectangle
            jsConsole.writeLine('And IN the rectangle R(top=' + Rt + ', left=' + Rl + ', width=' + Rw + ', height=' + Rh + ')');

        } else {
            // IN the circle and OUTSIDE the rectangle
            jsConsole.writeLine('And OUT of the rectangle R(top=' + Rt + ', left=' + Rl + ', width=' + Rw + ', height=' + Rh + ')');
        };

    } else {
        //OUTSIDE the circle
        jsConsole.writeLine('The point(' + x + ',' + y + ') is OUT of the circle K((' + Cx + ',' + Cy + '),' + Cr + ')');

        if (((x > Rl) && (x < Rr)) && ((y < Rt) && (y > Rb))) {
            // OUTSIDE the circle and IN the rectangle
            jsConsole.writeLine('And IN the rectangle R(top=' + Rt + ', left=' + Rl + ', width=' + Rw + ', height=' + Rh + ')');

        } else {
            // OUTSIDE the circle and OUTSIDE the rectangle
            jsConsole.writeLine('And OUT of the rectangle R(top=' + Rt + ', left=' + Rl + ', width=' + Rw + ', height=' + Rh + ')');
        };
    };

};