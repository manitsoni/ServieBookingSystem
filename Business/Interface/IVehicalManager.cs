using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.ViewModel;
using BusinessEntities.Admin.ViewModel;
namespace Business.Interface
{
    public interface IVehicalManager
    {
        bool AddVehical(VehicalEntities vehicalEntities);
        List<VehicalTypeEntities> GetVehicalType();
        List<GetVehicalDetails> GetVehicalDetails();
        List<VehicalCompanyEntities> GetVehicalCompaniesByVehicalType(int id);
    }
}
