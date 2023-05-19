using LibraryApplicationSystem.Entities;

using System;
using System.Collections.Generic;
using System.Linq;

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
        public List<Book> Book { get; set; }
        public List<Student> Student { get; set; }

    }
}
