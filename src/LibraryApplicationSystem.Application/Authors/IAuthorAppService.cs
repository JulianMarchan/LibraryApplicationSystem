using Abp.Application.Services;
using LibraryApplicationSystem.Authors.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplicationSystem.Authors
{
    public interface IAuthorAppService : IAsyncCrudAppService <AuthorDto, int, PagedAuthorResultRequestDto, CreateAuthorDto, AuthorDto>
    {
    }
}
