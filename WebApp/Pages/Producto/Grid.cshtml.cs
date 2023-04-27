using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;

namespace WebApp.Pages.Producto
{
    public class GridModel : PageModel
    {
        private readonly IProductoService productosService;

        public GridModel(IProductoService productosService)
        {
            this.productosService = productosService;
        }

        public IEnumerable<ProductosEntity> GridList { get; set; } = new List<ProductosEntity>();

        public string Mensaje { get; set; } = "";
        // METODO QUE LISTA PRODUCTOS EN EL GRID
        public async Task<IActionResult> OnGet()
        {
            try
            {
                GridList = await productosService.GetListProductos();

                if (TempData.ContainsKey("Msg"))
                {
                    Mensaje = TempData["Msg"] as string;
                }

                TempData.Clear();

                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }
    }
}
