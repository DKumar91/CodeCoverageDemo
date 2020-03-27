using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCoverageDemoProject
{
    public class Class1
    {
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
    }
}
