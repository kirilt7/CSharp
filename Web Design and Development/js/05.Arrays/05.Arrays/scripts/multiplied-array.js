function multiplyArray() {
    var array = [];

    //Output
    for (var i = 0; i < 20; i++) {
        array[i] = i * 5;
        document.getElementById('result').innerHTML += array[i] + '<br/>';
    }
}