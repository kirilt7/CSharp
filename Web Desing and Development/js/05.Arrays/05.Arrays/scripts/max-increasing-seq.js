function findMaxIncreasingSeq() {
    //reads the array
    var array = (document.getElementById('array').value).split(', ');

    //finds max sequence
    var maxSeq = 1, maxSeqIndex = 0, currSeq = 1, currSeqIndex = 0;
    for (var i = 1; i < array.length; i++) {
        currSeqIndex = i;
        if (parseInt(array[i]) > parseInt(array[i - 1])) {
            currSeq++;
        } else {
            currSeq = 0;
        }
        if (maxSeq < currSeq) {
            maxSeq = currSeq;
            maxSeqIndex = currSeqIndex;
        }
    }

    //output
    document.getElementById('result').innerHTML = ''; //clears the div each time, if not cleared it appends to bottom
    document.getElementById('result').innerHTML = '{';
    for (var i = maxSeqIndex - (maxSeq-1); i<maxSeqIndex; i++) {
        document.getElementById('result').innerHTML += array[i] + ', ';
    }
    document.getElementById('result').innerHTML += array[maxSeqIndex] + '}';
}