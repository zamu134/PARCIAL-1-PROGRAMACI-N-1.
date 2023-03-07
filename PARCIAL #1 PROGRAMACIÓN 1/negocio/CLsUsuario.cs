using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARCIAL__1_PROGRAMACIÓN_1.negocio;

    public class ClsUsuario
{
    private Usuario usuario = new Usuario { Nombre = "TU_NOMBRE", Contra = "123" };

    public bool Acceso(string nombre, string contra)
    {
        return (nombre == usuario.Nombre && contra == usuario.Contra);
    }
}