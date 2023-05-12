using Abp.AutoMapper;
using LibraryApplicationSystem.Departments.Dto;
using LibraryApplicationSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplicationSystem.Students.Dto
{
    [AutoMapTo(typeof(Student))]
    public class CreateStudentDto
    {
        public string StudentName { get; set; }
        public int StudentContactNumber { get; set; }
        public string StudentEmail { get; set; }
        public int DepartmentId { get; set; }
    }
}
