using System;

namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor em R$: ");
            string valor = Console.ReadLine();
            decimal valorConvertido = 0.0m;
            decimal valorCambio = 0.1932m;

            decimal.TryParse(valor, out valorConvertido);

            decimal valorCambioConvertido = valorConvertido * valorCambio;

            Console.WriteLine($"Valor convertido: {valorCambioConvertido}");
            Console.ReadLine();
        }
    }
}
