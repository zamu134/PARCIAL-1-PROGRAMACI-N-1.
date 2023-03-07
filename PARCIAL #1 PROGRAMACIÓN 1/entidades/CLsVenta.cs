using PARCIAL__1_PROGRAMACIÓN_1.negocio;
using PARCIAL__1_PROGRAMACIÓN_1.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARCIAL__1_PROGRAMACIÓN_1.entidades;

    
 public class ClsVenta
{
    public decimal Cobro(venta venta)
    {
        decimal precioTotal = venta.PrecioProducto * venta.CantidadProducto;

        if (precioTotal > 50)
        {
            precioTotal -= 10;
            Console.WriteLine($"Precio original: {precioTotal + 10:C}");
            Console.WriteLine($"Precio con descuento: {precioTotal:C}");
        }

        Console.WriteLine($"Total a pagar: {precioTotal:C}");
        return precioTotal;
    }
}
