using System;

namespace Punto_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de n:");
            int n = int.Parse(Console.ReadLine());

            double resultado = CalcularSerie(n, out string serie);

            Console.WriteLine("La serie es: " + serie);
            Console.WriteLine("El resultado de la serie es: " + resultado);
        }

        static double CalcularSerie(int n, out string serie)
        {
            double suma = 0;
            serie = ""; 

            for (int i = 1; i <= n; i++)
            {
                double termino = (double)i / Math.Pow(2, i); 
                if (i % 2 == 0)
                {
                    termino *= -1;
                }
                suma += termino; 

                serie += termino.ToString();
                if (i < n)
                    serie += " + ";
            }

            return suma;
        }
    }
}
