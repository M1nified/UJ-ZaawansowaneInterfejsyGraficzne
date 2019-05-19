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
            if(newA == 0)
            {
                return "";
            }
            if(newA > 0)
            {
                return "+" + newA + "x^" + newExp;
            }
            return "" + newA + "x^" + newExp;
        }
        public string Deriviate(string func)
        {
            //2x^2+x+4
            var elems = Regex.Split(func, @"(?=[-\+])"); //2x^2; +x; +4
            string result = "";
            foreach (var elem in elems)
            {
                var exp = 1;
                var a = 1;
                if (elem.Contains("^"))
                {
                    var parts = Regex.Split(elem, @"\^");
                    var expStr = parts[1];
                    int.TryParse(expStr, out exp);
                }
                if (elem.Contains('x'))
                {
                    var parts2 = elem.Split('x');
                    if (!parts2[0].Contains("^"))
                    {
                        if (parts2[0] != "+")
                        {
                            int.TryParse(parts2[0], out a);
                        }
                    }
                }
                else
                {
                    exp = 0;
                }
                var deriv = DeriviateSingle(a, exp);
                result += deriv;
            }
            return result;
        }
    }
}