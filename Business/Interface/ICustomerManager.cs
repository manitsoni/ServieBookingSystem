using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.ViewModel;
namespace Business.Interface
{
    public interface ICustomerManager
    {
        bool AddCustomer(CustomerEntities customerEntities);
        int LoginUser(string Username, string Password);

        IList<CustomerEntities> BindToSession(int id);
        
    }
}
