using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDeatils student = new StudentDeatils("abhi@gmail.com", "31-06-2022", "BCA", 100301, "9874563210", "Abhi", "Mysore", "BCA", "29-09-1997");
            TeacherDeatils teacher = new TeacherDeatils("Arnav@gmail.com", "lecturer", "02-06-2020", 587410, "9265741985", "Arnav", "Mysore", "Computer Science", "05-04-1989");
            StaffDeatils staff = new StaffDeatils("security", 25874, "8745639247", "Anand", "Mysore", "Security", "25-06-1985");
            GuestDeatils guest = new GuestDeatils("26-06-2021", 4789, "9365410023", "Swamy", "Banglore", "BSc", "02-09-1986");
        }
    }
}
