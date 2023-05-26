(function ($) {
    var _$form = $('#CreateAuthorForm');
    var _authorAppService = abp.services.app.author;
    var _indexPage = "/Authors";
        l = abp.localization.getSource('LibraryApplicationSystem'),
        _$table = $('#AuthorsTable');

    var _$authorsTable = _$table.DataTable({
        paging: true,
        serverSide: true,
        listAction: {
            ajaxFunction: _authorAppService.getAll,
            inputFilter: function () {
                return $('#AuthorsTable').serializeFormToObject(true);
            }
        },
        buttons: [
            {
                name: 'refresh',
                text: '<i class="fas fa-redo-alt"></i>',
                action: () => _$authorsTable.draw(false)
            }
        ],
        responsive: {
            details: {
                type: 'column'
            }
        },
        columnDefs: [
            {
                targets: 0,
                className: 'control',
                defaultContent: '',
            },
            {
                targets: 1,
                data: 'id',
                sortable: false
            },
            {
                targets: 2,
                data: 'name',
                sortable: false
            },
            {
                targets: 3,
                data: null,
                sortable: false,
                autoWidth: false,
                defaultContent: '',
                render: (data, type, row, meta) => {
                    return [
                        `   <button type="button" class="btn btn-sm bg-secondary edit-author" data-author-id="${row.id}" data-toggle="modal" data-target="#AuthorEditModal">`,
                        `       <i class="fas fa-pencil-alt"></i> ${l('Edit')}`,
                        '   </button>',
                        `   <button type="button" class="btn btn-sm bg-danger delete-author" data-author-id="${row.id}" data-author-name="${row.name}">`,
                        `       <i class="fas fa-trash"></i> ${l('Delete')}`,
                        '   </button>'
                    ].join('');
                }
            }
        ]
    });

    $(document).on('click', '.edit-author', function (e) {
        var authorId = $(this).attr("data-author-id");
        var authorName = $(this).attr("data-author-name");

        e.preventDefault();
        window.location.href = "/Authors/CreateOrEditAuthor/" + authorId;
    });
    $(document).on('click', '.delete-author', function () {
        var authorId = $(this).attr("data-author-id");
        var authorName = $(this).attr("data-author-name");

        deleteAuth(authorId, authorName);
    });
    function deleteAuth(authorId, authorName) {
        abp.message.confirm(
            abp.utils.formatString(
                l('AreYouSureWantToDelete'),
                authorName),
            null,
            (isConfirmed) => {
                if (isConfirmed) {
                    _authorAppService.delete({
                        id: authorId
                    }).done(() => {
                        abp.notify.info(l('SuccessfullyDeleted'));
                        window.location.href = "/Authors";
                        //_$form.ajax.reload();
                    });
                }
            }
        );
    }


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
