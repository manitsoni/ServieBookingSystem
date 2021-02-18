using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Admin.ViewModel
{
    public class VCompanyEntities
    {
        public int Id { get; set; }
        public Nullable<int> VehicalTypeId { get; set; }
        public string VehicalCompanyName { get; set; }
        public Nullable<bool> isActive { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }

    }
}
