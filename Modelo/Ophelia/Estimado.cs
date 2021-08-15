using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modelo.Ophelia
{
    public class Estimado
    {
        [Key]
        public Int64 id_venta { get; set; }
        public Int64 id_cliente { get; set; }
        public string nombre { get; set; }
        public string ultima_fecha { get; set; }
        public string estimado_fecha { get; set; }
    }
}
