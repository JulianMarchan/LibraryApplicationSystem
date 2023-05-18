(function ($) {
    l = abp.localization.getSource('LibraryApplicationSystem');
    var _bookCategoryAppService = abp.services.app.bookCategory; //APP SERVICE

    // EDIT UPDATE
    $(document).on('click', '.edit-bookcat', function (e) {
        var bookcat = $(this).attr("data-bookcat-id");

        e.preventDefault();
        window.location.href = "/BooksCategories/CreateOrEditBookCategory/" + bookcat;
    });

    $(document).on('click', '.delete-bookcat', function () {
        var bookcat = $(this).attr("data-bookcat-id");
        var bookcatName = $(this).attr('data-user-name');

        deletebookcat(bookcat, bookcatName);
    });

    function deletebookcat(bookcat, bookcatName) {
        abp.message.confirm(
            abp.utils.formatString(
                l('AreYouSureWantToDelete'),
                bookcatName),
            null,
            (isConfirmed) => {
                if (isConfirmed) {
                    _bookCategoryAppService.delete({
                        id: bookcat
                    }).done(() => {
                        abp.notify.info(l('SuccessfullyDeleted'));
                        window.location.href = "/BooksCategories";
                        //_$form.ajax.reload();
                    });
                }
            }
        );
    }

  
})(jQuery);

