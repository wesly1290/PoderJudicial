using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    // INTERFASE DE MANTENIMIENTO DE PRODUCTOS
    public interface IProductoService
    {
        Task<DBEntity> CreateProductos(ProductosEntity entity);
        Task<IEnumerable<ProductosEntity>> GetListProductos();
    }

    public class ProductoService : IProductoService
    {
        private readonly IDataAccess sql;

        public ProductoService(IDataAccess _sql)
        {
            sql = _sql;
        }
        // METODO QUE RETORNA LA LISTA DE LOS PRODUCTOS 
        public async Task<IEnumerable<ProductosEntity>> GetListProductos()
        {
            try
            {
                // LECTURA DEL PROCEDIMIENTO ALMACENADO
                var result = sql.QueryAsync<ProductosEntity>("get_list_producto");

                return await result;
            }
            catch (Exception EX)
            {

                throw;
            }
        }
        // METODO QUE INSERTA LA INFORMACION DEL PRODUCTO
        public async Task<DBEntity> CreateProductos(ProductosEntity entity)
        {
            try
            {
                // LECTURA DEL PROCEDIMIENTO ALMACENADO
                var result = sql.ExecuteAsync("insert_producto", new
                {
                    // INSERTA CADA UNO DE LOS ATRIBUTOS DEL PRODUCTO
                    entity.descripcion,
                    entity.tipo,
                    entity.tipo_precio,
                    entity.cantidad,
                    entity.precio
                });

                return await result;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
