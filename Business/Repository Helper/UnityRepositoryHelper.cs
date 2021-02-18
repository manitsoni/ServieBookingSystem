using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Extension;
using Data.Repository;
using Data.Repository.Interface;
using Data.Admin.Repository;
using Data.Admin.Repository.Interface;
namespace Business.Repository_Helper
{
    public class UnityRepositoryHelper : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<ICustomerRepository, CustomerRepository>();
            Container.RegisterType<IVehicalTypeRepository, VehicalTypeRepository>();
            Container.RegisterType<IVehicalRepository, VehicalRepository>();
            Container.RegisterType<IManageCustomerRepository, ManageCustomerRepository>();
            Container.RegisterType<IVehicalCompanyNameRepository, VehicalCompanyNameRepository>();
            Container.RegisterType<IManageMechanicRepository, ManageMechanicRepository>();
            Container.RegisterType<IServiceBookingRepository, ServiceBookingRepository>();
        }
    }
}
