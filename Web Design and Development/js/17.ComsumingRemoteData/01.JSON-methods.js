define(["scripts/libs/jquery-2.0.3"], function ($) {

//        01. Create a module that exposes methods for
//        performing HTTP requests by given URL and
//        headers
//          getJSON and postJSON
//          Both methods should work with promises.

//        02. Read the developer documentation of Twitter
//        Create a simple application that visualizes all
//        public tweets for a given user (maybe from a
//        textbox)
//        CANNOT BE DONE - "User timelines belonging to protected users may only
//        be requested when the authenticated user either "owns" the timeline or is
//        an approved follower of the owner." says developer documentation of Twitter.
        var getJSON = function (url, headers) {
            $.ajax({
                url: url,
                type: 'GET',
                contentType: 'application/json',
                headers: headers || {},
                data: null
            })

        };

        var postJSON = function (url, headers, data) {
            $.ajax({
                url: url,
                type: 'post',
                contentType: 'application/json',
                headers: headers || {},
                data: data
            })
        };
        return {
            getJSON: getJSON,
            postJSON: postJSON
        }
    }
);