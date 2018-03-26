using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1
{
    /*
	//Ejercicio 1
	//Realizar un programa de consola que permita ingresar el nombre y apellido por separado, con estos datos
	//debe imprimir un mensaje con el nombre completo.
	class Program
	{
		static void Main(string[] args)
		{
			string nombre;
			string apellido;

			Console.WriteLine("Ingrese su nombre");
			nombre =Console.ReadLine();
			Console.WriteLine("Ingrese su apellido");
			apellido = Console.ReadLine();

			Console.WriteLine("Su nombre completo es: " + nombre + " " + apellido);
			Console.Read();

		}
	}
	*/

    /*
	//Ejercicio 2
	//Realizar un programa de consola que permita ingresar el nombre y la edad, con estos datos debe imprimir
	//un mensaje diciendo si es mayor de edad o no.
	
	class Program
	{
		static void Main(string[] args)
		{
			string nombre;
			int edad;

			Console.WriteLine("Ingrese su nombre");
			nombre = Console.ReadLine();
			Console.WriteLine("Ingrese su edad");
			int.TryParse(Console.ReadLine(), out edad);

			if (edad >= 18)
			{
				Console.WriteLine("Usted es mayor de edad");
				Console.Read();
			}
			else
			{
				Console.WriteLine("Usted es menor de edad");
				Console.Read();
			}
		}
	}
	*/

    /*
	//Ejercicio 3
	//Realizar un programa de consola que permita ingresar un numero y calcule la suma de todos los numeros enteros anteriores
	
	class Program
	{
		static void Main(string[] args)
		{
			
		}
	}
	*/


    /*
	//Ejercicio 4
	//Realizar un programa de consola que permita ingresar 2 valores y encuentr el maximo comun divisor
	class Program
	{
		static void Main(string[] args)
		{
			int	valor1;
			int valor2;
			int mcd = 1;
            int max = 1;

            Console.WriteLine("Ingrese un numero entero");
			int.TryParse(Console.ReadLine(), out valor1);
			
			Console.WriteLine("Ingrese un numero entero");
			int.TryParse(Console.ReadLine(), out valor2);

            do
            {
                if (valor1 % max == 0 && valor2 % max == 0)
                {
                    mcd=max;
                }
                max++;

            } while (max <= (valor1 < valor2?valor1 : valor2));

            Console.WriteLine("El maximo común divisor de "+valor1+" y "+valor2+ " es "+mcd);
            Console.Read();
        }
	}
    */
    /*
    //Ejercicio 5
    //Realizar un programa de consola que permita ingresar numeros y que termine de pedir numeros cuando se
    //ingresa 0 y calcule el promedio de todos los ingresados
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int suma=0;
            int cant = 0;
            int promedio;
            do
            {
                Console.WriteLine("Ingrese un numero entero, si ingresa se acaba la aejecución" );
                int.TryParse(Console.ReadLine(), out numero);
                
                if (numero!= 0)
                {
                    suma = suma + numero;
                    cant++;

                }               

            } while (numero!=0);
            promedio = suma / cant;
            Console.WriteLine("El promedio "+" es " + promedio);
            Console.Read();
        }
    }
    */
}
