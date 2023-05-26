using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Application.Services.Dto;
using LibraryApplicationSystem.Controllers;
using LibraryApplicationSystem.Authors;
using LibraryApplicationSystem.Web.Models.Authors;

namespace LibraryApplicationSystem.Web.Controllers
{
    public class AuthorsController : LibraryApplicationSystemControllerBase
    {
        private readonly IAuthorAppService _authorAppService;

        public AuthorsController(IAuthorAppService userAppService)
        {
            _authorAppService = userAppService;
        }

        //public ActionResult Index()
        //{
        //    var model = new AuthorViewModel();
        //    return View(model);
        //}

        public async Task<IActionResult> Index()
        {
            var authors = await _authorAppService.GetAllAuthors();
            var model = new AuthorViewModel()
            {
                Authors = authors
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> CreateOrEditAuthor(int id)
        {
            if (id > 0)
            {
                var author = await _authorAppService.GetAsync(new EntityDto<int>(id));
                var model = new CreateOrEditAuthorViewModel()
                {

                    Name = author.Name,
                    Id = id

                };
                return View(model);
            }

            else
            {
                return View();

            }
        }
    }
}