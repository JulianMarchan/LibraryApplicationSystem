(function ($) {
    
    var _$form = $('#CreateDepartmentForm');
    l = abp.localization.getSource('LibraryApplicationSystem');
    var _departmentAppService = abp.services.app.department;
    var _indexPage = "/Departments";

    _$form.submit(function (e) {
        e.preventDefault();
        save();
    });

    function save() {
        if (!_$form.valid()) {
            return;
        }
        var department = _$form.serializeFormToObject();

        if (department.Id != 0) {
            _departmentAppService.update(department).done(function () {
                window.location.href = _indexPage;
            });
        } else {
            _departmentAppService.create(department).done(function () {
                window.location.href = _indexPage;
            });
        }
    }
    $(document).on('click', '.cancel-button', function (e) {
        window.location.href = _indexPage;
    });

  

})(jQuery);