internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingresar año ");
        double ano = Convert.ToDouble(Console.ReadLine());

        if (ano % 4 != 0)
        {
            Console.WriteLine($"No es bisiesto {ano}");
        }
        else if (ano % 100 != 0) 
        {
            Console.WriteLine($"Es bisiesto {ano}");
        }
        else if (ano % 400!= 0) 
        {
            Console.WriteLine($"No es bisiesto {ano}");
        }
    }
}