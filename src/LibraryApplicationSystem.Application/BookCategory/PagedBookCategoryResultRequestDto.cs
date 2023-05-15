using Abp.Application.Services.Dto;

namespace LibraryApplicationSystem.BookCategory
{
    public class PagedBookCategoryResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }

    }
}
