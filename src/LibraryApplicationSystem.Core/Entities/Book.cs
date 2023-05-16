using Abp.Domain.Entities.Auditing;
namespace LibraryApplicationSystem.Entities
{
    public class Book : FullAuditedEntity <int>
    {
        public string BookTitle { get; set; }
        public string BookPublisher { get; set; }
        public string BookAuthor { get; set; }
        public bool isBorrowed { get; set; }
        public int BookCategoryId { get; set; }
        public BookCategories BookCategories { get; set; }

    }
}
