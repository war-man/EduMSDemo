﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduMSDemo.Objects
{
    public class Faculty : BaseModel
    {
        [Required]
        [StringLength(32)]
        [Index(IsUnique = true)]
        public String Abbreviation { get; set; }

        [Required]
        [StringLength(128)]
        [Index(IsUnique = true)]
        public String Name { get; set; }

        [StringLength(512)]
        public String Address { get; set; }

        [StringLength(256)]
        [EmailAddress]
        public String Email { get; set; }

        [StringLength(256)]
        //[Phone]
        public String PhoneNumber { get; set; }

        [StringLength(256)]
        //[Phone]
        public String FaxNumber { get; set; }

        // List Department
        public virtual IList<Department> Departments { get; set; }

        // List Curriculum
        public virtual IList<Curriculum> Curriculums { get; set; }

        // List Course
        public virtual IList<Course> Courses { get; set; }
    }
}
