function FindMostFrequent() {
    //reads the array
    var array = (document.getElementById('array').value).split(', ');

    var mostFreqNumber = 1;
    var mostFreqNumberIndex;
    for (var i = 0; i < array.length - 1; i++) {
        var currFreq = 1;
        var currFreqIndex = i;
        for (var k = i + 1; k < array.length; k++) {
            if (array[i] === array[k]) {
                currFreq += 1;
            } 
        }
        if (currFreq>mostFreqNumber) {
            mostFreqNumber = currFreq;
            mostFreqNumberIndex = i;
        }
    }
    document.getElementById('result').innerHTML = ''; //clears the div each time, if not cleared it appends to bottom

    document.getElementById('result').innerHTML = array[mostFreqNumberIndex] + ' (' + mostFreqNumber + ' times)';
}