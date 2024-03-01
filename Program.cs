// 9. Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor de los números ingresados.
internal class Program
{
    public static void Main(string[] args)
    {
        double num1, num2, num3;
        string mensaje = "El numero mayor es: ";

        // pedir datos
        Console.Write("\n Ingrese el primer numero:  ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("\n Ingrese el segundo numero:  ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("\n Ingrese el segundo numero:  ");
        num3 = Convert.ToDouble(Console.ReadLine());

        // validar el numero mayor

        if (num1 > num2 && num1 > num3)

            Console.WriteLine($"\n {mensaje}" + num1);
        else

        if (num2 > num3)

            Console.WriteLine($"\n {mensaje}" + num2);
        else

            Console.WriteLine($"\n {mensaje}" + num3);


    }
}