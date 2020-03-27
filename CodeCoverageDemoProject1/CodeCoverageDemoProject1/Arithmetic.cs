using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCoverageDemoProject1
{
    public class Arithmetic
    {
        public int Add(int a, int b) { return Math.Abs(a + b); }
        public int Sub(int a, int b) { return Math.Abs(a - b); }
        public int Mul(int a, int b) { return Math.Abs(a * b); }
        public int Div(int a, int b) { return Math.Abs(a / b); }

        public void IsGreaterthanZero(int a)
        {
            if (a > 0)
            {
                Console.WriteLine("{0} is greater than zero", a);
            }
            else
            {
                Console.WriteLine("{0} is not greater than zero", a);
            }

        }
    }
}
