(function ($) {
    l = abp.localization.getSource('LibraryApplicationSystem');
    var _studentAppService = abp.services.app.student;

   $(document).on('click', '.cancel-button', function (e) {
       window.location.href = _indexPage;
   });

    $(document).on('click', '.edit-dept', function (e) {
        var deptId = $(this).attr("data-dept-id");

        e.preventDefault();
        window.location.href = "/Students/CreateOrEditStudent/" + deptId;
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
                    _studentAppService.delete({
                        id: deptId
                    }).done(() => {
                        abp.notify.info(l('SuccessfullyDeleted'));
                        window.location.href = "/Students";
                        //_$form.ajax.reload();
                    });
                }
            }
        );
    }

 

})(jQuery);

