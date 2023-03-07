using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PARCIAL__1_PROGRAMACIÓN_1.negocio;
using PARCIAL__1_PROGRAMACIÓN_1.entidades;

namespace PARCIAL__1_PROGRAMACIÓN_1.entidades;

    public class venta
    {
   
    public int IdProducto { get; set; }
    public string NombreProducto { get; set; }
    public string DescripcionProducto { get; set; }
    public decimal PrecioProducto { get; set; }
    public int CantidadProducto { get; set; }
    }

