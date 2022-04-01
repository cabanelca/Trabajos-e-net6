// See https://aka.ms/new-console-template for more information
static void CalcularIva(int numero)
{
    double resultado;
    resultado = numero * 1.21;
    Console.WriteLine("El valor final es " + (resultado));
    Console.ReadLine();
}
Console.WriteLine("Ingrese un Monto de producto ");
CalcularIva(int.Parse(Console.ReadLine()));
