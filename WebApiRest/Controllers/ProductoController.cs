using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBL;

namespace WebApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService productoService;

        public ProductoController(IProductoService productoService)
        {
            this.productoService = productoService;
        }
        // CONTROLADOR QUE LISTA LOS PRODUCTOS
        [HttpGet("GetListProductos")]
        public async Task<IEnumerable<ProductosEntity>> GetListProductos()
        {
            try
            {
                return await productoService.GetListProductos();
            }
            catch (Exception ex)
            {

                return new List<ProductosEntity>();
            }
        }
        // CORNTROLADOR QUE INSERTA LA INFORMACION DE LOS PRODUCTOS
        [HttpPost]
        public async Task<DBEntity> CreateProductos(ProductosEntity entity)
        {
            try
            {
                return await productoService.CreateProductos(entity);
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }
    }
}
