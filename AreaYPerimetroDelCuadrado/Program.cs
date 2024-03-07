//Cree un programa que solicite al usuario el lado de un cuadrado. 
//    Luego le debe pedir una opción al usuario, si elige 1, le debe mostrar el perímetro del cuadrado, 
//    si elige 2, le debe mostrar el área del cuadrado.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Desea calcular el area o el perimetro del cuadrado? 1 = area, 2 = perimetro ");
        Console.WriteLine();
        string? metodo = Console.ReadLine();

        if (metodo == "1")
        {
            AreaDelCuadrado();
        }
        else
        {
            PerimetroDelCuadrado();
        }

        static void AreaDelCuadrado()

        {
            double lado, area;
            Console.Write("Ingrese un lado del cuadrado ");
            Console.WriteLine();
            lado = Convert.ToDouble(Console.ReadLine());

            area = (lado * lado);

            Console.Write("El area del cuadrado es " + area.ToString("#,##0"));
            Console.WriteLine();
        }
        static void PerimetroDelCuadrado()
        {
            double lado, perimetro;
            Console.Write("Ingrese un lado del cuadrado ");
            Console.WriteLine();
            lado = Convert.ToDouble(Console.ReadLine());

            perimetro = (lado * 4);

            Console.Write($"El perimetro del cuadrado es {perimetro}");
            Console.WriteLine();
        }

    }
}
