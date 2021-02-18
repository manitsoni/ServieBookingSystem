using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Admin.Repository.Interface;
using Data.Model;
namespace Data.Admin.Repository
{
    public class ManageMechanicRepository : IManageMechanicRepository
    {
        private ServiceManagementEntities db = new ServiceManagementEntities();
        public bool AddMechanic(tblMechanic mechanic)
        {
            db.tblMechanics.Add(mechanic);
            return db.SaveChanges() > 0;
        }

        public IQueryable<tblMechanic> GetMechanics()
        {
            return db.tblMechanics;
        }
    }
}
