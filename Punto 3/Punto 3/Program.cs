using System;

namespace Punto_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el radio (r): ");
            double radio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el ángulo en grados: ");
            double grados = Convert.ToDouble(Console.ReadLine());

            double x, y;
            ConvertirCoordenadas(radio, grados, out x, out y);

            Console.WriteLine("Las coordenadas rectangulares son:");
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);

            Console.ReadLine();
        }

        static void ConvertirCoordenadas(double radio, double grados, out double x, out double y)
        {
            double angulosrAdianes = GradosARadianes(grados);

            x = radio * Math.Cos(angulosrAdianes);
            y = radio * Math.Sin(angulosrAdianes);
        }

        static double GradosARadianes(double grados)
        {
            return grados * Math.PI / 180.0;
        }
    }
}
