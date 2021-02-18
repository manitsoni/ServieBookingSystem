using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
using BusinessEntities.ViewModel;
namespace Data.Repository.Interface
{
   public  interface IServiceBookingRepository
    {
        bool AddService(tblService service);
        IList<GetServices> GetServices(int id);
        IQueryable<tblVehicalDetail> GetVehicalDetails(int id);
    }
}
