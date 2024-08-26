using Ejercicio03.Entidades;

namespace Ejercicio03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metro metro = new Metro(10);
            Yarda yarda = new Yarda(5);

            Console.WriteLine($"Metro: {metro.GetLongitud} metros");
            Console.WriteLine($"Yarda: {yarda.GetLongitud} yardas");

            Yarda convertidaDeMetro = (Yarda)metro;
            Metro convertidaDeYarda = (Metro)yarda;

            Console.WriteLine($"\nConversiones:");
            Console.WriteLine($"{metro.GetLongitud} metros son {convertidaDeMetro.GetLongitud} yardas");
            Console.WriteLine($"{yarda.GetLongitud} yardas son {convertidaDeYarda.GetLongitud} metros");

        }
    }
}
