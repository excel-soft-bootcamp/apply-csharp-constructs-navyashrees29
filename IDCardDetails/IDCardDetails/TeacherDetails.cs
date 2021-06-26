using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardDetails
{
    public class TeacherDeatils : CollegeIDCard
    {
        private string emailId;
        private string designation;
        private string dateOfJoining;

        public TeacherDeatils(string emailId, string designation,string dateOfJoining, int id, string phoneNumber, string name, string address, string depatment, string dob):base(id,phoneNumber,name,address,depatment,dob)
        {
            this.emailId = emailId;
            this.designation = designation;
            this.dateOfJoining = dateOfJoining;
        }
    }
}
