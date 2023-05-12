using LibraryApplicationSystem.Departments.Dto;
using LibraryApplicationSystem.Entities;
using LibraryApplicationSystem.Students.Dto;
using System.Collections.Generic;

namespace LibraryApplicationSystem.Web.Models.Students
{
    public class CreateOrEditStudentViewModel
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int StudentContactNumber { get; set; }
        public string StudentEmail { get; set; }
        public int DepartmentId { get; set; }

        public List<DepartmentDto> Departments { get; set; }
    }
}
