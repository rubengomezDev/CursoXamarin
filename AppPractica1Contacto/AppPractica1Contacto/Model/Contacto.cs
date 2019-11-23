using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLitePCL;

namespace AppPractica1Contacto.Model
{
    public class Contacto
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
    }
}
