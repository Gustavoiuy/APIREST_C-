using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6Clases.ProductosServices
{

    public class AmazonService : IProductoService
    {
        public List<string> ObtenerProductos()
        {
            return new List<string>
            {
                "Producto 1",
                "Producto 2",
                "Producto 3"
            };
        }
    }
}