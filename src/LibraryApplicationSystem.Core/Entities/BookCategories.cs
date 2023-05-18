using Abp.Domain.Entities.Auditing;
namespace LibraryApplicationSystem.Entities
{
    public class BookCategories : FullAuditedEntity<int>
    {
        //Column name
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
