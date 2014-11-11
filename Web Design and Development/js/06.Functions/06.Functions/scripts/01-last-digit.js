function printName() {
    var lastDigit = parseInt(document.getElementById("number").value % 10);

    switch (lastDigit) {
        case 0: document.getElementById("result").innerHTML = "Zero"; break;
        case 1: document.getElementById("result").innerHTML = "One"; break;
        case 2: document.getElementById("result").innerHTML = "Two"; break;
        case 3: document.getElementById("result").innerHTML = "Three"; break;
        case 4: document.getElementById("result").innerHTML = "Four"; break;
        case 5: document.getElementById("result").innerHTML = "Five"; break;
        case 6: document.getElementById("result").innerHTML = "Six"; break;
        case 7: document.getElementById("result").innerHTML = "Seven"; break;
        case 8: document.getElementById("result").innerHTML = "Eight"; break;
        case 9: document.getElementById("result").innerHTML = "Nine"; break;
        default: document.getElementById("result").innerHTML = "Please enter a valid number"; break;
    }
}