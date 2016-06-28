using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    class Zipcode
    {
        private string zip;
        private string city;
        private string state;
        private string createdBy;
        private DateTime createdDate;
        private string modifiedBy;
        private DateTime modifiedDate;

        public Zipcode(string zp, string city, string st, string cb, DateTime cd, string mb, DateTime md)
        {
            Zip = zp;
            City = city;
            State = st;
            CreatedBy = cb;
            CreatedDate = cd;
            ModifiedBy = mb;
            ModifiedDate = md;

        }

        public string Zip { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
