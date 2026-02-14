using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class Proveedor : EntidadBase
    {
        [Required, MaxLength(200)]
        public string Nombre { get; set; } = default!;

        [MaxLength(60)]
        public string? IdentificacionFiscal { get; set; }

        [MaxLength(120)]
        public string? Email { get; set; }

        [MaxLength(40)]
        public string? Telefono { get; set; }

        [MaxLength(300)]
        public string? Direccion { get; set; }
    }
}
