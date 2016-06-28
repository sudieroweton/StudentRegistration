using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    class Enrollment
    {
        private string studentID;
        private string sectionID;
        private DateTime enrollDate;
        private string finalGrade;
        private string createdBy;
        private DateTime createdDate;
        private string modifiedBy;
        private DateTime modifiedDate;

        public Enrollment(string sID, string secID, DateTime enrDate, string fgrade, string cb, DateTime cd, string mb, DateTime md)
        {
            StudentID = sID;
            SectionID = secID;
            EnrollDate = enrDate;
            FinalGrade = fgrade;
            CreatedBy = cb;
            CreatedDate = cd;
            ModifiedBy = mb;
            ModifiedDate = md;

        }

        public string StudentID { get; set; }
        public string SectionID { get; set; }
        public DateTime EnrollDate { get; set; }
        public string FinalGrade { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
