using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Operaciones
    {
        public bool IsNUmeric(string num)
        {
            try
            {
                double x = Convert.ToInt32(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public int resta(int a, int b)
        {
            return a - b;
        }

        public int multiplicacion(int a, int b)
        {
            return a * b;
        }

        public int division(int a, int b)
        {
            return a / b;
        }

    }
}

   

