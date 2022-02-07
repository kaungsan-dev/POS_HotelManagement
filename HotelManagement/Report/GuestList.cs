using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Report.Guest
{
    public class GuestList
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public string mobile { get; set; }
        public string nationality { get; set; }
        public string gender { get; set; }
        public string dateofbirth { get; set; }
        public string address { get; set; }

        public GuestList(int customerId, string customerName, string mobile, string nationality, string gender, string dateofbirth, string address)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.mobile = mobile;
            this.nationality = nationality;
            this.gender = gender;
            this.dateofbirth = dateofbirth;
            this.address = address;
        }
    }
}
