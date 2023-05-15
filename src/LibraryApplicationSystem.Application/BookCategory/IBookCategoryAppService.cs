using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LibraryApplicationSystem.BookCategory.Dto;
using System.Threading.Tasks;

namespace LibraryApplicationSystem.BookCategory
{
    public interface IBookCategoryAppService : IAsyncCrudAppService<BookCategoryDto, int, PagedBookCategoryResultRequestDto, CreateBookCategoryDto, BookCategoryDto>
    {
        Task<PagedResultDto<BookCategoryDto>> GetAllBookCategoryWithDepartment(PagedResultRequestDto input);
        
    }
}
