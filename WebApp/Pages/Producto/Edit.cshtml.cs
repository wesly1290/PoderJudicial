using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebApp.Pages.Producto
{
    public class EditModel : PageModel
    {
        private readonly IProductoService productoService;

        public EditModel(IProductoService productoService)
        {
            this.productoService = productoService;
        }



        [BindProperty]
        // SE DECLARA LA ENTIDAD DEL PRODUCTO 
        public ProductosEntity Entity { get; set; } = new ProductosEntity();

        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {

            try
            {
                // VALIDA LA EXITENCIA DE UN ID
                if (Entity.producto_id == null)
                {
                    //Nuevo 
                    var result = await productoService.CreateProductos(Entity);

                    if (result.CodeError != 0) throw new Exception(result.MsgError);
                    TempData["Msg"] = "Se agregó correctamente";

                }

                return RedirectToPage("Grid");
            }



            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }

    }
}
