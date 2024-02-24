using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

//Declarar Variables

internal class Program
{
    private static void Main(string[] args)
    {
        double X1, X2, Y1, Y2, Distance;

        // leer coordenadas

        Console.Write("Ingresar coordenada X1: ");
        Console.WriteLine();
        X1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresar coordenada X2: ");
        Console.WriteLine();
        X2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresar coordenada Y1: ");
        Console.WriteLine();
        Y1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresar coordenada Y2: ");
        Console.WriteLine();
        Y2 = Convert.ToInt32(Console.ReadLine());

        // calcular distacnia

        Distance = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));

        //Leer resultado
        Console.WriteLine("La distancia entre las coordenadas es.....: " + Math.Round(Distance, 4));




        static void Main(string[] args)
        {
            string aux;
            while (true)
            {
                try
                {
                    aux = Console.ReadLine();
                    num1 = Convert.ToInt32(aux);
                    Console.WriteLine();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Solo debe ingresar valores numerico: ");
                    //error = true;
                }
            }
        }
    }
}