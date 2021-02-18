using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BusinessEntities.Admin.ViewModel
{
    public class VehicalTypeEntities
    {
        public int Id { get; set; }
        [Required]
        public string VehicalType { get; set; }
        public Boolean isActive { get; set; }
    }
}
