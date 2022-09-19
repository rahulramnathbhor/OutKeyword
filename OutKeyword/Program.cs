using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutKeyword
{
    internal class Program
    {
        static void Calculation(int a, int b, out int sum, out int sub, out int mul)
        {
            sum = a + b;
            sub = a - b;
            mul = a * b;
        }
        static void Main(string[] args)
        {
            int a = 30, b = 50, sum, mul, sub;
            Calculation(a, b, out sum, out sub, out mul);
            Console.WriteLine($"sum ={sum}");
            Console.WriteLine($" substraction = {sub}");
            Console.WriteLine($"multiplication={mul}");
        }

    }

}
