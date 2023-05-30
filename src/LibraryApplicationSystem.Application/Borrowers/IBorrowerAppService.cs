﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LibraryApplicationSystem.BookCategory.Dto;
using LibraryApplicationSystem.Borrowers.Dto;
using System.Threading.Tasks;

namespace LibraryApplicationSystem.Borrowers
{
    public interface IBorrowerAppService : IAsyncCrudAppService <BorrowerDto, int, PagedBorrowerResultRequestDto, CreateBorrowerDto, BorrowerDto>

    {
        Task<PagedResultDto<BorrowerDto>> GetAllBorrowerWithStudentBook(PagedResultRequestDto input);


    }
}
