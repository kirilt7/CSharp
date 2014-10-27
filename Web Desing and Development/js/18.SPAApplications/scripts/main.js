(function () {
    var messagesToShow = 7;
    var milisecondsBetweenRefresh = 3000;

    reloadMessages();
    setInterval(reloadMessages, milisecondsBetweenRefresh);
    $("#send-btn").on("click", sendMessage);


    function reloadMessages() {
        RemoteController.get("http://crowd-chat.herokuapp.com/posts")
            .then(function (messages) {
                var $list = $("#messages-list").empty();
                var len = Math.min(messages.length, messagesToShow);
                var init = Math.max(0, messages.length - messagesToShow - 1);
                var messageFragment = document.createDocumentFragment();
                for (var i = init; i < init + len; i++) {
                    var $message = $("<li>")
                        .attr("id", messages[i].id)
                        .append($("<header>").append(messages[i].by))
                        .append(messages[i].text)
                        .appendTo(messageFragment);
                    if (messages[i].by === $("#username-input").val()) {
                        $message.addClass("myMessage");
                    }
                }
                $list.append(messageFragment);
            }).done();
    }

    function sendMessage() {
        var text = $("#chat-input").val();
        var user = $("#username-input").val();
        RemoteController.post("http://crowd-chat.herokuapp.com/posts", { user: user, text: text });
        reloadMessages();
    }
}())