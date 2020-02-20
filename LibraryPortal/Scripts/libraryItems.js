var libraryItems = (function () {
    var getItems = function () {
        $.ajax({
            type: "GET",
            url: rootUrl + "/items/list",
            success: function (response) {
                $("#container").html(response);
            }
        });
    };

    return {
        getItems: getItems
    };
})();