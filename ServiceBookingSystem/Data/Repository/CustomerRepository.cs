using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repository.Interface;
using Data.Model;
namespace Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private ServiceManagementEntities db = new ServiceManagementEntities();
        public bool AddCustomer(tblUserRegistration UserRegistration)
        {
            db.tblUserRegistrations.Add(UserRegistration);
            return db.SaveChanges() > 0;
        }

        public bool CheckUser(string Username, string Email)
        {
            var UserList = db.tblUserRegistrations.ToList();
            bool isAvailable = false;
            foreach (var item in UserList)
            {
                if (item.Username == Username && item.Email == Email)
                {
                    isAvailable = true;
                    break;
                }
            }
            return isAvailable;
        }

        public IQueryable<tblUserRegistration> BindToSession(int id)
        {
            return db.tblUserRegistrations.Where(m => m.Id == id);
        }

        public int LoginUser(string Username, string Password)
        {
            var UserList = db.tblUserRegistrations.ToList();
            int UserId = 0;
            foreach (var item in UserList)
            {
                if (item.Username == Username && item.Password == Password)
                {
                    UserId = item.Id;
                    break;
                }
            }
            return UserId;
        }
    }
}
