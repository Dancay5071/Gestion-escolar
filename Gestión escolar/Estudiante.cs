using System;
using System.Collections.Generic;
using System.Text;

namespace Gestión_escolar
{
    internal class Estudiante : Persona
    {
        public string Curso { get; set; }
        public string División { get; set; }
        public Estudiante(string nombre, string apellido, string dni, string email, string contraseña)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Email = email;
            Contraseña = contraseña;
        }
    }
}
