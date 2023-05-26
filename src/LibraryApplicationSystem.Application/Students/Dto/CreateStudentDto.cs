using Abp.AutoMapper;
using LibraryApplicationSystem.Entities;

namespace LibraryApplicationSystem.Students.Dto
{
    [AutoMapTo(typeof(Student))]
    public class CreateStudentDto
    {
        public string StudentName { get; set; }
        public long StudentContactNumber { get; set; }
        public string StudentEmail { get; set; }
        public int DepartmentId { get; set; }
    }
}
