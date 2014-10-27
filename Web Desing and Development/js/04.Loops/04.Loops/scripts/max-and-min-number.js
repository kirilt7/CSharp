var numbersArr = [];
function AddNumber() {
    var number = parseInt(document.getElementById('number').value);
    if (!isNaN(number)) {
        numbersArr.push(number);
    }
}
function printMaxAndMin() {
    // Clear the div each time (if not cleared, the new result appends to the bottom)
    document.getElementById('result').innerHTML = '';

    numbersArr.sort();
    document.getElementById('result').innerHTML = 'Min is ' + numbersArr[0] + '<br />' +
                                                  'Max is ' + numbersArr[numbersArr.length - 1] + '<br />';
}