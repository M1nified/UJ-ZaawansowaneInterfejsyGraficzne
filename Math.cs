using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calc
{
    class Math
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public int Substract(int a, int b)
        {
            return a - b;
        }
        public double Substract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            return a / b;
        }
        private string DeriviateSingle(int a, int exp) // a*x^exp
        {
            var newA = a * exp;
            var newExp = exp - 1;
            return "" + newA + "x^" + newExp;
        }
        private string Deriviate(string func)
        {
            //2x^2+x+4
            var elems = Regex.Split(func, @"(?=[-\+])"); //2x^2; +x; +4
            string result = "";
            foreach (var elem in elems)
            {

            }
            return result;
        }
    }
}
