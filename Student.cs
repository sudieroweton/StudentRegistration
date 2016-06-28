using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    class Student : Person
    {
        private string studentID;
        private string employer;
        private DateTime registrationDate;

        public Student(string sal, string first, string last, string strAdd, string zp, string ph, string cb, DateTime cd, string mb, DateTime md,string sID, string emp) : base(sal, first,  last, strAdd, zp, ph, cb, cd, mb, md)
        {
            StudentID = sID;
            Employer = emp;
        }

        public string StudentID { get; set; }
        public string Employer { get; set; }
    }
}
