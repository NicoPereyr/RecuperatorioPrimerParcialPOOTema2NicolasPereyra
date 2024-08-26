using Ejercicio01.Entidades;

namespace Ejercicio01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Cilindros!");
            Cilindro c = new Cilindro(2, 5);
            Console.WriteLine(c.GetInfo());
        }
    }
}
