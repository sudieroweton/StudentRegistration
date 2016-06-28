using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    class Instructor : Person
    {
        private string instructorID;

        public Instructor(string sal, string first, string last, string strAdd, string zp, string ph, string cb, DateTime cd, string mb, DateTime md, string iID) : base(sal, first, last, strAdd, zp, ph, cb,cd, mb, md)
        {
            InstructorID = iID;
        }

        public string InstructorID { get; set; }
    
    }
}
