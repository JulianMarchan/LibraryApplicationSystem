using Abp.Application.Services.Dto;
using LibraryApplicationSystem.Controllers;
using LibraryApplicationSystem.Departments;
using LibraryApplicationSystem.Entities;
using LibraryApplicationSystem.Students;
using LibraryApplicationSystem.Students.Dto;
using LibraryApplicationSystem.Web.Models.Students ;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplicationSystem.Web.Controllers
{
    public class StudentsController : LibraryApplicationSystemControllerBase
    {

        private IStudentAppService _studentAppService; //_studentAppService interface
        private IDepartmentAppService _departmentAppService;

        public List<StudentDto> Students { get; private set; }

        public StudentsController(IStudentAppService studentAppService, IDepartmentAppService departmentAppService) // this how to call the api and get the list from db
        {
            _studentAppService = studentAppService;
            _departmentAppService = departmentAppService;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var students = await _studentAppService.GetAllStudentWithDepartment(new PagedStudentResultRequestDto { MaxResultCount = int.MaxValue });
            var model = new StudentListViewModel();
            
            if (searchString != null)
            {
                model = new StudentListViewModel()
                {
                    Students = students.Items.Where(s => 
                       s.StudentName!.ToString().Contains(searchString)
                    || s.Id!.ToString().Contains(searchString)
                    || s.StudentContactNumber!.ToString().Contains(searchString)
                    || s.Department.Name.ToString().Contains(searchString)
                    || s.StudentEmail!.Contains(searchString))
                    .ToList(),
                };
            }
            else
                model = new StudentListViewModel()
                {
                    Students = students.Items.ToList(),
                };
            return View(model);
           
        }


        [HttpGet]
        public async Task<IActionResult> CreateOrEditStudent(int id)
        {
            var model = new CreateOrEditStudentViewModel();
            var departments = await _departmentAppService.GetAllDepartments(); //end point interface

            if (id != 0)
            {
                var student = await _studentAppService.GetAsync(new EntityDto<int>(id));
                model = new CreateOrEditStudentViewModel()
                {
                    //Id = department.Id,
                    Id = student.Id,
                    StudentName = student.StudentName,
                    StudentContactNumber = student.StudentContactNumber,
                    StudentEmail = student.StudentEmail,
                    DepartmentId = student.DepartmentId,
                };
            }
            model.Departments = departments;
            return View(model);
        }
    }
}
