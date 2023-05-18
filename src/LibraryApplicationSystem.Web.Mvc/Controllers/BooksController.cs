using Abp.Application.Services.Dto;
using LibraryApplicationSystem.BookCategory;
using LibraryApplicationSystem.Books;
using LibraryApplicationSystem.Controllers;
using LibraryApplicationSystem.Web.Models.Books;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplicationSystem.Web.Controllers
{
    public class BooksController : LibraryApplicationSystemControllerBase
    {

        private IBookAppService _bookAppService;
        private IBookCategoryAppService _bookCategoriesAppService;

        public BooksController(IBookAppService bookAppService, IBookCategoryAppService bookCategoryAppService) 
        {
            _bookAppService = bookAppService;
            _bookCategoriesAppService = bookCategoryAppService;
        }


        public async Task<IActionResult> Index()
        {
            var books = await _bookAppService.GetAllBookWithCategory(new PagedBookResultRequestDto { MaxResultCount = int.MaxValue });
            var model = new BookListViewModel()
            {
                Books = books.Items.ToList(),
            };
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> CreateOrEditBook(int id)
        {
            var model = new CreateOrEditBookViewModel();
            var bookCategories = await _bookCategoriesAppService.GetAllBookCategory(); //Getallbook nasa interface

            if (id != 0)
            {
                var books = await _bookAppService.GetAsync(new EntityDto<int>(id));
                model = new CreateOrEditBookViewModel()
                {
                    Id = books.Id,
                    BookTitle = books.BookTitle,
                    BookPublisher = books.BookPublisher,
                    BookAuthor = books.BookAuthor,
                    isBorrowed = books.isBorrowed,
                    BookCategoriesId = books.BookCategoriesId,
                };
            }
            model.BookCategories = bookCategories;
            return View(model);
        }


    }
}
