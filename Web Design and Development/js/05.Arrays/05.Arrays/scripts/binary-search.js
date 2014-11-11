function FindElement() {
    //reads the input
    var array = document.getElementById('array').value.split(', ');
    var element = document.getElementById('element').value;

    var left = 0, right = array.length;
    array.sort(function (a, b) { return a - b });
    var elementIndex = BinarySearch(array, element, left, right);

    //output
    document.getElementById('result').innerHTML = ''; //clears the div each time, if not cleared it appends to bottom
    document.getElementById('result').innerHTML = 'The index of this element is: ' + elementIndex;

}
function BinarySearch(array, value, left, right)
    {
        while (left <= right)
        {
            var middle = Math.floor((left + right) / 2);
            if (array[middle] === value)
            {
                return middle;
            }
            else if (array[middle] > value)
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }
        return -1;
    }