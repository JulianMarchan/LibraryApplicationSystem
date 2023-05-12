using Abp.Domain.Entities.Auditing;

namespace LibraryApplicationSystem.Entities
{
    public class Department : FullAuditedEntity<int>
    {
        public string Name { get; set; }   
    }
}
