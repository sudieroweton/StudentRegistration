using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    class Course
    {
        private string courseNum;
        private string courseName;
        private string description;
        private decimal cost;
        private string prerequisite;
        private string createdBy;
        private DateTime createdDate;
        private string modifiedBy;
        private DateTime modifiedDate;

        public Course(string crsNum, string crsName, string desc, decimal cost, string prereq, string cb, DateTime cd, string mb, DateTime md)
        {
            CourseNum = crsNum;
            CourseName = crsName;
            Description = desc;
            Cost = cost;
            Prerequisite = prereq;
            CreatedBy = cb;
            CreatedDate = cd;
            ModifiedBy = mb;
            ModifiedDate = md;

        }

        public string CourseNum { get; set; }
        public string CourseName{ get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string Prerequisite { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
