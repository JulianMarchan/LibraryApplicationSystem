(function ($) {

    var _$form = $('#CreateBookForm');
    var _bookCategoriesAppService = abp.services.app.Books;
    var _indexPage = "/Books";

    _$form.submit(function (e) {
        e.preventDefault();
        save();
    });

    function save() {
        if (!_$form.valid()) {
            return;
        }
        var book = _$form.serializeFormToObject();

        if (book.Id != 0) {
            _bookCategoriesAppService.update(book).done(function () {
                window.location.href = _indexPage;
            });
        } else {
            _bookCategoriesAppService.create(book).done(function () {
                window.location.href = _indexPage;
            });
        }
    }
    $(document).on('click', '.cancel-button', function (e) {
        window.location.href = _indexPage;
    });



})(jQuery);