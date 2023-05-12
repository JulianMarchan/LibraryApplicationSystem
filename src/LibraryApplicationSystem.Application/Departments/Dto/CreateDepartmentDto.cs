using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using LibraryApplicationSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplicationSystem.Departments.Dto
{
    [AutoMapFrom(typeof(DepartmentDto))]
    [AutoMapTo(typeof(Department))]
    public class CreateDepartmentDto 
    {
        public string Name { get; set; }
    }
}
