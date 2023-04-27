using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    // CLASE DE ATRIBUTOS DEL PRODUCTO
    public class ProductosEntity: EN
    {
        public int? producto_id { get; set; }
        public string descripcion { get; set; }
        public string tipo { get; set; }
        public string tipo_precio { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
    }
}
