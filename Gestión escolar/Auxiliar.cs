using System;
using System.Collections.Generic;
using System.Text;

namespace Gestión_escolar
{
    internal class Auxiliar : Persona
    {
        public Auxiliar(string nombre, string apellido, string dni, string email, string contraseña)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Email = email;
            Contraseña = contraseña;
        }
    }
}
