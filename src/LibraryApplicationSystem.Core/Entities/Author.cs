using Abp.Domain.Entities.Auditing;
using System.Linq;
namespace LibraryApplicationSystem.Entities
{
    public class Author : FullAuditedEntity <int>
    {
        public string Name { get; set; }
    }
}
