using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Admin.ViewModel
{
    public class GetVehicalCompanyies
    {
        public int Id { get; set; }
        public int? VehicalTypeId { get; set; }
        public string VehicalTypeName { get; set; }
        public string VehicalCompanyName { get; set; }
        public string isActive { get; set; }
        public string CreatedDate { get; set; }
    }
}
