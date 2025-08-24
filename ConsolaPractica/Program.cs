// See https://aka.ms/new-console-template for more information


// El usuario podrá elegir una operación (suma, resta, multiplicación, división) y luego ingresar dos números para obtener el resultado.

using System;

public class Calculadora
{
    public static void Main(string[] args)
    {
        int opcion = 0;

        while (opcion != 5)
        {
            Console.WriteLine("\n==== Calculadora Simple ====");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            Console.Write("Ingrese la opción: ");

            opcion = int.Parse(Console.ReadLine());
            double resultado = 0;
            bool operacionValida = true;
            double n1 = 0;
            double n2 = 0;
            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el primer número: ");
                     n1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                     n2 = double.Parse(Console.ReadLine());

                    resultado = n1 + n2;
                    Console.WriteLine("El resultado es: " + resultado);
                    break;

                case 2:
                    Console.Write("Ingrese el primer número: ");
                    n1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    n2 = double.Parse(Console.ReadLine());

                    resultado = n1 - n2;
                    Console.WriteLine("El resultado es: " + resultado);
                    break;

                case 3:
                    Console.Write("Ingrese el primer número: ");
                    n1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    n2 = double.Parse(Console.ReadLine());

                    resultado = n1 * n2;
                    Console.WriteLine("El resultado es: " + resultado);
                    break;

                case 4:
                    Console.Write("Ingrese el primer número: ");
                    n1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    n2 = double.Parse(Console.ReadLine());
                    if (n2 != 0)
                    {
                        resultado = n1 / n2;
                        Console.WriteLine("El resultado es: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre 0.");
                    }
                    break;

                case 5:
                    Console.WriteLine("Gracias por usar la calculadora.");
                    break;

                default:
                    Console.WriteLine("Elige una opción válida.");
                    break;
            }
        }
    }
}

