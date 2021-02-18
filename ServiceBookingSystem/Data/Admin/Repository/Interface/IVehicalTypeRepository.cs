using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Admin.ViewModel;
using Data.Model;
namespace Data.Admin.Repository.Interface
{
    public interface IVehicalTypeRepository
    {
        IQueryable<tblVehicalType> GetVehicalTypes();
        bool AddVehicalType(tblVehicalType vehicalType);
    }
}
