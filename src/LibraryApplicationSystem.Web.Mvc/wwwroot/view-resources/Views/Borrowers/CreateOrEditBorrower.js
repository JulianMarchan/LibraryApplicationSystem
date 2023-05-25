(function ($) {
    var _$form = $('#CreateBorrowerForm');
    var _borrowerAppService = abp.services.app.borrower;
    var _bookAppService = abp.services.app.book;
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
            _borrowerAppService.create(borrower).done(function ()
            {
                _bookAppService.update({
                    id: borrower.BookId,
                    isBorrowed: borrower.isBorrowed,
                    bookCategoriesId: 21,
                    BookPublisher:'Marvels',
                    bookTitle: 'The beauty and the kids',
                }).done(function () {

                window.location.href = _indexPage;
                });
            });
        }
    }
    //CANCEL
    $(document).on('click', '.cancel-button', function (e) {
        window.location.href = _indexPage;
    });

    //on create ng is borrower isasabay i updateyung book which is yung is borrowed niya ay true / kapag may return date gagawing false return date is not null 

})(jQuery);