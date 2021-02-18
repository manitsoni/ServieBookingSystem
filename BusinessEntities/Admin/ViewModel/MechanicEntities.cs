using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Admin.ViewModel
{
    public class MechanicEntities
    {
        public int Id { get; set; }
        [Required]
        public string MechanicName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public Boolean IsActive { get; set; }
    }
}
