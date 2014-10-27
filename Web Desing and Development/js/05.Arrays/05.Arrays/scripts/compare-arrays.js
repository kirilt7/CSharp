function compareArrays() {
    var firstArray = document.getElementById("firstArray").value.split(", ");
    var secondArray = document.getElementById("secondArray").value.split(", ");

    // Compare the arrays 
    if (firstArray.length !== secondArray.length) {
        document.getElementById("result").innerHTML = "The arrays are not equal.";
    }

    // If the lengths are equal, compare each character
    else {
        var areEqual = true;
        for (var i = 0; i < firstArray.length; i++) {
            if (firstArray[i] !== secondArray[i]) {
                areEqual = false;
                break;
            }
        }
        if (areEqual) {
            document.getElementById("result").innerHTML = "The arrays are equal.";
        }
        else {
            document.getElementById("result").innerHTML = "The arrays are not equal.";
        }
    }
}