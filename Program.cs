using System;
using POO_Estatico.Classes;

namespace POO_Estetico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor monetário: ");
            Conversor.valorUsuario1 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Dólar -> Real: {Conversor.ConverterDolarParaReal()}");
            Console.WriteLine($"Real -> Dólar: {Conversor.ConverterRealParaDolar()}");
            Console.WriteLine();

            Console.WriteLine("Digite um valor monetário: ");
            Conversor.valorUsuario2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Euro -> Real: {Conversor.ConverterEuroParaReal()}");
            Console.WriteLine($"Real -> Euro: {Conversor.ConverterRealParaEuro()}");
        }
    }
}
