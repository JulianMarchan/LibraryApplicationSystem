(function ($) {
    
    var _$form = $('#CreateStudentForm');
    var _studentAppService = abp.services.app.student;
    var _indexPage = "/Students";

    _$form.submit(function (e) {
        e.preventDefault();
        save();
    });

    function save() {
        if (!_$form.valid()) {
            return;
        }
        var student = _$form.serializeFormToObject();

        if (student.Id != 0) {
            _studentAppService.update(student).done(function () {
                window.location.href = _indexPage;
            });
        } else {
            _studentAppService.create(student).done(function () {
                window.location.href = _indexPage;
            });
        }
    }

    
    $(document).on('click', '.cancel-button', function (e) {
        window.location.href = _indexPage;
    });

  

})(jQuery);