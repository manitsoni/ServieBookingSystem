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
    public class VehicalManager : IVehicalManager
    {

        private IVehicalRepository vehicalRepository;
        public VehicalManager(IVehicalRepository vehical)
        {
            vehicalRepository = vehical;
        }
        public bool AddVehical(VehicalEntities vehicalEntities)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<VehicalEntities, tblVehicalDetail>());
            IMapper mapper = config.CreateMapper();
            var list = GetVehicalDetails().ToList();
            var ChassisNo = vehicalEntities.ChassisNo;
            var LicenceNo = vehicalEntities.LicencePlateNo;
            var ModelName = vehicalEntities.VehicalName;
            int? Type = vehicalEntities.VehicalTypeId;
            int? Company = vehicalEntities.VehicalCompanyId;
            bool isAvailable = false;
            foreach (var item in list)
            {
                if (ChassisNo == item.ChassisNo && LicenceNo == item.LicencePlateNo && ModelName == item.VehicalName && Type == item.VehicalTypeId && Company == item.VehicalCompanyId)
                {
                    isAvailable = true;
                    break;
                }
            }
            if (isAvailable == false)
            {
                tblVehicalDetail vehicalDetail = mapper.Map<VehicalEntities, tblVehicalDetail>(vehicalEntities);
                return vehicalRepository.AddVehical(vehicalDetail);
            }
            else
            {
                return false;
            }
          
        }

        public List<VehicalCompanyEntities> GetVehicalCompaniesByVehicalType(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<tblVehicalCompany, VehicalCompanyEntities>());
            IMapper mapper = config.CreateMapper();
            var vehicaltype = vehicalRepository.GetTblVehicalCompaniesByTypeId(id).ToList();
            List<VehicalCompanyEntities> vehicalCompanyEntities = vehicaltype.Select(x => mapper.Map<tblVehicalCompany, VehicalCompanyEntities>(x)).ToList();
            return vehicalCompanyEntities;
        }

        public List<GetVehicalDetails> GetVehicalDetails()
        {
            return vehicalRepository.GetVehicalDetails().ToList();
        }

        public List<VehicalTypeEntities> GetVehicalType()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<tblVehicalType, VehicalTypeEntities>());
            IMapper mapper = config.CreateMapper();
            var vehicaltype = vehicalRepository.GetVehicalType().ToList();
            List<VehicalTypeEntities> vehicalTypeEntities = vehicaltype.Select(x => mapper.Map<tblVehicalType, VehicalTypeEntities>(x)).ToList();
            return vehicalTypeEntities;
        }
    }
}
