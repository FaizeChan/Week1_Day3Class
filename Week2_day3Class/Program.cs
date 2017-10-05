using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_day3Class
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int answer = Add(5, 7);

        //    Console.WriteLine(answer);
        //}

        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a name");
            //string name = Console.ReadLine();

            //Console.WriteLine("Please enter the best food ever!");
            //string food = Console.ReadLine();

            //favoriteFood(name, food);
            //favoriteFood("Faizon", "Lobster");
            //favoriteFood("JD", "Pizza");
            //favoriteFood("Monica", "shrimp");

            RetirementCalculator(64);
        }


        public static void RetirementCalculator(int age)
        {
            int retirementAge = Math.Max(0, 65 - age);

            Console.WriteLine("The user will retire in " + retirementAge + " years");
        }

        public static void favoriteFood(string name, string food)
        {
            Console.WriteLine("********************************");
            Console.WriteLine(name + "'s favorite food is " + food);
            Console.WriteLine();

        }

        // DO NOT REPEAT YOURSELF.


        //public static int Add(int firstNumber, int secondNumber)
        //{
        //    int sum = firstNumber + secondNumber;

        //    return sum;
        //}

    }
}
