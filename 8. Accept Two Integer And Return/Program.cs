using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Accept_Two_Integer_And_Return
{
    internal class Program
    {
        static bool CheckConditions(int num1, int num2)
        {
            return (num1 == 5 || num2 == 5 || num1 + num2 == 5 || Math.Abs(num1 - num2) == 5);
        }
        static void Main(string[] args)
        {
            int[,] testCases = {
              {5, 4},
              {4, 3},
              {1, 4}
        };

            for (int i = 0; i < testCases.GetLength(0); i++)
            {
                int num1 = testCases[i, 0];
                int num2 = testCases[i, 1];

                bool result = CheckConditions(num1, num2);
                Console.WriteLine(result);
                Console.ReadLine();
            }    }
    }
}
