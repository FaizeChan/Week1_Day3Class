using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_day3Class
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = Add(5, 7);

            Console.WriteLine(answer);
        }

        public static int Add(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;

            return sum;
        }

    }
}
