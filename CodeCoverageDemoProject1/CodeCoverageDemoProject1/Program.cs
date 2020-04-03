using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCoverageDemoProject1
{
    public class Program
    {
        public static void Main(string[] arg) { }
        public int LeftShift(int a, int b) { return Math.Abs(a << b); }
        public int RightShift(int a, int b) { return Math.Abs(a >> b); }
        public int LargestNumberInArray(int[] a)
        {
            int largest = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > largest)
                {
                    largest = a[i];
                }

            }
            return largest;
        }

        public int SmallestNumberInArray(int[] a)
        {
            int smallest = a[0];
            for (int i = 1; i <=a.Length-1; i++)
            {
                if (smallest > a[i])
                {
                    smallest = a[i];
                }

            }
            return smallest;
        }
    }
}
