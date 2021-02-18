using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Admin.Repository.Interface;
using Data.Model;
using BusinessEntities.Admin.ViewModel;
using BusinessEntities.Admin.DropDown;

namespace Data.Admin.Repository
{
    public class VehicalCompanyNameRepository : IVehicalCompanyNameRepository
    {
        private ServiceManagementEntities db = new ServiceManagementEntities();
        public bool AddVehicalCompanyName(tblVehicalCompany vehicalCompany)
        {
            db.tblVehicalCompanies.Add(vehicalCompany);
            return db.SaveChanges() > 0;
        }

        public IQueryable<tblVehicalType> GetVehicalTypeDropDown()
        {
            return db.tblVehicalTypes;
        }

        //public IQueryable<tblVehicalCompany> GetTblVehicalCompanies()
        //{
        //    //var name = (from objVcomp in db.tblVehicalCompanies
        //    //            join objVtype in db.tblVehicalTypes on objVcomp.VehicalTypeId equals objVtype.Id
        //    //            select new GetVehicalCompanyies
        //    //            {
        //    //                Id = objVcomp.Id,
        //    //                CreatedDate = objVcomp.CreatedDate.ToString(),
        //    //                isActive = objVcomp.isActive.ToString(),
        //    //                VehicalCompanyName = objVcomp.VehicalCompanyName,
        //    //                VehicalTypeName = objVtype.VehicalType
        //    //            }).ToList();
        //    //return (IQueryable<tblVehicalCompany>)name;
        //    return db.tblVehicalCompanies;
        //}

        List<GetVehicalCompanyies> IVehicalCompanyNameRepository.GetTblVehicalCompanies()
        {
            var vc = (from objVcomp in db.tblVehicalCompanies
                      join objVtype in db.tblVehicalTypes on objVcomp.VehicalTypeId equals objVtype.Id
                      select new GetVehicalCompanyies
                      {
                          Id = objVcomp.Id,
                          CreatedDate = objVcomp.CreatedDate.ToString(),
                          isActive = objVcomp.isActive.ToString(),
                          VehicalCompanyName = objVcomp.VehicalCompanyName,
                          VehicalTypeName = objVtype.VehicalType,
                          VehicalTypeId = objVcomp.VehicalTypeId
                      }).ToList();
            return vc;
        }

      
    }
}
