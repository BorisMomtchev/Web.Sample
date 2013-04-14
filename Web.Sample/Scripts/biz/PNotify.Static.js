var PNotify = {};
PNotify.Static = {};

//Ensures that the history isnt displayed by default. 
//You can still override this behavior by setting the history property in the notification to true.
pnotify.defaults.history = false;

PNotify.Static.init = function() {
    $("#btn_Simple").click(function() {
        $.pnotify({
            title: 'Regular Notice',
            text: 'Check me out! I\'m a notice.'
        });
    });
}