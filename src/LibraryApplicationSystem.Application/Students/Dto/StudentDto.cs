﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LibraryApplicationSystem.Departments.Dto;
using LibraryApplicationSystem.Entities;

namespace LibraryApplicationSystem.Students.Dto
{
    [AutoMapFrom(typeof(Student))]
    [AutoMapTo(typeof(Student))]

    public class StudentDto : EntityDto<int>
    {
        public string StudentName { get; set; }
        public long StudentContactNumber { get; set; }
        public string StudentEmail { get; set; }
        public int DepartmentId { get; set; }

        public DepartmentDto Department { get; set; }
    }
}

