using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LibraryApplicationSystem.Departments.Dto;
using LibraryApplicationSystem.Entities;

namespace LibraryApplicationSystem.BookCategory.Dto
{
    [AutoMapFrom(typeof(BookCategories))]
    [AutoMapTo(typeof(BookCategories))]
    public class BookCategoryDto : EntityDto<int>
    {
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public DepartmentDto Department { get; set; }

    }
}
