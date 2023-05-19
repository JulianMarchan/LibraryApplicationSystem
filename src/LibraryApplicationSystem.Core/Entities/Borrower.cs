using Abp.Domain.Entities.Auditing;
using Microsoft.VisualBasic;
using System;

namespace LibraryApplicationSystem.Entities
{
    public class Borrower : FullAuditedEntity <int>
    {
        public DateTime BorrowerDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public int BookId { get; set; }
        public int? StudentId { get; set; }
        public Book Book { get; set; }
        public Student Student { get; set; }
        

    }
}
