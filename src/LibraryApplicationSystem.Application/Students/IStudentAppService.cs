using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LibraryApplicationSystem.Entities;
using LibraryApplicationSystem.Students.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplicationSystem.Students
{
    public interface IStudentAppService : IAsyncCrudAppService<StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, StudentDto>
    {
        Task<PagedResultDto<StudentDto>> GetAllStudentWithDepartment(PagedResultRequestDto input);
    }
}
