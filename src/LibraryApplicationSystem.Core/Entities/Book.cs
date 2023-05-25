using Abp.Domain.Entities.Auditing;
using System.Linq;
namespace LibraryApplicationSystem.Entities
{
    public class Book : FullAuditedEntity <int>
    {
        //Column name
        public string BookTitle { get; set; }
        public string BookPublisher { get; set; }
        public bool isBorrowed { get; set; }
        public int AuthorId { get; set; }
        public int BookCategoriesId { get; set; }
        public BookCategories BookCategories { get; set; }

    }
}
