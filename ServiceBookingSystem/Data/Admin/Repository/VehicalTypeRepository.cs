using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Admin.Repository.Interface;
using Data.Model;
namespace Data.Admin.Repository
{
    public class VehicalTypeRepository : IVehicalTypeRepository
    {
        private ServiceManagementEntities db = new ServiceManagementEntities();
        public bool AddVehicalType(tblVehicalType vehicalType)
        {
            db.tblVehicalTypes.Add(vehicalType);
            return db.SaveChanges() > 0;
        }

        public IQueryable<tblVehicalType> GetVehicalTypes()
        {
            return db.tblVehicalTypes;
        }
    }
}
