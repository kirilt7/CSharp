function reverseDigits(number) {
    number = Math.floor(number);

    var result = 0;
    while (Math.floor(number) > 0) {
        result = result * 10 + number % 10;
        number = Math.floor(number / 10);
    }
    return result;
}

function produceOutput() {
    var number = document.getElementById("number").value;
    var reversed = reverseDigits(number);
    document.getElementById("result").innerHTML = "Reversed number: " + reversed;
}