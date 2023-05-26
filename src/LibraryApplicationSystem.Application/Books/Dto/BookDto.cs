using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LibraryApplicationSystem.BookCategory.Dto;
using LibraryApplicationSystem.Entities;

namespace LibraryApplicationSystem.Books.Dto
{

    //To get the properties from our Entity
    [AutoMapFrom(typeof(Book))]
    [AutoMapTo(typeof(Book))]
    public class BookDto : EntityDto<int>
    {
        public string BookTitle { get; set; }
        public string BookPublisher { get; set; }
        public bool isBorrowed { get; set; }

        public int AuthorId { get; set; }
        public int BookCategoriesId { get; set; }
        public BookCategoryDto BookCategories { get; set; }
        public Author Author { get; set; }

    }
}
