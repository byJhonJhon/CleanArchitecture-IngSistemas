using CleanArchitecture.Domain.Enumerators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class MovimientoInventario : EntidadBase
    {
        public TipoMovimientoInventario Tipo { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; } = default!;
        public int AlmacenId { get; set; }
        public Almacen Almacen { get; set; } = default!;

        // Positivo = entrada | Negativo = salida
        public int Cantidad { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal CostoUnitario { get; set; }

        [MaxLength(400)]
        public string? Observaciones { get; set; }

        public string? TipoReferencia { get; set; }
        public string? NumeroReferencia { get; set; }
    }
}
