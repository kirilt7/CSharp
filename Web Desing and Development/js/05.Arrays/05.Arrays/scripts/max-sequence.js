function findMaxSeq() {
    //reads the array
    var array = (document.getElementById('array').value).split(', ');

    //finds max sequence
    var maxSeq = 0;
    var maxSeqIndex;
    for (var i = 0; i < array.length - 1; i++) {
        var currSeq = 0;
        var currSeqIndex = i;
        for (var k = i+1; k < array.length; k++) {
            if (array[i] === array[k]) {
                currSeq += 1;
            } else {
                if (currSeq > maxSeq) {
                    maxSeq = currSeq;
                    maxSeqIndex = currSeqIndex;
                }
                break;
            }
        }
    }
    
    //output
    document.getElementById('result').innerHTML = ''; //clears the div each time, if not cleared it appends to bottom
    document.getElementById('result').innerHTML = '{';
    for (var i = maxSeqIndex; i < maxSeqIndex+maxSeq ; i++) {
        document.getElementById('result').innerHTML += array[i] + ', ';
    }
    document.getElementById('result').innerHTML += array[maxSeqIndex+maxSeq] + '}';
}