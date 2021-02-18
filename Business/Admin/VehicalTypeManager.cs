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
namespace Business.Admin
{
    public class VehicalTypeManager : IVehicalTypeManager
    {
        private IVehicalTypeRepository vehicalTypeRepository;
        public VehicalTypeManager(IVehicalTypeRepository vehicalType)
        {
            vehicalTypeRepository = vehicalType;
        }
        public bool AddVehicalType(VehicalTypeEntities vehicalTypeEntities)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<VehicalTypeEntities, tblVehicalType>());
            IMapper mapper = config.CreateMapper();
            var list = GetVehicalTypes().ToList();
            var VehicalTypeCheck = vehicalTypeEntities.VehicalType;
            bool isAvailable = false;
            foreach (var item in list)
            {
                if (VehicalTypeCheck == item.VehicalType)
                {
                    isAvailable = true;
                    break;
                }
                
            }
            if (isAvailable == false)
            {
                tblVehicalType tblVehicalType = mapper.Map<VehicalTypeEntities, tblVehicalType>(vehicalTypeEntities);
                return vehicalTypeRepository.AddVehicalType(tblVehicalType);
            }
            else
            {
                return false;
            }
           
        }

        public List<VehicalTypeEntities> GetVehicalTypes()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<tblVehicalType, VehicalTypeEntities>());
            IMapper mapper = config.CreateMapper();
            var vehicaltype = vehicalTypeRepository.GetVehicalTypes().ToList();
            List<VehicalTypeEntities> vehicalTypeEntities = vehicaltype.Select(x => mapper.Map<tblVehicalType, VehicalTypeEntities>(x)).ToList();
            return vehicalTypeEntities;
        }
    }
}
