internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n Ingrese las notas del estudiante: ");
        double nota1, nota2, nota3, nota4, nota5, promedio;

        Console.Write("\n ingrese la nota numero 1: ");
        Console.WriteLine();
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("\n ingrese la nota numero 2: ");
        Console.WriteLine();
        nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("\n ingrese la nota numero 3: ");
        Console.WriteLine();
        nota3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("\n ingrese la nota numero 4: ");
        Console.WriteLine();
        nota4 = Convert.ToDouble(Console.ReadLine());

        Console.Write("\n ingrese la nota numero 5: ");
        Console.WriteLine();
        nota5 = Convert.ToDouble(Console.ReadLine());

        promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

        Console.Write("\n El promedio es: " + promedio.ToString("#,##0"));
        Console.WriteLine();

        if (promedio < 3.00)

            Console.Write("\n El estudiando reprobó la asignatura ");

        else
        {
            Console.WriteLine("\n El estudiante aprobó la asignatura ");
            Console.WriteLine();
        }
    }
}