(function ($) {
    l = abp.localization.getSource('LibraryApplicationSystem');
    var _studentAppService = abp.services.app.student;

   $(document).on('click', '.cancel-button', function (e) {
       window.location.href = _indexPage;
   });

    $(document).on('click', '.edit-stud', function (e) {
        var studId = $(this).attr("data-stud-id");

        e.preventDefault();
        window.location.href = "/Students/CreateOrEditStudent/" + studId;
    });

    $(document).on('click', '.delete-stud', function () {
        var studId = $(this).attr("data-stud-id");
        var studName = $(this).attr('data-user-name');

        deletestud(studId, studName);
    });

    function deletestud(studId, studName) {
        abp.message.confirm(
            abp.utils.formatString(
                l('AreYouSureWantToDelete'),
                studName),
            null,
            (isConfirmed) => {
                if (isConfirmed) {
                    _studentAppService.delete({
                        id: studId
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

