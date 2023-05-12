using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplicationSystem.Entities
{
    public class Student : FullAuditedEntity
    {
        public string Name { get; set; }
        public string StudentContact { get; set; }
        public string StudentEmail { get; set; }
        public int DepartmentId { get; set; }
        public Department DepartmentFk { get; set; }

    }
}
