using LibraryApplicationSystem.Departments.Dto;
using System.Collections.Generic;

namespace LibraryApplicationSystem.Web.Models.Students
{
    public class CreateOrEditBookCategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
        public List<DepartmentDto> Departments { get; set; }
    }
}
