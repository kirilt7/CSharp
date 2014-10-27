jsConsole.writeLine('Check if the number entered is prime!<br>');
function isPrimeNumber() {
    var inputField = parseInt(document.getElementById('inputField').value);

    // Check if the value is negative
    if (inputField < 0) {
        jsConsole.writeLine('Please provide a positive number!');

    } else  {
        var isPrime = true;
        for (var i = 2; i < inputField; i++) {
            if ((inputField % i) == 0) {
                isPrime = false;
            };
        };
        if (isPrime) {
            jsConsole.writeLine('Prime number!');
        } else {
            jsConsole.writeLine('NOT a prime number!');
        }
    };
}