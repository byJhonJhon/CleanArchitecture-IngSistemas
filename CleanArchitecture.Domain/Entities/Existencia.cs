using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class Existencia : EntidadBase
    {
        public int ProductoId { get; set; }
        public Producto Producto { get; set; } = default!;

        public int AlmacenId { get; set; }
        public Almacen Almacen { get; set; } = default!;

        public int CantidadDisponible { get; set; }
        public int CantidadReservada { get; set; }
        public int CantidadEntrante { get; set; }
        public int CantidadSaliente { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal CostoPromedio { get; set; }
    }
}
