(function ($) {

    $(document).on('click', '.edit-dept', function (e) {
        var deptId = $(this).attr("data-dept-id");

        e.preventDefault();
        window.location.href = "/Departments/CreateOrEditDepartment/" + deptId;
    });

    $(document).on('click', '.delete-dept', function () {
        var deptId = $(this).attr("data-dept-id");
        var deptName = $(this).attr('data-dept-name');

        deleteDept(deptId, deptName);
    });

    function deleteDept(deptId, deptName) {
        abp.message.confirm(
            abp.utils.formatString(
                l('AreYouSureWantToDelete'),
                userName),
            null,
            (isConfirmed) => {
                if (isConfirmed) {
                    //_userService.delete({
                    //    id: userId
                    //}).done(() => {
                    //    abp.notify.info(l('SuccessfullyDeleted'));
                    //    _$usersTable.ajax.reload();
                    //});
                }
            }
        );
    }
})(jQuery);

            