using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            var math = new Math();
            var result = math.Deriviate("2x^2+x+4"); // 4x^1+1
        }
    }
}
