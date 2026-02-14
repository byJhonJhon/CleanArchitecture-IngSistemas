using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class Almacen : EntidadBase
    {
        [Required, MaxLength(120)]
        public string Nombre { get; set; } = default!;

        [MaxLength(250)]
        public string? Ubicacion { get; set; }

        public ICollection<Existencia> Existencias { get; set; } = new List<Existencia>();
    }
}
