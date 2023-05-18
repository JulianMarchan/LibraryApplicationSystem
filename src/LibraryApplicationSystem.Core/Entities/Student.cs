using Abp.Domain.Entities.Auditing;

namespace LibraryApplicationSystem.Entities
{
    public class Student : FullAuditedEntity<int>
    {
        //Column Name
        public string StudentName { get; set; }
        public int StudentContactNumber { get; set; }
        public string StudentEmail { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
