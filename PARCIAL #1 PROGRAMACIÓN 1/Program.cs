using PARCIAL__1_PROGRAMACIÓN_1.negocio;
using PARCIAL__1_PROGRAMACIÓN_1.entidades;


class Program
{
    static void Main(string[] args)
    {
        ClsUsuario negocioUsuario = new ClsUsuario();
        ClsVenta negocioVenta = new ClsVenta();
        Usuario usuario = new Usuario();
        venta venta = new venta();

        Console.WriteLine("Ingrese su usuario: ");
        usuario.Nombre = Console.ReadLine();

        Console.WriteLine("Ingrese su contraseña: ");
        usuario.Contra = Console.ReadLine();

        if (negocioUsuario.Acceso(usuario.Nombre, usuario.Contra))
        {
            Console.WriteLine("Inicio de sesión correcto. Puede continuar con el proceso de venta.");

            Console.WriteLine("Ingrese el identificador del producto: ");
            venta.IdProducto = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del producto: ");
            venta.NombreProducto = Console.ReadLine();

            Console.WriteLine("Ingrese la descripción del producto: ");
            venta.DescripcionProducto = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del producto: ");
            venta.PrecioProducto = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad del producto: ");
            venta.CantidadProducto = int.Parse(Console.ReadLine());

            decimal totalVenta = negocioVenta.Cobro(venta);

            Console.WriteLine($"Datos del producto vendido:");
            Console.WriteLine($"Identificador: {venta.IdProducto}");
            Console.WriteLine($"Nombre: {venta.NombreProducto}");
            Console.WriteLine($"Descripción: {venta.DescripcionProducto}");
            Console.WriteLine($"Precio: {venta.PrecioProducto:C}");
            Console.WriteLine($"Cantidad: {venta.CantidadProducto}");
            Console.WriteLine($"Total de venta: {totalVenta:C}");
        }
        else
        {
            Console.WriteLine("Usuario y/o contraseña incorrectos.");
        }

        Console.ReadKey();
    }
}
