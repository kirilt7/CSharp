(function () {
    var stage = new Kinetic.Stage({
        container: 'container',
        width: 800,
        height: 500
    });

    var layer = new Kinetic.Layer();

    var imageObj = new Image();
    imageObj.onload = function () {
        var mario = new Kinetic.Sprite({
            x: 200,
            y: 200,
            image: imageObj,
            animation: 'idle',
            animations: {
                idle: [
                    // x, y, width, height (8 frames)
                    10, 290, 75, 120,
                    85, 290, 75, 120,
                    175, 290, 75, 120,
                    255, 290, 75, 120,
                    335, 290, 75, 120,
                    405, 290, 75, 120,
                    480, 290, 75, 120,
                    570, 290, 75, 120,
                    660, 290, 75, 120,
                    745, 290, 75, 120
                ]
            },
            frameRate: 8,
            frameIndex: 0
        });

        layer.add(mario);
        stage.add(layer);

        mario.start();
    };

    imageObj.src = "./imgs/SuperMario.png";
}());