using LibraryApplicationSystem.Books;
using LibraryApplicationSystem.Borrowers;
using LibraryApplicationSystem.Controllers;
using LibraryApplicationSystem.Students;
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
            var borrowers = await _borrowerAppService.GetAllAsync(new PagedBorrowerResultRequestDto { MaxResultCount = int.MaxValue });
            var model = new BorrowerListViewModel()
            {
                Borrowers = borrowers.Items.ToList(),
            };
            return View(model);

        }
    }
}