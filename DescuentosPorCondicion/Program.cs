// Cree un programa que solicite la siguiente información: Nombre, sexo, cantidad de hijos y monto total de compra. 
// En base a esa información, se debe realizar lo siguiente. Si el cliente es hombre y no tiene hijos,
// le debes aplicar un descuento de 2.5% al monto total de compra. Si tiene 1 a más hijos, 
// debes aplicarle un descuento de 5% al monto de compra. Si es mujer y no tiene hijo, 
// debe aplicarle 10% de descuento, si tiene 1 o 2, debes aplicar 15% de descuento 
// y si tiene 3 a más hijos, debes aplicar el 20% de descuento a la compra. 
// El programa debe imprimir «Señor», «Señorita» o «Señora» respectivamente y su nombre. 
// La mujer es señorita si no tiene hijos. Además debe imprimir el subtotal, 
// el descuento y el monto final de compra.
internal class Program
{
    private static void Main(string[] args)
    {
        string? nombre, apellido, sexo;
        double valorcompra, totalcompra, dctogral;
        double dcto1 = 2.5, dcto2 = 5.0, dcto3 = 10.0, dcto4 = 15.0, dcto5 = 20.0;
        int canthijos;

        Console.Write("Ingrese Nombre: ");
        Console.WriteLine();
        nombre = Console.ReadLine();

        Console.Write("Ingrese Apellidos: ");
        Console.WriteLine();
        apellido = Console.ReadLine();

        Console.Write("Ingrese sexo m/f: ");
        Console.WriteLine();
        sexo = Console.ReadLine();

        Console.Write("Ingrese cantidad hijos: ");
        Console.WriteLine();
        canthijos = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese valor compra: ");
        Console.WriteLine();
        valorcompra = Convert.ToDouble(Console.ReadLine());

        if ((sexo == "m" | sexo == "M") && (canthijos == 0))
        {
            dctogral = ((valorcompra * dcto1) / 100);
            totalcompra = valorcompra - dctogral;

            Console.WriteLine($"Señor {nombre} {apellido} El Subtotal de la compra es: {valorcompra.ToString("##,#0")} Y su dcto es del {dcto1} % " +
                $"Para un Total Compra {totalcompra.ToString("##,#0")} ");
        }

        else if ((sexo == "m" | sexo == "M") && (canthijos > 0))
        {
            dctogral = ((valorcompra * dcto2) / 100);
            totalcompra = valorcompra - dctogral;
            Console.WriteLine($"Señor {nombre} {apellido} El Subtotal de la compra es: {valorcompra.ToString("##,#0")} Y su dcto es del {dcto2} % " +
            $"Para un Total Compra {totalcompra.ToString("##,#0")} ");
        }
        else if ((sexo == "f" | sexo == "F") && (canthijos == 0))
        {
            dctogral = ((valorcompra * dcto3) / 100);
            totalcompra = valorcompra - dctogral;

            Console.WriteLine($"Señorita {nombre} {apellido} El Subtotal de la compra es: {valorcompra.ToString("##,#0")} Y su dcto es del {dcto3} % " +
            $"Para un Total Compra {totalcompra.ToString("##,#0")} ")
        }

        else if (((sexo == "f" | sexo == "F") && (canthijos > 0) && (canthijos < 2)))
        {
            dctogral = ((valorcompra * dcto4) / 100);
            totalcompra = valorcompra - dctogral;

            Console.WriteLine($"Señora {nombre} {apellido} El Subtotal de la compra es: {valorcompra.ToString("##,#0")} Y su dcto es del {dcto4} % " +
                $"Para un Total Compra {totalcompra.ToString("##,#0")} ");
        }
        else if ((sexo == "f" | sexo == "F") && (canthijos >=3))
        {
            dctogral = ((valorcompra * dcto5) / 100);
            totalcompra = valorcompra - dctogral;

            Console.WriteLine($"Señora {nombre} {apellido} El Subtotal de la compra es: {valorcompra.ToString("##,#0")} Y su dcto es del {dcto5} % " +
            $"Para un Total Compra {totalcompra.ToString("##,#0")} ");
        }
    }
}



