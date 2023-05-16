using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LibraryApplicationSystem.Books.Dto;
using System.Threading.Tasks;

namespace LibraryApplicationSystem.Books
{
    public interface IBookAppService : IAsyncCrudAppService<BookDto, int, PagedBookResultRequestDto, CreateBookDto, BookDto>
    {
       Task<PagedResultDto<BookDto>> GetAllBookWithCategory(PagedResultRequestDto input);


    }
}
