using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardDetails
{
    public class GuestDeatils : CollegeIDCard
    {
        private string dateOfVisiting;

        public GuestDeatils(string dateOfVisiting, int id, string phoneNumber, string name, string address, string depatment, string dob):base(id,phoneNumber,name,address,dateOfVisiting,dob)
        {
            this.dateOfVisiting = dateOfVisiting;
        }
    }
}
