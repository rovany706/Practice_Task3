using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static double GetValue(double x)
        {
            if (x < -1)
                return -1 / x;
            else if (x < 2)
                return Math.Pow(x, 2);
            else
                return 4;

        }
        static void Main(string[] args)
        {
            
        }
    }
}
