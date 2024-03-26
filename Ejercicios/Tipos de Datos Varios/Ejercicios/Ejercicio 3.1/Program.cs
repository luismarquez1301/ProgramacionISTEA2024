namespace Ejercicio_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Ingrese un valor");
            num = int.Parse(Console.ReadLine());

            if (num >= 150 && num <= 300)
            {
                Console.WriteLine("Numero ingresado invalido, no puede encontrarse entre 150 y 300");
            }
            else
            {
                Console.WriteLine("Numero valido");
            }


        }
    }
}
