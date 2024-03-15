namespace Punto_5
{
    internal class Program
    {
        static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el límite de la serie Fibonacci:");
        int limite;
        while (!int.TryParse(Console.ReadLine(), out limite) || limite < 1)
        {
            Console.WriteLine("Ingrese un número válido mayor que cero.");
        }

        Console.WriteLine("Serie Fibonacci hasta el número " + limite + ":");
        for (int i = 0; i < limite; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;
        else if (n == 1)
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    }
}
