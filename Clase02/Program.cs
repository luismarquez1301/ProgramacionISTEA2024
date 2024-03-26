using System;
namespace Clase02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadHrs, valorHrs, sueldoMes;

            Console.WriteLine("Ingrese cantidad de horas");
            cantidadHrs = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la hora");
            valorHrs = int.Parse(Console.ReadLine());

            sueldoMes = cantidadHrs * valorHrs;

            Console.WriteLine($"El obrero cobrará por {cantidadHrs} horas trabajadas la cantidad de $$${sueldoMes} dolares");

            Console.ReadKey();  
            

        }
    }
}
//string nombre, apellido;

//Console.WriteLine("Ingrese el nombre");
//nombre = Console.ReadLine();
//Console.WriteLine("Su nombre es: ");
//Console.WriteLine(nombre);

//Console.WriteLine("Ingrese el apellido");

//apellido = Console.ReadLine();

//Console.WriteLine("Su apellido es: ");
//Console.WriteLine(apellido);
//Console.ReadKey();
//---------------------------------------
//string cadena1 = "golfa";
//string cadena2 = "puta";
//Console.WriteLine("La cadena uno dice {1} y la cadena 2 dice {0}", cadena1, cadena2);



//string variable1 = "Luis";
//string variable2 = "Vzla";
//Console.WriteLine($"Hola a todos, me llamo {variable1} y soy de {variable2}");
//Console.ReadKey();

//-------------------------------------
//int edad;
//int sumarAnios = 10;
//int resultado;
////Ingreso
//Console.WriteLine("Ingrese la edad");
//edad = int.Parse(Console.ReadLine());


////Proceso
//edad = edad + sumarAnios;
//resultado = 35 + 48;

////Salida de datos
//Console.WriteLine(edad);
//Console.WriteLine(resultado);

//resultado = 35 * (48 + 1);

//Console.WriteLine(resultado);

//Console.ReadKey();
//----------------------------
////Declaración de variables
//string nombre;
//int edad;
//int sumarAnios;

//// Ingreso ed datos
//Console.WriteLine("Ingrese el nombre: ");
//nombre = Console.ReadLine();

//Console.WriteLine("Ingrese la edad: ");
//edad = int.Parse(Console.ReadLine());


//// Salida de Datos
//Console.WriteLine(nombre);
//Console.WriteLine(edad);


//Console.WriteLine("Presione cualquier tecla para continuar");
//Console.ReadKey();