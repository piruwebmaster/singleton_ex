using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 2;
            double a = 12, b = 5;

            OperacionesAritmeticas operacion = OperacionesAritmeticas.GetInstance();

            Console.WriteLine(string.Format("{0} + {1} = {2}", x, y, operacion.sumar(x, y)));
            Console.WriteLine(string.Format("{0} - {1} = {2}", x, y, operacion.restar(x, y)));
            Console.WriteLine(string.Format("{0} * {1} = {2}", x, y, operacion.multiplicar(x, y)));
            Console.WriteLine(string.Format("{0} / {1} = {2}", x, y, operacion.dividir(a, b)));

            Console.Read();
        }
    }
}
