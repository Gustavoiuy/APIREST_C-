// See https://aka.ms/new-console-template for more information


using _8Exceptions;
using _8Exceptions.Exceptions;

PagoService pagoService = new PagoService();
try
{
    pagoService.Realizar(50, "JUAN");
}
catch (MontoSuperadoException ex)
{
    // mando email a juan y dile que no se puede pagar importes > 100
    Console.WriteLine($"Esta es nuestra exception: {ex.StackTrace}");
}
catch(SinSaldoException ex)
{
    // mando email a juan y dile que no tien saldo
    Console.WriteLine($"SIn saldo exception: {ex.StackTrace}");
}
catch (Exception ex)
{
    // manda wasap al aministraodr
    Console.WriteLine("Ha ocurrido un error: " + ex.Message + ex.StackTrace);

}


