using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using LibraryApplicationSystem.Departments.Dto;
using LibraryApplicationSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
