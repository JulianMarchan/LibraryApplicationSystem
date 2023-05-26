using LibraryApplicationSystem.Authors.Dto;
using LibraryApplicationSystem.BookCategory.Dto;
using LibraryApplicationSystem.Entities;
using System.Collections.Generic;

namespace LibraryApplicationSystem.Web.Models.Books
{
    public class CreateOrEditBookViewModel
    {
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public string BookPublisher { get; set; }
        public bool isBorrowed { get; set; }
        public int AuthorId { get; set; }
        public int BookCategoriesId { get; set; }
        public List<AuthorDto> Author { get; set; }
        public List<BookCategoryDto> BookCategories { get; set; }


    }
}
