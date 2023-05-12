using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LibraryApplicationSystem.Departments.Dto;
using LibraryApplicationSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using System.Linq;


namespace LibraryApplicationSystem.Departments
{

    public class DepartmentAppService : AsyncCrudAppService<Department, DepartmentDto, int, PagedDepartmentResultRequestDto, CreateDepartmentDto, DepartmentDto>, IDepartmentAppService

    {
        private IRepository<Department, int> _repository;

        public DepartmentAppService(IRepository<Department, int> repository) : base(repository)
        {
            _repository = repository;
        }

        public override Task<DepartmentDto> CreateAsync(CreateDepartmentDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<DepartmentDto>> GetAllAsync(PagedDepartmentResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<DepartmentDto> GetAsync(EntityDto<int> input)
        {
            return base.GetAsync(input);
        }

        public override Task<DepartmentDto> UpdateAsync(DepartmentDto input)
        {
            return base.UpdateAsync(input);
        }

        public async Task<List<DepartmentDto>> GetAllDepartments()
        {
            var query = await _repository.GetAll()
                .Select(x => ObjectMapper.Map<DepartmentDto>(x))
                .ToListAsync();

            return query;
        }
    }
}
