using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using Business;
using Business.Interface;
using Business.Admin;
using Business.Admin.Interface;
using Business.Repository_Helper;
namespace Service.Customer
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ICustomerManager, CustomerManager>();
            container.RegisterType<IVehicalTypeManager, VehicalTypeManager>();
            container.RegisterType<IVehicalManager, VehicalManager>();
            container.RegisterType<IServiceBookingManager, ServiceBookingManager>();
            container.AddNewExtension<UnityRepositoryHelper>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}