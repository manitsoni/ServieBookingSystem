using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Admin.Interface;
using BusinessEntities.Admin.ViewModel;
using Data.Admin.Repository;
using Data.Repository;
using Data.Admin;
using Data.Model;
using Data.Admin.Repository.Interface;
using AutoMapper;
using BusinessEntities.Admin.DropDown;
namespace Business.Admin
{
    public class CustomerManagerA : ICustomerManagerA
    {
        private IManageCustomerRepository manageCustomerRepository;
        public CustomerManagerA(IManageCustomerRepository customerRepository)
        {
            manageCustomerRepository = customerRepository;
        }
        public List<GetCustomers> GetCustomers()
        {
           
            var config = new MapperConfiguration(cfg => cfg.CreateMap<tblUserRegistration, GetCustomers>());
            IMapper mapper = config.CreateMapper();
            var customer = manageCustomerRepository.GetCustomers().ToList();
            List<GetCustomers> getCustomers = customer.Select(x => mapper.Map<tblUserRegistration, GetCustomers>(x)).ToList();
            return getCustomers;
        }
    }
}
