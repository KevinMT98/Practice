// 8.	Construir un programa que pida un número y luego diga si este número es par o no

internal class Program
{
    private static void Main(string[] args)
    {
        double num;
        string mensaje = " es par!! ", aux;

        while (true)
        {
            try
            {
                Console.Write("Ingrese el primero numero: ");
                aux = Console.ReadLine();
                num = Convert.ToInt32(aux);
                Console.WriteLine();
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine("Solo debe ingresar valores numerico: ");
                //error = true;
            }
        }

        {

            if ((num % 2) == 0)
            {
                Console.WriteLine(string.Format("\n Si {0}", mensaje));

            }
            else
                Console.WriteLine(string.Format("\n No {0}", mensaje));

        }
    }
}
