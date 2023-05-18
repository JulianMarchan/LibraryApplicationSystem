using Abp.AutoMapper;
using LibraryApplicationSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplicationSystem.Books.Dto
{
    [AutoMapTo(typeof(Book))]

    public class CreateBookDto
    {
        public string BookTitle { get; set; }
        public string BookPublisher { get; set; }
        public string BookAuthor { get; set; }
        public bool isBorrowed { get; set; }
        public int BookCategoriesId { get; set; }

    }
}
