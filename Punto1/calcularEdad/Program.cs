namespace calcularEdad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calcularAño();
        }
        static void calcularAño()
        {
            Console.WriteLine("Ingresa el año actual: ");
            int añoActual = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el año de nacimiento: ");
            int añoNacimiento = Convert.ToInt32(Console.ReadLine());

            int calcularEdad = añoActual - añoNacimiento;

            Console.WriteLine("Su edad es: "+calcularEdad);
        }
    }
}
