using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6Clases.ProductosServices
{
    public class MercadLibreService : IProductoService
    {
        public List<string> ObtenerProductos()
        {
            return new List<string>
            {
                "Producto 1 ML",
                "Producto 2 ML",
                "Producto 3 ML"
            };
        }
    }
}