using LibraryApplicationSystem.Borrowers.Dto;
using LibraryApplicationSystem.Entities;
using System.Collections.Generic;

namespace LibraryApplicationSystem.Web.Models.Borrowers
{
    public class BorrowerListViewModel
    {
    public List <BorrowerDto> Borrowers { get; set; }
    }
}
