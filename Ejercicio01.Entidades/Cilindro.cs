using System.Text;

namespace Ejercicio01.Entidades
{
    public class Cilindro
    {
        public int Radio { get; }
        public int Altura { get; }
        private double Diametro;
        public Cilindro(int radio, int altura)
        {
            if (radio <= 0 || altura <= 0)
            {
                throw new ArgumentException("Datos no válidos");
            }
            Radio = radio;
            Altura = altura;
            CalcularDiametro();

        }

        private void CalcularDiametro()
        {
            Diametro = Radio * 2;
        }
        public double GetArea()
        {
            return 2 * Math.PI * Radio * (Radio + Altura);
        }

        public double GetVolumen() => Math.PI * Math.Pow(Radio, 2) * Altura;
        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cilindro");
            sb.AppendLine($"\tRadio:{Radio}");
            sb.AppendLine($"\tAltura:{Altura}");
            sb.AppendLine($"\tDiametro:{Diametro}");
            sb.AppendLine($"\tÁrea:{GetArea()}");
            sb.AppendLine($"\tVolumen:{GetVolumen()}");
            return sb.ToString();
        }
    }
}
