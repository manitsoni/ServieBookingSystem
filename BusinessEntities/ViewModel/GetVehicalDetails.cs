using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.ViewModel
{
    public class GetVehicalDetails
    {
        public int Id { get; set; }

        public int? UserId { get; set; }
      
        public int? VehicalTypeId { get; set; }
        public string VehicalType { get; set; }
        public int? VehicalCompanyId { get; set; }
        public string VehicalCompanyName { get; set; }
        public string VehicalName { get; set; }
        public string OwnerName { get; set; }
        public string RegistrationDate { get; set; }
        public string ChassisNo { get; set; }
        public string LicencePlateNo { get; set; }

        public string isActive { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedOn { get; set; }
    }
}
