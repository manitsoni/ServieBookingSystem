using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.ViewModel;
namespace Business.Interface
{
    public interface IServiceBookingManager
    {
        bool AddServices(ServiceEntities service);

        IList<GetServices> GetServices(int id);

        IList<GetVehicalDetails> GetVehicals(int id);
    }
}
