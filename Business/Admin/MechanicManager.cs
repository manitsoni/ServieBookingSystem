using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Admin.ViewModel;
using Data.Admin.Repository;
using Data.Repository;
using Data.Admin;
using Data.Model;
using Data.Admin.Repository.Interface;
using AutoMapper;
using Business.Admin.Interface;

namespace Business.Admin
{
    public class MechanicManager : IMechanicManager
    {
        private IManageMechanicRepository manageMechanicRepository;
        public MechanicManager(IManageMechanicRepository mechanicRepository)
        {
            manageMechanicRepository = mechanicRepository;
        }
        public bool AddMechanic(MechanicEntities mechanicEntities)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<MechanicEntities, tblMechanic>());
            IMapper mapper = config.CreateMapper();
            var list = GetMechanics().ToList();
            var MechanicName = mechanicEntities.MechanicName;
            var Email = mechanicEntities.Email;
            bool isAvailable = false;
            foreach (var item in list)
            {
                if (item.MechanicName == MechanicName && item.Email == Email)
                {
                    isAvailable = true;
                    break;
                }
            }
            if (isAvailable == false)
            {
                tblMechanic mechanic = mapper.Map<MechanicEntities, tblMechanic>(mechanicEntities);
                return manageMechanicRepository.AddMechanic(mechanic);
            }
            else
            {
                return isAvailable;
            }
        }
        public IList<MechanicEntities> GetMechanics()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<tblMechanic, MechanicEntities>());
            IMapper mapper = config.CreateMapper();
            var mechanics = manageMechanicRepository.GetMechanics().ToList();
            List<MechanicEntities> getMechanics = mechanics.Select(x => mapper.Map<tblMechanic, MechanicEntities>(x)).ToList();
            return getMechanics;
        }
    }
}
