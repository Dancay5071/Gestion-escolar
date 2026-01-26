using System;
using System.Collections.Generic;
using System.Text;
using Gestión_escolar;


namespace Gestión_escolar
{
    internal class Docente : Persona
    {
        public string Legajo { get; set; }
    
        public Docente(string nombre, string apellido, string dni, string email, string contraseña) 
        {   
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Email = email;
            Contraseña = contraseña;                                                        
        }

        

    }
}
