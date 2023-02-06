using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ecuaciones_líneas_de_primer_grado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce los coeficientes de la ecuación de la forma ax + b = 0");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());//Convierte la representación en forma de cadena de un número en el número de punto flotante de precisión doble equivalente
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            switch (a) //selecciona una lista de instrucciones para ejecutarse en función de una coincidencia de patrón con una expresión
            {
                case 0:
                    if (b == 0) //La instrucción if controla la bifurcación condicional
                    {
                        Console.WriteLine("La ecuación tiene infinitas soluciones");
                    }
                    else //El cuerpo de una instrucción if se ejecuta si el valor de la expresión es distinto de cero
                    {
                        Console.WriteLine("La ecuación no tiene solución");
                    }
                    break;//si se cumple se sale de la funcion. 
                default:
                    double x = -b / a;
                    Console.WriteLine("La solución de la ecuación es x = " + x);
                    break;
            }
            Console.ReadLine(); //imprimir en pantalla el resultado
        }
    }
}