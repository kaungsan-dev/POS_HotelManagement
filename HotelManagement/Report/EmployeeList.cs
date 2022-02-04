using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Report.Employee
{
    public class EmployeeList
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhNo { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }

        public EmployeeList(int ID, string Name, string Email, string PhNo, string Gender, string Position)
        {
            this.ID = ID;
            this.Name = Name;
            this.Email = Email;
            this.PhNo = PhNo;
            this.Gender = Gender;
            this.Position = Position;
        }
    }
}
