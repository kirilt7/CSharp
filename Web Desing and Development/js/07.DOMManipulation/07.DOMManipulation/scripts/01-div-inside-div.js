(function () {
    var divsInsideDiv = document.querySelectorAll('div>div');
    for (var i = 0; i < divsInsideDiv.length; i++) {
        divsInsideDiv[i].innerText = 'b';
    }

}());

//with getElementsByTagName()
//(function () {
//    var allDivs = document.getElementsByTagName('div');
//    for (var i = 0; i < allDivs.length; i++) {
//        if (allDivs[i].parentElement.nodeName === 'DIV') {
//            allDivs[i].innerText = 'b';
//        }
//    }
//}());