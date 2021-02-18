using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repository.Interface;
using Data.Model;
using BusinessEntities.ViewModel;

namespace Data.Repository
{
    public class ServiceBookingRepository : IServiceBookingRepository
    {
        ServiceManagementEntities db = new ServiceManagementEntities();
        public bool AddService(tblService service)
        {
            db.tblServices.Add(service);
            return db.SaveChanges() > 0;
        }

        public IList<GetServices> GetServices(int id)
        {
            var Services = (from sb in db.tblServices
                            join vd in db.tblVehicalDetails on sb.VehicalId equals vd.Id
                            join ud in db.tblUserRegistrations on sb.Userid equals ud.Id
                            where sb.Userid == id
                            select new GetServices
                            {
                                Id = sb.Id,
                                BookingDate = sb.BookingDate.ToString(),
                                CompletedDate = sb.CompletedDate.ToString(),
                                IsAssigned = sb.IsAssigned,
                                IsBooked  = sb.IsBooked,
                               IsCompleted  = sb.IsCompleted,
                                PlateNo = vd.LicencePlateNo,
                                UserName = ud.Username,
                                VehicalName = vd.VehicalName,
                                ServiceName = sb.ServiceName,
                                Price = sb.Price

                            }).ToList();
            return Services;
        }

        public IQueryable<tblVehicalDetail> GetVehicalDetails(int id)
        {
            return db.tblVehicalDetails.Where(m => m.Userid == id);
        }
    }
}
