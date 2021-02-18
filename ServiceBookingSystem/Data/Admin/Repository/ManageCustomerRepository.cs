using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Admin.ViewModel;
using Data.Admin.Repository.Interface;
using Data.Model;
namespace Data.Admin.Repository
{
    public class ManageCustomerRepository : IManageCustomerRepository
    {

        private ServiceManagementEntities db = new ServiceManagementEntities();
        public IQueryable<tblUserRegistration> GetCustomers()
        {
            return db.tblUserRegistrations;
        }
    }
}
