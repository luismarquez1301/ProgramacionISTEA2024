namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Ingrese el nombre");

            name = Console.ReadLine();

            name = name.ToUpper();

            Console.WriteLine(name);

            Console.ReadKey();
        }
    }
}
