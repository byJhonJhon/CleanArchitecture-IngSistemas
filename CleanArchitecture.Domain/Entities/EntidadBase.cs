using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class EntidadBase
    {
        [Key]
        public int Id { get; set; }
        public bool Activo { get; set; } = true;
        public bool Eliminado { get; set; } = false;
        public DateTime FechaDeCreacion { get; set; } = DateTime.Now;
        // nullable = puede ser nulo
        public DateTime? FechaDeActualizacion { get; set; }
    }
}
