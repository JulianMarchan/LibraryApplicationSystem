using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LibraryApplicationSystem.Books.Dto;
using LibraryApplicationSystem.Entities;
using LibraryApplicationSystem.Students.Dto;
using Microsoft.VisualBasic;
using System;

namespace LibraryApplicationSystem.Borrowers.Dto
{
    [AutoMapFrom(typeof(Borrower))]
    [AutoMapTo(typeof(Borrower))]
    public class BorrowerDto : EntityDto<int>
    {
        public readonly object BookCategories;

        public DateTime BorrowerDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int BookId { get; set; }
        public int StudentId { get; set; }
        public BookDto Book { get; set; }
        public StudentDto Student { get; set; }
    }
}
