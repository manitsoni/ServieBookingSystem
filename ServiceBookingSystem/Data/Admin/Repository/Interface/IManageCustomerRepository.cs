using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
using BusinessEntities.Admin.ViewModel;
namespace Data.Admin.Repository.Interface
{
    public interface IManageCustomerRepository
    {
        IQueryable<tblUserRegistration> GetCustomers();
    }
}
