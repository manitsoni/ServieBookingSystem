using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
namespace Data.Admin.Repository.Interface
{
    public interface IManageMechanicRepository
    {
        bool AddMechanic(tblMechanic mechanic);

        IQueryable<tblMechanic> GetMechanics();
    }
}
