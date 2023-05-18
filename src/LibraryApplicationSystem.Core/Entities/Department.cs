using Abp.Domain.Entities.Auditing;

namespace LibraryApplicationSystem.Entities
{
    public class Department : FullAuditedEntity<int>
    {
        //Column name
        public string Name { get; set; }   
    }
}
