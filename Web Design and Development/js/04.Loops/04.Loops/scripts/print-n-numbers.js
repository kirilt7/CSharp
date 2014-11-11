function printNumbers() {
    document.getElementById("result").innerHTML = "";
    var number = parseInt(document.getElementById("number").value);
    if (number < 1 || isNaN(number)) {
        document.getElementById("result").innerHTML = "You must enter an integer greater than or equal to 1.";

    } else {
        // Output
        for (var i = 1; i <= number; i++) {
            document.getElementById("result").innerHTML += i + "<br />";
        }
    }
}