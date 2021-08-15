using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modelo.Ophelia
{
    public class Productos
    {
        [Key]
        public Int64 id_producto { get; set; }
        public string nombre { get; set; }
        public Int64 precio { get; set; }
        public int cantidad { get; set; }
    }
}
