using Abp.Application.Services;
using LibraryApplicationSystem.BookCategory.Dto;


namespace LibraryApplicationSystem.BookCategory
{
    public interface IBookCategoryAppService : IAsyncCrudAppService<BookCategoryDto, int, PagedBookCategoryResultRequestDto, CreateBookCategoryDto, BookCategoryDto>
    { 

    }
}
