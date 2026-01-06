// See https://aka.ms/new-console-template for more information

using System.Globalization;
using _7Ficheros;
using CsvHelper;

LeerFicheroAsTxt("empleados.csv");

List<Empleado> empleados = LeerFicheroCsvClase("empleados.csv");

List<Empleado> empleadosFromCsvHelper = LeerFicheroConCsvHelper("empleados.csv");

Console.WriteLine("Fin");


static void LeerFicheroAsTxt(string ruta)
{
    using (StreamReader reader = new StreamReader(ruta))
    {
        bool primeraLinea = true;
        while (!reader.EndOfStream)
        {
            string linea = reader.ReadLine()!;

            if (primeraLinea)
            {
                primeraLinea = false;
                continue;
            }

            // 
            string[] partes = linea.Split(',');

            Console.WriteLine($"Nombre: {partes[0]}, Edad: {partes[1]}, Salario: {partes[2]}, Puesto: {partes[3]}");
        }
    }
}

static List<Empleado> LeerFicheroCsvClase(string ruta)
{
    List<Empleado> empleados = new List<Empleado>();

    using (StreamReader reader = new StreamReader(ruta))
    {
        bool primeraLinea = true;
        while (!reader.EndOfStream)
        {
            string linea = reader.ReadLine()!;

            if (primeraLinea)
            {
                primeraLinea = false;
                continue;
            }

            // 
            string[] partes = linea.Split(',');

            if (partes.Length == 4)
            {
                Empleado empleado = new Empleado()
                {
                    Nombre = partes[0],
                    Edad = int.Parse(partes[1]),
                    Salario = decimal.Parse(partes[2]),
                    Puesto = partes[3]
                };
                empleados.Add(empleado);
            }
        }
    }

    return empleados;
}



static List<Empleado> LeerFicheroConCsvHelper(string ruta)
{
    using (var reader = new StreamReader(ruta))
    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
    {
        var registros = csv.GetRecords<Empleado>();
        return new List<Empleado>(registros);
    }
}