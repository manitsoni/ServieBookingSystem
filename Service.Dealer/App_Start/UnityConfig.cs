using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using Business.Admin;
using Business.Admin.Interface;
using Business.Repository_Helper;
namespace Service.Dealer
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IVehicalTypeManager, VehicalTypeManager>();
            container.RegisterType<IVehicalCompanyNameManager, VehicalCompanyNameManager>();
            container.RegisterType<ICustomerManagerA, CustomerManagerA>();
            container.RegisterType<IMechanicManager, MechanicManager>();
            container.AddNewExtension<UnityRepositoryHelper>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}