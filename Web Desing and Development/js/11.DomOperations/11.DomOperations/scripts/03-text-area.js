window.onload = function () {

    btnTxtColor = document.getElementById('setTextColor');
    btnTxtColor.onclick = function changeTextFontColor() {
        document.getElementsByTagName('textarea')[0].style.color = document.getElementById('colorText').value;
    };

    btnBackgroundColor = document.getElementById('setBackgroundColor');
    btnBackgroundColor.onclick = function changeBackgroundColor() {
        document.getElementsByTagName('textarea')[0].style.backgroundColor = document.getElementById('colorBackground').value;
    };

}