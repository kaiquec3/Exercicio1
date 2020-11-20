using System;

namespace AreaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Retangulo();
            double k;

            do
            {
                Console.Write("Informe a base do retângulo: ");
                k = double.Parse(Console.ReadLine());

                if (k > 0) a1.SetBase(k);
            }
            while (k <= 0);

            do
            {
                Console.Write("Informe a altura do retângulo: ");
                k = double.Parse(Console.ReadLine());

                if (k > 0) a1.SetAltura(k);
            }
            while (k <= 0);

            Console.WriteLine($"A área do retângulo é igual a {a1.CalcularArea()}");



        }
    }
}
