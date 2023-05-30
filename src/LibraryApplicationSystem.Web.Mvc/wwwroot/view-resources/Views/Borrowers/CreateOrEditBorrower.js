(function ($) {
    var _$form = $('#CreateBorrowerForm');
    var _borrowerAppService = abp.services.app.borrower;
    var _bookAppService = abp.services.app.book;
    var _indexPage = "/Borrowers";
    var _currentDate = new Date();
    var _returnDate = new Date();

    _returnDate.setDate(_currentDate.getDate() + 7);

    window.onload = function() {
        document.getElementById('BorrowerDate').value =_currentDate.toISOString().slice(0, 10);
        document.getElementById('ExpectedReturnDate').value =_returnDate.toISOString().slice(0, 10);
  
    }
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
                if (borrower.BorrowerDate <= borrower.ReturnDate) {
                    _bookAppService.updateIsBorrowed({
                        Id: borrower.BookId,
                    }).done(function () {
                        window.location.href = _indexPage;
                    });
                }
                else{
                    window.location.href = _indexPage;
                }
            });
        } else {
            _borrowerAppService.create(borrower).done(function ()
            {
                _bookAppService.updateIsBorrowed({
                    Id: borrower.BookId,
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

    

})(jQuery);