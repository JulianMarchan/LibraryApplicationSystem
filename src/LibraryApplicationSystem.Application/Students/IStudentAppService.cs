using Abp.Application.Services;
using Abp.Application.Services.Dto;

using LibraryApplicationSystem.Students.Dto;
using System.Threading.Tasks;

namespace LibraryApplicationSystem.Students
{
    public interface IStudentAppService : IAsyncCrudAppService<StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, StudentDto>
    {
        Task<PagedResultDto<StudentDto>> GetAllStudentWithDepartment(PagedResultRequestDto input);
    }
}
