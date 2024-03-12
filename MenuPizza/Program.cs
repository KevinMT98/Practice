internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("\n Bienvenido a Pizzeria Bella Napoliiii ");
        Console.WriteLine();
        Console.Write("\n Desea una pizza vegetariana? si/no ");
        Console.WriteLine();
        String? respuesta = Console.ReadLine();
       
        if (respuesta == "si")
        {
            MenuVegetariano();
        }
        else if (respuesta == "no")
        {
            MenuNovegetariano();
        }
    }

    //=============================================================//
        static void MenuVegetariano()
    {
        Console.WriteLine("\n Elegir un solo ingredinte: ");
        Console.WriteLine("\n 1: Tofu....: ");
        Console.WriteLine("\n 2: Pimiento: ");
        Console.WriteLine();
        string? ingrediente = Console.ReadLine();

        if (ingrediente == "1")
        {
            Console.WriteLine("\n Su pizza es vegetariana y Sus ingredintes son: Mozzarella - Tomate - Tofu");
        }
        else
        {
            Console.WriteLine("\n Su pizza es vegetariana y Sus ingredintes son: Mozzarella - Tomate - Pimiento");
        }
    }

    static void MenuNovegetariano()
    {
        Console.WriteLine("\n Elegir un solo ingredinte: ");
        Console.WriteLine("\n 1: Peperoni: ");
        Console.WriteLine("\n 2: Jamón...: ");
        Console.WriteLine("\n 3: Salmón..: ");
        string? ingrediente = Console.ReadLine();
        Console.WriteLine();

        if (ingrediente == "1")
        {
            Console.WriteLine("\n Su pizza no es vegetariana y Sus ingredintes son: Mozzarella - Tomate - Peperoni");
        }
        else if (ingrediente == "2")
        {
            Console.WriteLine("\n Su pizza no es vegetariana y Sus ingredintes son: Mozzarella - Tomate - Jamón");
        }
        else
        {
            Console.WriteLine("\n Su pizza no es vegetariana y Sus ingredintes son: Mozzarella - Tomate - Salmón");
        }
    }
}
