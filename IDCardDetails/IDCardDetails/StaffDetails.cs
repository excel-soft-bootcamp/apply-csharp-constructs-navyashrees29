using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardDetails
{
    public class StaffDeatils : CollegeIDCard
    {
        private string typeOfWork;

        public StaffDeatils(string typeOfWork, int id, string phoneNumber, string name, string address, string depatment, string dob):base(id,phoneNumber,name,address,depatment,dob)
        {
            this.typeOfWork = typeOfWork;
        }
    }
}
