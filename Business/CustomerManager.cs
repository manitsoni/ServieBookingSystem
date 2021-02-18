using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interface;
using BusinessEntities.ViewModel;
using Data.Model;
using Data.Repository.Interface;
using AutoMapper;
using Common;
namespace Business
{
    public class CustomerManager : ICustomerManager
    {
        private ICustomerRepository customerRepository;
        public CustomerManager(ICustomerRepository customer)
        {
            customerRepository = customer;
        }
        public bool AddCustomer(CustomerEntities customerEntities)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CustomerEntities, tblUserRegistration>());
            IMapper mapper = config.CreateMapper();
            bool isAvailable = customerRepository.CheckUser(customerEntities.Username, customerEntities.Email);
            if (isAvailable == true)
            {
                return false;
            }
            else
            {
                tblUserRegistration userRegistration = mapper.Map<CustomerEntities, tblUserRegistration>(customerEntities);
                return customerRepository.AddCustomer(userRegistration);

            }


        }

        public IList<CustomerEntities> BindToSession(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<tblUserRegistration, CustomerEntities>());
            IMapper mapper = config.CreateMapper();
            var vehicaltype = customerRepository.BindToSession(id).ToList();
            List<CustomerEntities> UserLists = vehicaltype.Select(x => mapper.Map<tblUserRegistration, CustomerEntities>(x)).ToList();
            foreach (var item in UserLists)
            {
                SessionProxyUser.IsUserLogin = true;
                SessionProxyUser.UserID = item.Id;
                SessionProxyUser.UserEmail = item.Email;
                SessionProxyUser.FirstName = item.Firstname;
                SessionProxyUser.MiddleName = item.Middlename;
                SessionProxyUser.LastName = item.Lastname;
                SessionProxyUser.Name = item.Username;
                SessionProxyUser.Address1 = item.Addressline1;
                SessionProxyUser.Address2 = item.Addressline2;
                SessionProxyUser.City = item.City;
                SessionProxyUser.State = item.State;
                SessionProxyUser.Country = item.Country;
                SessionProxyUser.Pincode = item.Pincode.ToString();
                SessionProxyUser.Phone = item.Mobileno;
                break;
            }
            return UserLists;
        }

        public int LoginUser(string Username, string Password)
        {
            int UserId = customerRepository.LoginUser(Username, Password);
            return UserId;
        }
    }
}
