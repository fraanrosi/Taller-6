using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string cadena;
            string primero ="";
            string segundo;
            string operador="";
            int total=0;
            int auxiliar;
            Console.WriteLine("ingrese una cuenta");
            cadena = Console.ReadLine();

            foreach (var item in cadena)
            {
                
                if (int.TryParse(item.ToString(), out int numero))
                {

                    if (operador == ""){
                        primero = primero + item.ToString();
                    }
                    
                    
                }
                else
                {
                    operador = item.ToString();
                   

                }
                
            }
            /*Console.WriteLine("ingrese su apellido");
            apellido = Console.ReadLine();
            */

        }
    }
}
