using Abp.AutoMapper;
using LibraryApplicationSystem.Entities;

namespace LibraryApplicationSystem.BookCategory.Dto
{
    [AutoMapTo(typeof(BookCategories))]

    public class CreateBookCategoryDto
    {
        public string Name { get; set; }
        public int DepartmentId { get; set; }
    }
}
