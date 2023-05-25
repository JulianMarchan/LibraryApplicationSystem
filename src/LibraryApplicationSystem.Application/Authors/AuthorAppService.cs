using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LibraryApplicationSystem.Authors.Dto;
using LibraryApplicationSystem.Borrowers.Dto;
using LibraryApplicationSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplicationSystem.Authors
{
    public class AuthorAppService : AsyncCrudAppService<Author, AuthorDto, int, PagedAuthorResultRequestDto, CreateAuthorDto, AuthorDto>, IAuthorAppService
    {
        private readonly IRepository<Borrower, int> _repository;


        public AuthorAppService(IRepository<Author, int> repository) : base(repository)
        {
            
        }

        public override Task<AuthorDto> CreateAsync(CreateAuthorDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<AuthorDto>> GetAllAsync(PagedAuthorResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<AuthorDto> GetAsync(EntityDto<int> input)
        {
            return base.GetAsync(input);
        }

        public override Task<AuthorDto> UpdateAsync(AuthorDto input)
        {
            return base.UpdateAsync(input);
        }
    
    }
}
