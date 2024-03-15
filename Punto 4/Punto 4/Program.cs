namespace Punto_4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese el valor de x:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de n:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La progresión es:");
            ImprimirProgresion(x, n);

            int resultado = CalcularProgresion(x, n);
            Console.WriteLine("El resultado de la progresión es: " + resultado);
        }

        static void ImprimirProgresion(int x, int n)
        {
            Console.Write("1 "); 

            int potencia = 1;
            for (int i = 1; i <= n; i++)
            {
                potencia *= x; 
                Console.Write("+" + potencia + " "); 
            }
            Console.WriteLine(); 
        }

        static int CalcularProgresion(int x, int n)
        {
            int suma = 1; 
            int potencia = 1;

            for (int i = 1; i <= n; i++)
            {
                potencia *= x; 
                suma += potencia; 
            }

            return suma;
        }
    }
}
