function sortArray() {
    //reads the array
    var array = (document.getElementById('array').value).split(', ');

    //selection sort algorithm
    for (var i = 0; i < array.length - 1; i++) {
        for (var j = i + 1; j < array.length; j++) {
            if (parseInt(array[i]) > parseInt(array[j])) // swap items
            {
                var tmp = array[i];
                array[i] = array[j];
                array[j] = tmp;
            }
        }
    }
    document.getElementById('result').innerHTML = ''; //clears the div each time, if not cleared it appends to bottom
    for (var i = 0; i < array.length; i++) {
        document.getElementById('result').innerHTML += array[i] + '<br/>';
    }
}