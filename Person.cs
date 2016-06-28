using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    class Person
    {
        private string salutation;
        private string firstName;
        private string lastName;
        private string streetAddress;
        private string zip;
        private string phone;
        private string createdBy;
        private DateTime createdDate;
        private string modifiedBy;
        private DateTime modifiedDate;

        public Person(string sal, string first, string last, string strAdd, string zp, string ph, string cb, DateTime cd, string mb, DateTime md)
        {
            Salutation = sal;
            FirstName = first;
            LastName = last;
            StreetAddress = strAdd;
            Zip = zp;
            Phone = ph;
            CreatedBy = cb;
            CreatedDate = cd;
            ModifiedBy = mb;
            ModifiedDate = md;

        }

        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

}
