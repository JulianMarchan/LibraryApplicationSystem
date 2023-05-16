using LibraryApplicationSystem.BookCategory.Dto;
using System.Collections.Generic;

namespace LibraryApplicationSystem.Web.Models.Book
{
    public class CreateOrEditBookViewModel
    {
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public string BookPublisher { get; set; }
        public string BookAuthor { get; set; }
        public bool isBorrowed { get; set; }

        public int BookCategoryId { get; set; }
        public List<BookCategoryDto> BookCategories { get; set; }


    }
}
