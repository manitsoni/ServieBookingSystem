using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
using BusinessEntities.Admin.ViewModel;
using BusinessEntities.Admin.DropDown;
namespace Data.Admin.Repository.Interface
{
    public interface IVehicalCompanyNameRepository
    {
        //IQueryable<tblVehicalCompany> GetTblVehicalCompanies();
        bool AddVehicalCompanyName(tblVehicalCompany vehicalCompany);

        List<GetVehicalCompanyies> GetTblVehicalCompanies();

        IQueryable<tblVehicalType> GetVehicalTypeDropDown();
    }
}
