using Abp.Application.Services.Dto;
using LibraryApplicationSystem.BookCategory;
using LibraryApplicationSystem.Controllers;
using LibraryApplicationSystem.Departments;
using LibraryApplicationSystem.Web.Models.BookCategories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplicationSystem.Web.Controllers
{
    public class BooksCategoriesController : LibraryApplicationSystemControllerBase
    {

        private IBookCategoryAppService _bookCategoriesAppService;
        private IDepartmentAppService _departmentAppService;

        public BooksCategoriesController(IBookCategoryAppService bookCategoriesAppService, IDepartmentAppService departmentAppService) 
        {
            _bookCategoriesAppService = bookCategoriesAppService;
            _departmentAppService = departmentAppService;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var bookcategories = await _bookCategoriesAppService.GetAllBookCategoryWithDepartment(new PagedBookCategoryResultRequestDto { MaxResultCount = int.MaxValue });
            var model = new BookCategoryViewModel();


            if (searchString != null)
                model = new BookCategoryViewModel()
                {
                    BookCategories = bookcategories.Items.Where(s => s.Name!.Contains(searchString)).ToList(),
                };
            else
                model = new BookCategoryViewModel()
                {
                    BookCategories = bookcategories.Items.ToList(),
                };
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> CreateOrEditBookCategory(int id)
        {
            var model = new CreateOrEditBookCategoryViewModel();
            var departments = await _departmentAppService.GetAllDepartments(); //end point 

            if (id != 0)
            {
                var bookCategory = await _bookCategoriesAppService.GetAsync(new EntityDto<int>(id));
                model = new CreateOrEditBookCategoryViewModel()
                {
                    Id = bookCategory.Id,
                    Name = bookCategory.Name,
                    DepartmentId = bookCategory.DepartmentId,
                };
            }
            model.Departments = departments;
            return View(model);
        }

    }
}
