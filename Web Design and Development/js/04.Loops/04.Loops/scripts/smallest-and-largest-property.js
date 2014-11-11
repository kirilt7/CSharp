function findSmallestAndLargest() {
    var documentElements = [];
    for (var element in document) {
        documentElements.push(element);
    }
    documentElements.sort();

    var windowElements = [];
    for (var element in window) {
        windowElements.push(element);
    }
    windowElements.sort();

    var navigatorElements = [];
    for (var element in navigator) {
        navigatorElements.push(element);
    }
    navigatorElements.sort();

    // Output
    document.getElementById("result").innerHTML = 'Document: ' + documentElements[documentElements.length - 1] + '<br />' +
                                                  'Window: ' + windowElements[windowElements.length - 1] + '<br />' +
                                                  'Navigator: ' + navigatorElements[navigatorElements.length - 1] + '<br />';
}