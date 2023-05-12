using Abp.Application.Services.Dto;
using LibraryApplicationSystem.Controllers;
using LibraryApplicationSystem.Departments;
using LibraryApplicationSystem.Departments.Dto;
using LibraryApplicationSystem.Web.Models.Departments;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplicationSystem.Web.Controllers
{
    public class DepartmentsController : LibraryApplicationSystemControllerBase
    {

        private readonly IDepartmentAppService _departmentAppService;

        public DepartmentsController(IDepartmentAppService departmentAppService)
        {
            _departmentAppService = departmentAppService;
        }

        public async Task<IActionResult> Index()
        {
            var departments = await _departmentAppService.GetAllAsync(new PagedDepartmentResultRequestDto { MaxResultCount = int.MaxValue });
            var model = new DepartmentListViewModel()
            {
                Departments = departments.Items.ToList()
            };

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> CreateOrEditDepartment(int id)
        {
            if (id > 0)
            {
                var department = await _departmentAppService.GetAsync(new EntityDto<int>(id));
                var model = new CreateOrEditDepartmentViewModel()
                {
                    //Id = department.Id,
                    Name = department.Name,
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
