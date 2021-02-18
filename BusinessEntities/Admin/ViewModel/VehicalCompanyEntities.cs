using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Admin.ViewModel
{
    public class VehicalCompanyEntities
    {
        public int Id { get; set; }
        public int? VehicalTypeId { get; set; }
        public string VehicalCompanyName { get; set; }
        public Boolean isActive { get; set; }
        public DateTime CreatedDate { get; set; }

        public string VehicalType { get; set; }
    }
}
