var keyForScores = 'scores';
var scoresArray = [];

window.onload = (function () {
    function getRandomNumber() {
        var NUMBER_SIZE = 4;
        var digits = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
        digits.sort(function () {
            return Math.random() - 0.5;
        });

        if (digits[3] !== 0) {
            digits = digits.slice(3, NUMBER_SIZE+3);
        } else {
            digits = digits.slice(4, NUMBER_SIZE + 4);
        }
        return digits;
    }

    if(localStorage.getItem(keyForScores)) {
        scoresArray = localStorage.getObject(keyForScores);
    }
    $('#start').on('click', function () {
        var randomNumber = getRandomNumber();
        gameEngine.initializeGame(randomNumber);
    })

    $('#highScore').on('click', function () {
        document.getElementById('wrapper').innerHTML = '';
        $container = $('#wrapper');
        $container.append('<h1>High Scores:</h1>');
        var scores = localStorage.getObject(keyForScores);
        if(scores.length) {
            if(scores.length > 1){
                scores.sort(function (first, second) {
                    return first.score - second.score;
                })
                for (var i = 0; i < scores.length; i++) {
                    $container.append('<div>' + (i+1) + '. ' + scores[i].nickname + ', score: ' + scores[i].score + '</div>');
                }
            } else {
                $container.append('<div>' + 1 + '. ' + scores[0].nickname + ', score: ' + scores[0].score + '</div>');
            }
        } else {
            $container.append('<div>There is not any high scores.</div>');
        }

    })
}());