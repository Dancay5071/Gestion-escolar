using System;
using System.Collections.Generic;
using System.Text;

namespace Gestión_escolar
{
    internal class Directivo_Administrativo : Persona
    {
        public Directivo_Administrativo(string nombre, string apellido, string dni, string email, string contraseña)
        {
            Nombre= nombre;
            Apellido = apellido;
           DNI = dni;
            Email = email;
            Contraseña = contraseña;
        }
    }
}
