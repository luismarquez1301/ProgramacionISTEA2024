namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sueldo;

            Console.WriteLine("Ingrese sueldo");

            sueldo = int.Parse(Console.ReadLine());

            if(sueldo <= 30000)
            {
                Console.WriteLine("Recibe aumento");
            }
            else
            {
                Console.WriteLine("No recibe aumento");
            }
        }
    }
}
