using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardDetails
{
    public class StudentDeatils : CollegeIDCard
    {
        private string emailId;
        private string idValidTill;
        private string course;

        public StudentDeatils(string emailId,string idValidTill, string course, int id, string phoneNumber, string name, string address, string depatment, string dob):base(id,phoneNumber,name,address,depatment,dob)
        {
            this.emailId = emailId;
            this.idValidTill = idValidTill;
            this.course = course;
        }
    }
}
