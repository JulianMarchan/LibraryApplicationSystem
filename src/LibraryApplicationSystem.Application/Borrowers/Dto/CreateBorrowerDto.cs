using Abp.AutoMapper;
using LibraryApplicationSystem.Entities;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplicationSystem.Borrowers.Dto
{
    [AutoMapTo(typeof(Borrower))]
    public class CreateBorrowerDto
    {
        public DateTime BorrowerDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int BookId { get; set; }
        public int StudentId { get; set; }
    }
}
