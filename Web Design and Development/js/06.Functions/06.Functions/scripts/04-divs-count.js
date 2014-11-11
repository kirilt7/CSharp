function findAllDivs() {
    var numberOfDivs = document.getElementsByTagName("div").length;
    document.getElementById("result").innerHTML = "Number of &lt;div&gt; tags: " + numberOfDivs;
}