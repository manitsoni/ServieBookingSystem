using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Admin.ViewModel;
using BusinessEntities.Admin.DropDown;
namespace Business.Admin.Interface
{
    public interface IVehicalCompanyNameManager
    {
        List<GetVehicalCompanyies> GetVehicalCompanyies();
        List<VehicalTypeEntities> GetVehicalTypeListForDDs();
        bool AddVehicalCompanyName(VCompanyEntities vehicalCompanyEntities);
    }
}
