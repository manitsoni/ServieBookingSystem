using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
using BusinessEntities.ViewModel;
namespace Data.Repository.Interface
{
    public interface IVehicalRepository
    {
        bool AddVehical(tblVehicalDetail vehicalDetail);
        IQueryable<tblVehicalType> GetVehicalType();
        IQueryable<tblVehicalCompany> GetTblVehicalCompaniesByTypeId(int VehicalTypeId);

        List<GetVehicalDetails> GetVehicalDetails();
    }
}
