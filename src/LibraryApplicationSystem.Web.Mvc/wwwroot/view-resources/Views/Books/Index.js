(function ($) {
    l = abp.localization.getSource('LibraryApplicationSystem');
    var _bookAppService = abp.services.app.Books; //APP SERVICE

    // EDIT UPDATE
    $(document).on('click', '.edit-dept', function (e) {
        var deptId = $(this).attr("data-dept-id");

        e.preventDefault();
        window.location.href = "/BooksCategories/CreateOrEditBook/" + deptId;
    });

    $(document).on('click', '.delete-dept', function () {
        var deptId = $(this).attr("data-dept-id");
        var deptName = $(this).attr('data-user-name');

        deleteDept(deptId, deptName);
    });

    function deleteDept(deptId, deptName) {
        abp.message.confirm(
            abp.utils.formatString(
                l('AreYouSureWantToDelete'),
                deptName),
            null,
            (isConfirmed) => {
                if (isConfirmed) {
                    _bookAppService.delete({
                        id: deptId
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

