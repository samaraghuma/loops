using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;int sum=0;int count=0;double average;
            for (i = 50; i <=10000; i++)
            {
                sum = sum + i;
                count = count + 1;
            }
            average = sum / count;
            Console.WriteLine(count);
            Console.WriteLine(average);
        }
    }

}
