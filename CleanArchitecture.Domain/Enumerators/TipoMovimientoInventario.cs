using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Enumerators
{
    public enum TipoMovimientoInventario
    {
        EntradaCompra = 1,
        SalidaVenta = 2,
        EntradaTraslado = 3,
        SalidaTraslado = 4,
        Ajuste = 5,
        DevolucionEntrada = 6,
        DevolucionSalida = 7
    }
}
