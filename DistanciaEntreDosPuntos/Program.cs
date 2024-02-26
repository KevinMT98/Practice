using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.ObjectiveC;
using System.Runtime.Intrinsics.X86;

//Declarar Variables

internal class Program
{
    private static void Main(string[] args)
    {
        double X1, X2, Y1, Y2, Distance;
        string aux;

        // leer coordenadas

        while (true)
        {
            try
            {
                Console.Write("Ingrese la coordenada X1: ");
                aux = Console.ReadLine();
                X1 = Convert.ToInt32(aux);
                Console.WriteLine();
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine("Solo debe ingresar valores numerico: ");
                //error = true;
            }
        }

        while (true)
        {
            try
            {
                Console.Write("Ingrese la coordenada X2: ");
                aux = Console.ReadLine();
                X2 = Convert.ToInt32(aux);
                Console.WriteLine();
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine("Solo debe ingresar valores numerico: ");
                //error = true;
            }
        }

        while (true)
        {
            try
            {
                Console.Write("Ingrese la coordenada Y1: ");
                aux = Console.ReadLine();
                Y1 = Convert.ToInt32(aux);
                Console.WriteLine();
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine("Solo debe ingresar valores numerico: ");
                //error = true;
            }
        }

        while (true)
        {
            try
            {
                Console.Write("Ingrese la coordenada Y2:  ");
                aux = Console.ReadLine();
                Y2 = Convert.ToInt32(aux);
                Console.WriteLine();
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine("Solo debe ingresar valores numerico: ");
                //error = true;
            }
        }

        // calcular distacnia

        Distance = Math.Sqrt((Math.Pow(X2 - X1, 2)) + Math.Pow(Y2 - Y1, 2));

        //Leer resultado
        //Console.WriteLine("La distancia entre las coordenadas es.....: " + Math.Round(Distance, 4));

        //Otra forma mas optima de concatenar PARTIENDO DESDE LLAVES INICIANDO DESDE 0
        Console.WriteLine(string.Format("La distancia entre los pares ordenados ({0},{1}) y ({2},{3}) es = {4}", X2,Y1,Y2, Distance.ToString("N2")));

    }
}