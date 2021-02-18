using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.ViewModel
{
    public class ServiceEntities
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public int VehicalId { get; set; }
        public int MechanicId { get; set; }
        public decimal? Price { get; set; }
        public string ServiceName { get; set; }
        public DateTime BookingDate { get; set; }
        public Boolean? IsBooked { get; set; }
        public Boolean? IsAssigned { get; set; }
        public Boolean? IsCompleted { get; set; }
        public DateTime CompletedDate { get; set; }
        public Boolean IsActive { get; set; }
    }
}
