using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using static Mysqlx.Crud.Order.Types;

namespace Gestión_escolar
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }

    }

}
    

