using Abp.Domain.Entities.Auditing;
namespace LibraryApplicationSystem.Entities
{
    public class Book : FullAuditedEntity <int>
    {
        //Column name
        public string BookTitle { get; set; }
        public string BookPublisher { get; set; }
        public string BookAuthor { get; set; }
        public bool isBorrowed { get; set; }
        public int BookCategoriesId { get; set; }
        public BookCategories BookCategories { get; set; }

    }
}
