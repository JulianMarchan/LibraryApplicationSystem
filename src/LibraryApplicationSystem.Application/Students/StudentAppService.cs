using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LibraryApplicationSystem.Entities;
using LibraryApplicationSystem.Students.Dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplicationSystem.Students
{

    public class StudentAppService : AsyncCrudAppService<Student, StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, StudentDto>, IStudentAppService

    {
        private readonly IRepository<Student, int> _repository;
        public StudentAppService(IRepository<Student, int> repository) : base(repository)
        {
            _repository = repository;
        }

        public override Task<StudentDto> CreateAsync(CreateStudentDto input)
        {
           return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<StudentDto>> GetAllAsync(PagedStudentResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<StudentDto> GetAsync(EntityDto<int> input)
        {
            return base.GetAsync(input);
        }

        public override Task<StudentDto> UpdateAsync(StudentDto input)
        {
            return base.UpdateAsync(input);
        }

        public async Task<PagedResultDto<StudentDto>> GetAllStudentWithDepartment(PagedResultRequestDto input)
        {
            var students = await _repository.GetAll()
                .Include(x => x.Department)
                .Select(x => ObjectMapper.Map<StudentDto>(x))
                .ToListAsync();


            return new PagedResultDto<StudentDto>(students.Count(), students);
        }
    }
}
