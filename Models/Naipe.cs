using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Baraja2_juangonzales.Models
{
    public class Naipe
    {
        [Key]
        public string NaipeId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        public string Nombre { get; set; }

        [Url]
        [StringLength(1000, MinimumLength = 1, ErrorMessage = "La longitud de {0} debe estar entre {2} y {1}")]
        public string ImagenUrl { get; set; }
    }
}
