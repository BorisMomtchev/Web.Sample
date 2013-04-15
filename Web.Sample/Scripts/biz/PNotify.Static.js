var PNotify = {};
PNotify.Static = {};

//Ensures that the history isnt displayed by default. 
//You can still override this behavior by setting the history property in the notification to true.
$.pnotify.defaults.history = false;

PNotify.Static.init = function () {
    var stackBarTop = { "dir1": "down", "dir2": "right", "push": "top", "spacing1": 0, "spacing2": 0 };
    $("#btn_Simple").click(function() {
        $.pnotify({
            title: 'Regular Notice',
            text: 'Check me out! I\'m a notice.',
            addClass: "stack-bar-top",
            stack: stackBarTop,
            width: "100%"
        });
    });
}