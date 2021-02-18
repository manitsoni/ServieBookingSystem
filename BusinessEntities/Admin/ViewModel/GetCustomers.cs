using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Admin.ViewModel
{
    public class GetCustomers
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string  FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Addressline1 { get; set; }
        public string Addressline2 { get; set; }
        public long Pincode { get; set; }
        public string Phone { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedOn { get; set; }
        
    }
}
