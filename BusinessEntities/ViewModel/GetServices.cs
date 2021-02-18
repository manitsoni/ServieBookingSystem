using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.ViewModel
{
    public class GetServices
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string VehicalName { get; set; }
        public string PlateNo { get; set; }
        public string MechanicName { get; set; }
        public int MechanicId { get; set; }
        public string ServiceName { get; set; }
        public decimal? Price { get; set; }
        public string BookingDate { get; set; }
        public Boolean? IsBooked { get; set; }
        public Boolean? IsAssigned { get; set; }
        public Boolean? IsCompleted { get; set; }
        public string CompletedDate { get; set; }
    }
}
