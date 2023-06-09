(function ($) {
    l = abp.localization.getSource('LibraryApplicationSystem');
    var _bookAppService = abp.services.app.book; //APP SERVICE

    //EDIT 
    $(document).on('click', '.edit-books', function (e) {
        var books = $(this).attr("data-books-id");

        e.preventDefault();
        window.location.href = "/Books/CreateOrEditBook/" + books;
    });


    //DELETE
    $(document).on('click', '.delete-books', function () {
        var books = $(this).attr("data-books-id");
        var bookName = $(this).attr('data-user-name');
        var isborrowed = $(this).attr('data-books-isBorrowed');
        deletebook(books, bookName, isborrowed);
    });

    function deletebook(books, bookName, isborrowed) {
        abp.message.confirm(
            abp.utils.formatString(
                l('AreYouSureWantToDelete'),
                bookName),
            null,
            (isConfirmed) => {
                if (isConfirmed) {
                    if (isborrowed == "True") {
                        abp.notify.info(l('Cannot delete book when not returned'));
                    }
                    else {
                        _bookAppService.delete({
                            id: books
                        }).done(() => {
                            abp.notify.info(l('SuccessfullyDeleted'));
                            window.location.href = "/Books";
                            //_$form.ajax.reload();
                        });
                    }
                   
                }
            }
        );
    }


})(jQuery);

