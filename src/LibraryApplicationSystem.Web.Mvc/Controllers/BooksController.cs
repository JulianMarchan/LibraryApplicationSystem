using Abp.Application.Services.Dto;
using LibraryApplicationSystem.Authors;
using LibraryApplicationSystem.BookCategory;
using LibraryApplicationSystem.Books;
using LibraryApplicationSystem.Books.Dto;
using LibraryApplicationSystem.Controllers;
using LibraryApplicationSystem.Entities;
using LibraryApplicationSystem.Web.Models.Books;
using LibraryApplicationSystem.Web.Models.Departments;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplicationSystem.Web.Controllers
{
    public class BooksController : LibraryApplicationSystemControllerBase
    {

        private IBookAppService _bookAppService;
        private IBookCategoryAppService _bookCategoriesAppService;
        private IAuthorAppService _authorAppService;

        public List<BookDto> Books { get; private set; }

        public BooksController(IBookAppService bookAppService, IBookCategoryAppService bookCategoryAppService, IAuthorAppService authorAppService) 
        {
            _bookAppService = bookAppService;
            _bookCategoriesAppService = bookCategoryAppService;
            _authorAppService = authorAppService;
        }


        public async Task<IActionResult> Index(string searchString)
        {
            var book = await _bookAppService.GetAllBookWithCategory(new PagedBookResultRequestDto { MaxResultCount = int.MaxValue });
            var model = new BookListViewModel();

            if (searchString != null)
            {
                model = new BookListViewModel()
                {
                    Books = book.Items.Where(s => s.BookTitle!.Contains(searchString)
                    || s.Id!.ToString().Contains(searchString)
                    || s.BookPublisher!.Contains(searchString)
                    || s.BookCategories!.Name.ToString().Contains(searchString)
                    || s.Author.Name.ToString().Contains(searchString)).ToList(),
                };
            }
            else
                model = new BookListViewModel()
                {
                    Books = book.Items.ToList(),
                };
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> CreateOrEditBook(int id)
        {
            var model = new CreateOrEditBookViewModel();
            var bookCategories = await _bookCategoriesAppService.GetAllBookCategory(); //Getallbook nasa interface
            var author = await _authorAppService.GetAllAuthors();

            if (id != 0)
            {
                var book = await _bookAppService.GetAsync(new EntityDto<int>(id));
                model = new CreateOrEditBookViewModel()
                {
                    Id = book.Id,
                    BookTitle = book.BookTitle,
                    BookPublisher = book.BookPublisher,
                    AuthorId = book.AuthorId,
                    isBorrowed = book.isBorrowed,
                    BookCategoriesId = book.BookCategoriesId,

                };
            }
            model.Author = author;
            model.BookCategories = bookCategories;
            return View(model);
        }


    }
}
