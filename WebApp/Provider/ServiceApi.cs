using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApp
{
    public class ServiceApi
    {
        private readonly HttpClient client;

        public ServiceApi(HttpClient client)
        {
            this.client = client;
        }

        #region Producto
        public async Task<IEnumerable<ProductosEntity>>GetListProductos()
        {
            var result = await client.ServicioGetAsync<IEnumerable<ProductosEntity>>("api/Producto/GetListProductos");

            return result;

        }
        #endregion

    }
}
