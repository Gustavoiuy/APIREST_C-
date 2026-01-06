// clases 

using System.Reflection.PortableExecutable;
using _6Clases;
using _6Clases.ProductosServices;

//AbstractVehiculo vehiculo = new AbstractVehiculo()
/*
Coche coche = new Coche("BMW", "M3", 50000,300);
coche.Acelerar();
coche.Acelerar();

coche.Acelerar();
Console.WriteLine(coche);

coche.Frenar();
Console.WriteLine(coche);

AbstractVehiculo cocheDeportivo = new CocheDeportivo("Audi", "R8", 300000, 700);
cocheDeportivo.Acelerar();
cocheDeportivo.Acelerar();
cocheDeportivo.Acelerar();

Console.WriteLine(cocheDeportivo);
cocheDeportivo.TocarBocina();


AbstractVehiculo camion = new Camion("Mercedes Benz", "1114", 100000, 200);
camion.Acelerar();
camion.Acelerar();
camion.Acelerar();

Console.WriteLine(camion);
camion.TocarBocina();
*/

IProductoService service = new MercadLibreService();
var productos = service.ObtenerProductos();

Console.WriteLine("fin");


