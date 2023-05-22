(function ($) {
    var _$form = $('#CreateBorrowerForm');
    var _borrowerAppService = abp.services.app.borrower;
    var _indexPage = "/Borrowers";

    //CLICK ON SUBMIT
    _$form.submit(function (e) {
        e.preventDefault();
        save();
    });

    //CREATE N EDIT
    function save() {
        if (!_$form.valid()) {
            return;
        }
        var borrower = _$form.serializeFormToObject();

        if (borrower.Id != 0) {
            _borrowerAppService.update(borrower).done(function () {
                window.location.href = _indexPage;
            });
        } else {
            _borrowerAppService.create(borrower).done(function () {
                window.location.href = _indexPage;
            });
        }
    }
    //CANCEL
    $(document).on('click', '.cancel-button', function (e) {
        window.location.href = _indexPage;
    });



})(jQuery);