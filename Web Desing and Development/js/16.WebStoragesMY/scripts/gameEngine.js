var gameEngine = (function () {
    var userInput = document.createElement('input');
    userInput.type = 'text';

    var guessButton = document.createElement('button');
    var text = document.createTextNode("Try to guess!");
    guessButton.appendChild(text);

    function initializeGame(randomNumber) {

        document.getElementById('wrapper').innerHTML = '';
        var $container = $('#wrapper');
        $container.append('<h1> The computer generated a four-digit non repeating number for you. Try to guess it!</h1>');

        $container.append(userInput);
        $container.append(guessButton);

        var numberOfGuesses = 0;
        guessButton.onclick = function () {
            if (userInput.value && userInput.value > 1000 && userInput.value < 9999) {
                numberOfGuesses++;

                var bulls = 0;
                var cows = 0;
                for (var i = 0; i < randomNumber.length; i++) {
                    if (parseInt(userInput.value[i]) === randomNumber[i]) {
                        bulls++;
                    } else {
                        for (var j = 0; j < randomNumber.length; j++) {
                            if (parseInt(userInput.value[i]) === randomNumber[j]) {
                                cows++;
                            }
                        }
                    }
                }
                if (bulls === 4) {
                    $container.append('<div>Congratulations! You guess the number with ' + numberOfGuesses + ' guesses</div>');
                    $container.append('<div>Please enter nickname for the high score:</div>');

                    var nickname = document.createElement('input');
                    nickname.type = 'text';
                    nickname.className = 'nickname'

                    var nicknameSubmit = document.createElement('button');
                    var text = document.createTextNode("Submit nickname!");
                    nicknameSubmit.appendChild(text);
                    nicknameSubmit.className = 'nicknameSubmit'

                    $container.append(nickname);
                    $container.append(nicknameSubmit);

                    $('.nicknameSubmit').click (function () {
                        if(nickname.value){
                            var playerRecord = {
                                nickname: nickname.value,
                                score: numberOfGuesses
                            }
                            scoresArray.push(playerRecord);
                            localStorage.setObject(keyForScores, scoresArray);

                            $(this).remove();
                        }
                    })

                } else {
                    console.log(randomNumber);
                    $container.append('<div>Bulls: ' + bulls + ', Cows: ' + cows + '</div>');
                }
            } else {
                $container.append('<div>You must enter a four-digit non repeating number!</div>');
            }
        }
    }


    return {
        initializeGame: initializeGame
    }
}());
