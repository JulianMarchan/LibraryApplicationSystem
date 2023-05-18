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

        deletebook(books, bookName);
    });

    function deletebook(books, bookName) {
        abp.message.confirm(
            abp.utils.formatString(
                l('AreYouSureWantToDelete'),
                bookName),
            null,
            (isConfirmed) => {
                if (isConfirmed) {
                    _bookAppService.delete({
                        id: books
                    }).done(() => {
                        abp.notify.info(l('SuccessfullyDeleted'));
                        window.location.href = "/Books";
                        //_$form.ajax.reload();
                    });
                }
            }
        );
    }


})(jQuery);

