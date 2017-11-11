using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la medida de un lado de tu cubo");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("El area de tu cubo es: A=6*("+ l +"^2)=" + (6 * (l*l)));
            Console.ReadKey();

        }
    }
}


