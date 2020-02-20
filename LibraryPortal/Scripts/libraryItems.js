var libraryItems = (function () {
    var deleteAuthorId = null;

    var getItems = function () {
        $.ajax({
            type: "GET",
            url: rootUrl + "/items/list",
            success: function (response) {
                $("#container").html(response);
            }
        });
    };
    var deleteModalDialog = function (btn) {
        //deleteAuthorId = $(btn).data('authorid');
        deleteAuthorId = $(btn).attr('data-authorid');
        $("#deleteModal").show();
    };
    var deleteItem = function () {
        console.log('deleteItem: ' + deleteAuthorId);
        $.ajax({
            type: "DELETE",
            url: rootUrl + "items/delete/" + deleteAuthorId,
            contentType: "application/json; charset=utf-8",
            dataType: "json"
        }).done(function (response) {
            getItems();
        });
    };

    return {
        getItems: getItems,
        deleteModalDialog: deleteModalDialog,
        deleteItem: deleteItem
    };
})();