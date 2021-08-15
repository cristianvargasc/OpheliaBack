using Database;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelo.Ophelia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOphelia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class OpheliaController : Controller
    {
        private readonly OpheliaContext productosContext;

        public OpheliaController(OpheliaContext productos)
        {
            productosContext = productos;
        }

        [HttpGet]
        [Route("Productos")]
        public IEnumerable<Productos> Get()
        {
            return productosContext.Productos.ToList();
        }

        [HttpGet]
        [Route("ProductosMin")]
        public IEnumerable<Productos> GetMin()
        {
            return productosContext.Productos.FromSqlRaw("EXEC	[dbo].[SP_Productos_Cantidad_Minima]").ToList();
        }

        [HttpGet]
        [Route("ProductosValorTotalAnio")]
        public IEnumerable<Productos> GetAnio()
        {
            return productosContext.Productos.FromSqlRaw("EXEC [dbo].[SP_Productos_Anio]").ToList();
        }

        [HttpGet]
        [Route("Clientes")]
        public IEnumerable<Clientes> GetClientes()
        {
            return productosContext.Clientes.FromSqlRaw("EXEC [dbo].[SP_Clientes]").ToList();
        }

        [HttpGet]
        [Route("ClientesEdadFecha")]
        public IEnumerable<Clientes> GetEdadFecha()
        {
            return productosContext.Clientes.FromSqlRaw("EXEC [dbo].[SP_Productos_Edad_Fecha]").ToList();            
        }

        [HttpGet]
        [Route("ClienteEstimado/{id_cliente}")]
        public IEnumerable<Estimado> GetEstimado()
        {
            var id_cliente = RouteData.Values["id_cliente"];
            return productosContext.Estimado.FromSqlRaw("EXECUTE [dbo].[SP_Productos_Estimado_Cliente] " + id_cliente).ToList();
        }
    }
}
