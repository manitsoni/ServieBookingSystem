using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BusinessEntities.ViewModel
{
    public class VehicalEntities
    {
        public int Id { get; set; }

        public int? UserId { get; set; }
        [Required]
        public int? VehicalTypeId { get; set; }
        [Required]
        public int? VehicalCompanyId { get; set; }
        [Required]
        public string VehicalName { get; set; }
        [Required]
        public string OwnerName { get; set; }
        [Required]
        public DateTime RegistrationDate { get; set; }
        [Required]
        public string ChassisNo { get; set; }
        [Required]
        public string LicencePlateNo { get; set; }

        public Boolean isActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
