using Abp.Application.Services.Dto;
using LibraryApplicationSystem.Books;
using LibraryApplicationSystem.Borrowers;
using LibraryApplicationSystem.Borrowers.Dto;
using LibraryApplicationSystem.Controllers;
using LibraryApplicationSystem.Entities;
using LibraryApplicationSystem.Students;
using LibraryApplicationSystem.Web.Models.Books;
using LibraryApplicationSystem.Web.Models.Borrowers;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplicationSystem.Web.Controllers
{
    public class BorrowersController : LibraryApplicationSystemControllerBase
    {
        private IBorrowerAppService _borrowerAppService;
        private IBookAppService _bookAppService;
        private IStudentAppService _studentAppService;

        public BorrowersController(IBorrowerAppService borrowerAppService, IBookAppService bookAppService, IStudentAppService studentAppService)
        {
            _borrowerAppService = borrowerAppService;
            _bookAppService = bookAppService;
            _studentAppService = studentAppService;
        }

        public async Task<IActionResult> Index()
        {
            var borrowers = await _borrowerAppService.GetAllBorrowerWithStudentBook(new PagedBorrowerResultRequestDto { MaxResultCount = int.MaxValue });
            var model = new BorrowerListViewModel()
            {
                Borrowers = borrowers.Items.ToList(),
            };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> CreateOrEditBorrowers()
        {
            var model = new CreateOrEditBorrowerViewModel();
            var book = await _bookAppService.GetAllBorrowersbook(); //Getallbook nasa interface
            var student = await _studentAppService.GetAllBorrowersStudent();

            model.Book = book;
            model.Student = student;
            return View(model);
        }

       

        public async Task<IActionResult> EditBorrowers(int id)
        {
            var model = new CreateOrEditBorrowerViewModel();
            var book = await _bookAppService.GetAllBorrowersbook(); //Getallbook nasa interface
            var student = await _studentAppService.GetAllBorrowersStudent();

            if (id != 0)
            {
                var borrowers = await _borrowerAppService.GetAsync(new EntityDto<int>(id));
                model = new CreateOrEditBorrowerViewModel()
                {
                    Id = borrowers.Id,
                    BorrowerDate = borrowers.BorrowerDate,
                    ExpectedReturnDate = borrowers.ExpectedReturnDate,
                    ReturnDate = borrowers.ReturnDate,
                    BookId = borrowers.BookId,
                    StudentId = borrowers.StudentId,
                };
            }
            model.Book = book;
            model.Student = student;
            return View(model);
        }
    }
}