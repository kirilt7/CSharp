window.onload = function () {
    btn = document.getElementById('generate-button');
    btn.addEventListener('click', generateDivs);
    contentDiv = document.getElementById('content-div');
    function generateDivs() {

        while (contentDiv.firstChild) {
            contentDiv.removeChild(contentDiv.firstChild);
        }

        var count = Math.floor(Math.random() * 20 + 1);

        for (var i = 0; i < count; i++) {
            var randomDiv = document.createElement("div");
            randomDiv.classList.add("colored");
            makeDivsRandomParams(randomDiv);
            contentDiv.appendChild(randomDiv).appendChild(createStrong('div'));
        }

        return false;
    }

    function generateRandomColor() {
        var red = (Math.random() * 256) | 0;
        var green = (Math.random() * 256) | 0;
        var blue = (Math.random() * 256) | 0;

        return "rgb(" + red + "," + green + "," + blue + ")";
    }

    function makeDivsRandomParams(randomDiv) {

        randomDiv.style.position = "absolute";

        // position top left
        var topPos = parseInt(Math.random() * 600);
        randomDiv.style.top = topPos + "px";
        var left = parseInt(Math.random() * 1200);
        randomDiv.style.left = left + "px";

        // width and heigth
        var width = parseInt(Math.random() * (100 - 20) + 20);
        randomDiv.style.width = width + "px";
        var height = parseInt(Math.random() * (100 - 20) + 20);
        randomDiv.style.height = height + "px";

        // text and background style
        randomDiv.style.backgroundColor = generateRandomColor();
        randomDiv.style.color = generateRandomColor();
        randomDiv.style.textAlign = "center";

        // border style
        randomDiv.style.borderWidth = parseInt(Math.random() * (20 - 1) + 1) + "px";
        randomDiv.style.borderRadius = parseInt(Math.random() * 50) + "%";
        randomDiv.style.borderColor = generateRandomColor();
    }

    // create strong text inside the div
    function createStrong(text) {
        var result = document.createElement('strong');
        result.appendChild(document.createTextNode(text));

        return result;
    }
}