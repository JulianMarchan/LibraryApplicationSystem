using LibraryApplicationSystem.BookCategory.Dto;
using LibraryApplicationSystem.Departments.Dto;
using System.Collections.Generic;

namespace LibraryApplicationSystem.Web.Models.BookCategories
{
    public class CreateOrEditBookCategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public List<DepartmentDto> Departments { get; set; }

    }
}
