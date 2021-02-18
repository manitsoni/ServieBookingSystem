using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
namespace Data.Repository.Interface
{
    public interface ICustomerRepository
    {
        bool AddCustomer(tblUserRegistration userRegistration);

        bool CheckUser(string Username, string Email);

        int LoginUser(string Username, string Password);

        IQueryable<tblUserRegistration> BindToSession(int id);
    }
}
