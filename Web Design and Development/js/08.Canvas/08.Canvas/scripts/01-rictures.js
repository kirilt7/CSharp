﻿var canvas = document.getElementById('my-canvas');

var bicycleStartPoint = {
    x: 70,
    y: 350
};
drawBicycle(bicycleStartPoint);

var headStartPoint = {
    x: 200,
    y: 150
};
drawHead(headStartPoint);

var houseStartPoint = {
    x: 400,
    y: 150
}
drawHouse(houseStartPoint);

function drawBicycle(startPoint) {
    var ctxBicycle = canvas.getContext('2d'),
        x = startPoint.x,
        y = startPoint.y;

    ctxBicycle.fillStyle = "rgb(142,200,213)";
    ctxBicycle.strokeStyle = "rgb(49,121,139)";
    ctxBicycle.lineWidth = 4;
    //left wheel
    drawCircle(ctxBicycle, x, y, 50, true);

    //right wheel
    drawCircle(ctxBicycle, x + 200, y, 50, true);

    //pedals wheel
    ctxBicycle.lineWidth = 2;
    drawCircle(ctxBicycle, x + 100, y, 15, false);

    //frame
    //left triangel
    drawLine(ctxBicycle, x, y, x + 100, y);
    drawLine(ctxBicycle, x + 100, y, x + 60, y - 80);
    drawLine(ctxBicycle, x + 60, y - 80, x, y);

    //right triangle
    drawLine(ctxBicycle, x + 60, y - 80, x + 180, y - 80);
    drawLine(ctxBicycle, x + 180, y - 80, x + 100, y);

    //front wheel holder
    drawLine(ctxBicycle, x + 180, y - 80, x + 200, y);

    //handle-bar
    drawLine(ctxBicycle, x + 180, y - 80, x + 173, y - 108);
    drawLine(ctxBicycle, x + 173, y - 108, x + 133, y - 98);
    drawLine(ctxBicycle, x + 173, y - 108, x + 183, y - 148);

    //seat
    drawLine(ctxBicycle, x + 60, y - 80, x + 45, y - 110);
    drawLine(ctxBicycle, x + 20, y - 110, x + 70, y - 110);
}

function drawHead(startPoint) {
    var ctxHead = canvas.getContext('2d'),
        x = startPoint.x,
        y = startPoint.y;

    ctxHead.fillStyle = "rgb(142,200,213)";
    ctxHead.strokeStyle = "rgb(32,81,92)";
    ctxHead.lineWidth = 2;

    //head
    drawCircle(ctxHead, x, y, 40, true);

    //left eye
    drawElipse(ctxHead, x - 25, y - 10, 10, 5, true);
    drawElipse(ctxHead, x - 28, y - 10, 1, 2, true);

    //right eye
    drawElipse(ctxHead, x + 10, y - 10, 10, 5, true);
    drawElipse(ctxHead, x + 7, y - 10, 1, 2, true);

    //nose
    ctxHead.beginPath();
    ctxHead.moveTo(x - 7, y - 10);
    ctxHead.lineTo(x - 15, y + 10);
    ctxHead.lineTo(x - 2, y + 10);
    ctxHead.stroke();

    //mouth
    drawElipse(ctxHead, x - 5, y + 25, 13, 5, true);

    ctxHead.fillStyle = "rgb(57,102,147)";
    ctxHead.strokeStyle = "black";
    drawElipse(ctxHead, x, y - 35, 50, 10, true);
    drawElipse(ctxHead, x, y - 44, 30, 6, true, 0, Math.PI);
    ctxHead.beginPath();
    ctxHead.moveTo(x - 30, y - 44);
    ctxHead.lineTo(x - 30, y - 100);
    ctxHead.lineTo(x + 30, y - 100);
    ctxHead.lineTo(x + 30, y - 44);
    ctxHead.stroke();
    ctxHead.fill();
    drawElipse(ctxHead, x, y - 100, 30, 6, true);

}

function drawHouse(startPoint) {
    var ctxHouse = canvas.getContext('2d'),
        x = startPoint.x,
        y = startPoint.y;

    ctxHouse.fillStyle = 'RGB(149,89,89)';
    ctxHouse.strokeStyle = 'black';
    ctxHouse.lineWidth = 3;

    // draw house
    ctxHouse.fillRect(x, y, 300, 250);
    ctxHouse.strokeRect(x, y, 300, 250);

    // draw roof
    ctxHouse.beginPath()
    ctxHouse.moveTo(x, y);
    ctxHouse.lineTo(x + 150, y - 130);
    ctxHouse.lineTo(x + 300, y);
    ctxHouse.fill();
    ctxHouse.stroke();

    // draw chimney
    ctxHouse.fillRect(x + 220, y - 110, 40, 80);
    drawElipse(ctxHouse, x + 240, y - 110, 20, 5, true);
    drawLine(ctxHouse, x + 220, y - 110, x + 220, y - 20);
    drawLine(ctxHouse, x + 260, y - 110, x + 260, y - 20);

    // draw windows
    drawWindow({ x: x + 30, y: y + 30 });
    drawWindow({ x: x + 165, y: y + 30 });
    drawWindow({ x: x + 165, y: y + 125 });

    // draw door
    drawElipse(ctxHouse, x + 82, y + 150, 40, 20, false, Math.PI, 2 * Math.PI);
    ctxHouse.beginPath()
    ctxHouse.moveTo(x + 42, y + 150);
    ctxHouse.lineTo(x + 42, y + 250);
    ctxHouse.moveTo(x + 122, y + 150);
    ctxHouse.lineTo(x + 122, y + 250);
    ctxHouse.moveTo(x + 82, y + 130);
    ctxHouse.lineTo(x + 82, y + 250);
    ctxHouse.stroke();
    drawCircle(ctxHouse, x + 70, y + 210, 5, false);
    drawCircle(ctxHouse, x + 94, y + 210, 5, false);

    function drawWindow(startPoint) {
        var x = startPoint.x,
            y = startPoint.y;

        ctxHouse.fillStyle = 'black';

        ctxHouse.fillRect(x, y, 50, 30);
        ctxHouse.fillRect(x + 55, y, 50, 30);
        ctxHouse.fillRect(x, y + 35, 50, 30);
        ctxHouse.fillRect(x + 55, y + 35, 50, 30);
    }
}

function drawCircle(ctx, centerX, centerY, radius, hasFill, startAngle, endAngle) {
    startAngle = (startAngle || 0);
    endAngle = (endAngle || (2 * Math.PI));

    ctx.beginPath()
    ctx.arc(centerX, centerY, radius, startAngle, endAngle)

    if (hasFill) {
        ctx.fill();
    }

    ctx.stroke();
}

function drawElipse(ctx, centerX, centerY, radiusX, radiusY, hasFill, startAngle, endAngle) {
    var axisRatio = radiusY / radiusX;
    startAngle = (startAngle || 0);
    endAngle = (endAngle || (2 * Math.PI));

    ctx.save();
    ctx.scale(1, axisRatio);
    ctx.beginPath();
    ctx.arc(centerX, centerY / axisRatio, radiusX, startAngle, endAngle);
    ctx.restore();

    if (hasFill) {
        ctx.fill();
    }

    ctx.stroke();
}

function drawLine(ctx, startX, startY, endX, endY) {
    ctx.beginPath();
    ctx.moveTo(startX, startY);
    ctx.lineTo(endX, endY);
    ctx.stroke();
}