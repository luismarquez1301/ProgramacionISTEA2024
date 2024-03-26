namespace Ejerciicio_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v1, v2, r1, r2;

            Console.WriteLine("Ingrese valor 1");
            v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valor 2");
            v2 = double.Parse(Console.ReadLine());

            r1 = v1 * v2;
            r2 = v2 + v1;

            if (v1 < v2){
                Console.WriteLine("El valor mayor es: " + v2);
            } else if (v1 > v2){
                Console.WriteLine("El valor mayor es: " + v1);
            } else {
                Console.WriteLine("A lo mejo son iguales pichita");
            }

            Console.WriteLine("El producto de ambos es: " + r1 + "\n Y la suma de ambos es: " + r2);


        }
    }
}
