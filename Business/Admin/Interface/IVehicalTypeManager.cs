using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Admin.ViewModel;
namespace Business.Admin.Interface
{
    public interface IVehicalTypeManager
    {
        List<VehicalTypeEntities> GetVehicalTypes();
        bool AddVehicalType(VehicalTypeEntities vehicalTypeEntities);
    }
}
