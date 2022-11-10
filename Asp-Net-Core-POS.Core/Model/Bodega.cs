using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp_Net_Core_POS.Core.Model
{
    public class Bodega : EntityBase
    {
        [Required]
        [MaxLength(50)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }
        [Required]
        public bool Estado { get; set; }
    }
}
