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

namespace Business.Admin.Interface
{
    public class VehicalCompanyNameManager : IVehicalCompanyNameManager
    {
        private IVehicalCompanyNameRepository vehicalCompanyNameRepository;
        public VehicalCompanyNameManager(IVehicalCompanyNameRepository vehicalCompany)
        {
            vehicalCompanyNameRepository = vehicalCompany;
        }
        public bool AddVehicalCompanyName(VCompanyEntities vehicalCompanyEntities)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<VCompanyEntities, tblVehicalType>());
            IMapper mapper = config.CreateMapper();
            var list = GetVehicalCompanyies().ToList();
            var VehicalCompany = vehicalCompanyEntities.VehicalCompanyName;
            var TypeId = vehicalCompanyEntities.VehicalTypeId;
            bool isAvailable = false;
            foreach (var item in list)
            {
                if (VehicalCompany == item.VehicalCompanyName && TypeId == item.VehicalTypeId)
                {
                    isAvailable = true;
                    break;
                }
            }
            if (isAvailable == false)
            {
                tblVehicalCompany vehicalCompany = mapper.Map<VCompanyEntities, tblVehicalCompany>(vehicalCompanyEntities);
                return vehicalCompanyNameRepository.AddVehicalCompanyName(vehicalCompany);
            }
            else
            {
                return false;
            }
        }

        public List<GetVehicalCompanyies> GetVehicalCompanyies()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<tblVehicalCompany, GetVehicalCompanyies>());
            IMapper mapper = config.CreateMapper();
            var vehicalCompanyname = vehicalCompanyNameRepository.GetTblVehicalCompanies().ToList();
            //List<GetVehicalCompanyies> getVehicalCompanyies = vehicalCompanyname.Select(x => mapper.Map<tblVehicalCompany, GetVehicalCompanyies>(x)).ToList();
            return vehicalCompanyname;
        }

        public List<VehicalTypeEntities> GetVehicalTypeListForDDs()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<tblVehicalType, VehicalTypeEntities>());
            IMapper mapper = config.CreateMapper();
            var vehicaltype = vehicalCompanyNameRepository.GetVehicalTypeDropDown().ToList();
            List<VehicalTypeEntities> vehicalTypeEntities = vehicaltype.Select(x => mapper.Map<tblVehicalType, VehicalTypeEntities>(x)).ToList();
            return vehicalTypeEntities;
        }
    }
}
