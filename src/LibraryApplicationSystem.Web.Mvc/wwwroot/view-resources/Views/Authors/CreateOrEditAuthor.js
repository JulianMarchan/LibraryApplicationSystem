(function ($) {

    var _$form = $('#CreateAuthorForm');
    var _authorAppService = abp.services.app.author;
    var _indexPage = "/Authors";

    _$form.submit(function (e) {
        e.preventDefault();
        save();
    });
    function save() {
        if (!_$form.valid()) {
            return;
        }
        var author = _$form.serializeFormToObject();

        if (author.Id != 0) {
            _authorAppService.update(author).done(function () {
                window.location.href = _indexPage;
            });
        } else {
            _authorAppService.create(author).done(function () {
                window.location.href = _indexPage;
            });
        }
    }
    $(document).on('click', '.cancel-button', function (e) {
        window.location.href = _indexPage;
    });
})(jQuery);