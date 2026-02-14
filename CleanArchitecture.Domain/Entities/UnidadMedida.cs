using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class UnidadMedida : EntidadBase
    {
        [Required, MaxLength(20)]
        public string Codigo { get; set; } = default!; // UND, KG, LT

        [Required, MaxLength(80)]
        public string Nombre { get; set; } = default!;
    }
}
