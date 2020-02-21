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

   //create item tuffs
   
    var createModalDialog = function (btn) {
        $("#myModal").show();
    };


    var createItem = function () {
        console.log('create new item');

        var newItem = new Object();
        newItem.Item_Name = $('#itemName').val();
        newItem.Author = $('#itemAuthor').val();
        newItem.Item_Type = $('#itemType').val();

        if (newItem != null) {
            $.ajax({
                type: "POST",
                url: rootUrl + "items/create",
                data: JSON.stringify(newItem),
                contentType: "application/json; charset=utf-8",
                dataType: "json"
            }).done(function (redirectUrl) {
               getItems();
            });
        }
    };


    return {
        getItems: getItems,
        createModalDialog: createModalDialog,
        createItem: createItem,
        deleteModalDialog: deleteModalDialog,
        deleteItem: deleteItem
      
    };
   
})();