﻿(function ($) {

    var _$form = $('#CreateBookCategoryForm');
    var _bookCategoriesAppService = abp.services.app.bookCategory;
    var _indexPage = "/BooksCategories";

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
        var bookCategory = _$form.serializeFormToObject();

        if (bookCategory.Id != 0) {
            _bookCategoriesAppService.update(bookCategory).done(function () {
                window.location.href = _indexPage;
            });
        } else {
            _bookCategoriesAppService.create(bookCategory).done(function () {
                window.location.href = _indexPage;
            });
        }
    }
    //CANCEL
    $(document).on('click', '.cancel-button', function (e) {
        window.location.href = _indexPage;
    });



})(jQuery);