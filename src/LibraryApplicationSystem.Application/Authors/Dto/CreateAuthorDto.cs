using Abp.AutoMapper;
using LibraryApplicationSystem.Departments.Dto;
using LibraryApplicationSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplicationSystem.Authors.Dto
{

    [AutoMapFrom(typeof(AuthorDto))]
    [AutoMapTo(typeof(Author))]
    public class CreateAuthorDto
    {
        public string Name { get; set; }
    }
}
