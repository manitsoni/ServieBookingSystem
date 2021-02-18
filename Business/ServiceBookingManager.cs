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
using BusinessEntities.Admin.ViewModel;

namespace Business
{
    public class ServiceBookingManager : IServiceBookingManager
    {
        private IServiceBookingRepository serviceBookingRepository;
        public ServiceBookingManager(IServiceBookingRepository service)
        {
            serviceBookingRepository = service;
        }
        public bool AddServices(ServiceEntities service)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ServiceEntities, tblService>());
            IMapper mapper = config.CreateMapper();
            tblService services = mapper.Map<ServiceEntities, tblService>(service);
            return serviceBookingRepository.AddService(services);
        }

        public IList<GetServices> GetServices(int id)
        {
            return serviceBookingRepository.GetServices(id).ToList();
        }

        public IList<GetVehicalDetails> GetVehicals(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<tblVehicalDetail, GetVehicalDetails>());
            IMapper mapper = config.CreateMapper();
            var vehicalDetails = serviceBookingRepository.GetVehicalDetails(id).ToList();
            List<GetVehicalDetails> vehicles = vehicalDetails.Select(x => mapper.Map<tblVehicalDetail, GetVehicalDetails>(x)).ToList();
            return vehicles;
        }
    }
}
