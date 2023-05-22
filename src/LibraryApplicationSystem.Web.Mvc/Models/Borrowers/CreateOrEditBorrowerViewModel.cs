using LibraryApplicationSystem.Books.Dto;
using LibraryApplicationSystem.Entities;
using LibraryApplicationSystem.Students.Dto;
using System;
using System.Collections.Generic;

namespace LibraryApplicationSystem.Web.Models.Borrowers
{
    public class CreateOrEditBorrowerViewModel
    {
        public int Id { get; set; }
        public DateTime BorrowerDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public int BookId { get; set; }
        public int StudentId { get; set; }
        public List<BookDto> Book { get; set; }
        public List<StudentDto> Student { get; set; }

    }
}
