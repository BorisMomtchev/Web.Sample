var Layout = {};
Layout.Navigation = {};

Layout.init = function() {
    $("#splitter").kendoSplitter({
        panes: [
            { size: "200px", collapsible: true },
            { resizable: false }
        ]
    });
};

Layout.Navigation.init = function() {
    $.ajax({
        type: "POST",
        url: _rootUrl + "Home/GetPanelItems",
        dataType: "json"
    }).done(function(panelItems) {
        $("#menu").kendoPanelBar().data("kendoPanelBar").append(panelItems);
    });
}