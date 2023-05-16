using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LibraryApplicationSystem.BookCategory.Dto;
using LibraryApplicationSystem.Entities;

namespace LibraryApplicationSystem.Books.Dto
{
    [AutoMapFrom(typeof(Book))]
    [AutoMapTo(typeof(Book))]
    public class BookDto : EntityDto<int>
    {
        public string BookTitle { get; set; }
        public string BookPublisher { get; set; }
        public string BookAuthor { get; set; }
        public bool isBorrowed { get; set; }

        public int BookCategoryId { get; set; }
        public BookCategoryDto BookCategory { get; set; }

    }
}
