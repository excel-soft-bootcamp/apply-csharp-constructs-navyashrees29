using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardDetails
{
    public class CollegeIDCard
    {
        private int id ;
        private string name, phoneNumber,address, depatment, dob;

        public CollegeIDCard(int id)
        {
            this.id = id;
        }

        public CollegeIDCard(int id,string phoneNumber):this(id)
        {
            this.phoneNumber = phoneNumber;
        }

        public CollegeIDCard(int id, string phoneNumber,string name):this(id,phoneNumber)
        {
            this.name = name;
        }

        public CollegeIDCard(int id, string phoneNumber,string name, string address):this(id,phoneNumber,name)
        {
            this.address = address;
        }

        public CollegeIDCard(int id, string phoneNumber, string name, string address,string depatment): this(id, phoneNumber, name,address)
        {
            this.depatment = depatment;
        }

        public CollegeIDCard(int id, string phoneNumber, string name, string address, string depatment,string dob): this(id, phoneNumber, name, address,depatment)
        {
            this.dob = dob;
        }
    }
}
