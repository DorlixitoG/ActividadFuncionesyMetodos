namespace operacionesMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opc;
            do
            {
                Console.WriteLine();
                Console.WriteLine("----Menú----");
                Console.WriteLine("Elige una opcion \n" +
                    "a). Dividir \n" +
                    "b). Obtener cubo \n" +
                    "c). Calcula IMC \n" +
                    "d). Salir");
                opc = Console.ReadLine().ToLower();

                switch (opc)
                {
                    case "a":
                        dividir();
                        break;
                    case "b":
                        cubo();
                        break;
                    case "c":
                        Imc();
                        break;
                    default:
                        if (opc != "d") 
                        {
                            Console.WriteLine("error ingrese una opción válida");

                        }

                        break;
                            

                }


            }
            while (opc != "d");
            Console.WriteLine("Has salido del sistema");
        }
        static void dividir()
        {
            Console.WriteLine("Ingresa el dividendo: ");
            double dividendo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el divisor: ");
            double divisor = Convert.ToDouble(Console.ReadLine());

            if (divisor == 0)
            {
                Console.WriteLine("no se puede dividir entre 0");
            }
            else
            {
                double resultado = dividendo / divisor;
                Console.WriteLine("Su resultado es: " + resultado);
            }
        }
        static void cubo()
        {
            Console.WriteLine("Ingresa el numero base a potenciar: ");
            double num = Convert.ToDouble(Console.ReadLine());

            double resultado = Math.Pow(num, 3);

            Console.WriteLine("el resultado es: " + resultado);

        }
        static void Imc() 
        {
        Console.WriteLine("Ingresa el peso (KG): ");
        double peso = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("ingresa la altura (m): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double IMC = peso / (altura * altura);

            Console.WriteLine("Tu indice de masa muscular es de: "+IMC);
        }
    }
}