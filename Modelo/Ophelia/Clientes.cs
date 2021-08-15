using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Modelo.Ophelia
{
    public class Clientes
    {
        [Key]
        public Int64 id_cliente { get; set; }
        public string nombre { get; set; }        
        public string fecha_nacimiento { get; set; }
        public string correo { get; set; }
        public Int64 telefono { get; set; }
    }
}
