(function ($) {
    l = abp.localization.getSource('LibraryApplicationSystem');
    var _borrowerAppService = abp.services.app.borrower; //APP SERVICE

    //EDIT 
    $(document).on('click', '.edit-borr', function (e) {
        var borr = $(this).attr("data-borr-id");

        e.preventDefault();
        window.location.href = "/Borrowers/EditBorrowers/" + borr;
    });



    //DELETE
    $(document).on('click', '.delete-borr', function () {
        var borr = $(this).attr("data-borr-id");
        var bookName = $(this).attr('data-user-name');

        deleteBorrowers(borr, bookName);
    });

    function deleteBorrowers(borr, bookName) {
        abp.message.confirm(
            abp.utils.formatString(
                l('AreYouSureWantToDelete'),
                bookName),
            null,
            (isConfirmed) => {
                if (isConfirmed) {
                    _borrowerAppService.delete({
                        id: borr
                    }).done(() => {
                        abp.notify.info(l('SuccessfullyDeleted'));
                        window.location.href = "/Borrowers";
                        //_$form.ajax.reload();
                    });
                }
            }
        );
    }


})(jQuery);

