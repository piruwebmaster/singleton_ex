using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    public class OperacionesAritmeticas
    {
        private static OperacionesAritmeticas operaciones = null;
        private OperacionesAritmeticas() { }
        public static OperacionesAritmeticas GetInstance()
        {
            if (operaciones == null)
            {
                operaciones = new OperacionesAritmeticas();
            }
            return operaciones;
        }

        public int sumar(int x, int y)
        {
            return x + y;
        }
        public int restar(int x, int y)
        {
            return x - y;
        }
        public int multiplicar(int x, int y)
        {
            return x * y;
        }
        public double dividir(double x, double y)
        {
            return x / y;
        }
    }

}
