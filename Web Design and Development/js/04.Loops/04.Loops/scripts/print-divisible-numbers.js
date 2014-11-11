function printDivisibleNumbers() {
    document.getElementById("result").innerHTML = "";
    var maxNumber = parseInt(document.getElementById("number").value);
    if (maxNumber < 1 || isNaN(maxNumber)) {
        document.getElementById("result").innerHTML = "You must enter an integer greater than or equal to 1.";

    } else {
        // Output
        for (var i = 1; i <= maxNumber; i++) {
            if (i % 21 !== 0) {
                document.getElementById("result").innerHTML += i + "<br />";
            }      
        }
    }
}