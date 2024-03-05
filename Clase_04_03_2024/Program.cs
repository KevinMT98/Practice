//10.Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor,
//el del medio y el menor de los números ingresados.
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

        // validar los tres numeros

        if ((num1 > num2) && (num1 > num3))

        {
            Console.WriteLine("\n el numero mayor es " + num1);
            Console.WriteLine("\n el numero del medio es " + num2);
            Console.WriteLine("\n el numero menor es " + num3);
        }

        else if ((num2 > num1) && (num1 > num3))

        {
            Console.WriteLine("\n el numero mayor es " + num2);
            Console.WriteLine("\n el numero del medio es " + num1);
            Console.WriteLine("\n el numero menor es " + num3);
        }

        else if ((num3 > num2) && (num2 > num1))

        {
            Console.WriteLine("\n el numero mayor es " + num3);
            Console.WriteLine("\n el numero del medio es " + num2);
            Console.WriteLine("\n el numero menor es " + num1);
        }
         else 
            Console.WriteLine("valide bien");

    }
}