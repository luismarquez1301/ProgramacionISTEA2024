namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textVar = "Políglota";

            textVar = textVar.Replace('á', 'a')
                             .Replace('é', 'e')
                             .Replace('ú', 'u')
                             .Replace('í', 'i')
                             .Replace('ó', 'o');


            Console.WriteLine(textVar);
            Console.ReadKey();
        }
                                   
    }
}
