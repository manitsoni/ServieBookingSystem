using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repository.Interface;
using Data.Model;
using BusinessEntities.ViewModel;
using Common;
namespace Data.Repository
{
    public class VehicalRepository : IVehicalRepository
    {
        ServiceManagementEntities db = new ServiceManagementEntities();
        public bool AddVehical(tblVehicalDetail vehicalDetail)
        {
            db.tblVehicalDetails.Add(vehicalDetail);
            return db.SaveChanges() > 0;
        }

        public IQueryable<tblVehicalCompany> GetTblVehicalCompaniesByTypeId(int VehicalTypeId)
        {
            return db.tblVehicalCompanies.Where(m=>m.VehicalTypeId == VehicalTypeId);
        }
        public List<GetVehicalDetails> GetVehicalDetails()
        {
            var VehicalList = (from Vehical in db.tblVehicalDetails
                               join User in db.tblUserRegistrations on Vehical.Userid equals User.Id
                               join Type in db.tblVehicalTypes on Vehical.VehicalTypeId equals Type.Id
                               join Company in db.tblVehicalCompanies on Vehical.VehicalCompanyId equals Company.Id
                               where Vehical.Userid == SessionProxyUser.UserID
                               select new GetVehicalDetails
                               {
                                   ChassisNo = Vehical.ChassisNo,
                                   CreatedDate = Vehical.CreatedDate.ToString(),
                                   isActive = Vehical.isActive.ToString(),
                                   Id = Vehical.Id,
                                   LicencePlateNo = Vehical.LicencePlateNo,
                                   OwnerName = Vehical.OwnerName,
                                   RegistrationDate = Vehical.RegistrationDate.ToString(),
                                   UpdatedOn = Vehical.UpdatedOn.ToString(),
                                   UserId = Vehical.Userid,
                                   VehicalCompanyId = Vehical.VehicalCompanyId,
                                   VehicalCompanyName = Company.VehicalCompanyName,
                                   VehicalName = Vehical.VehicalName,
                                   VehicalType = Type.VehicalType,
                                   VehicalTypeId = Vehical.VehicalTypeId
                               }
                               ).ToList();

            return VehicalList;
        }

        public IQueryable<tblVehicalType> GetVehicalType()
        {
            return db.tblVehicalTypes;
        }
    }
}
