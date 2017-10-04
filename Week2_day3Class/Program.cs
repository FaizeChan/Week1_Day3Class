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



            //Under is loops starting from 10 depleting by 1 all the way to 0

            //for(int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //Section below is a while loop 

            //Console.WriteLine("Do you want to play the game? (YES/NO)");
            //string playAgain = Console.ReadLine();
            //while(playAgain == "YES" )
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("do you want to play again? (YES/NO)");
            //    playAgain = Console.ReadLine();

            //}


            //Console.WriteLine("Would you like to check in for your appointment?");
            //string userAnswer = Console.ReadLine().ToLower();
            //while (userAnswer == "yes")
            //{
            //    {
            //        Console.WriteLine("What's your 6-digit patient ID");
            //        {
            //            Console.WriteLine("What's your appointment time?");
            //            Console.WriteLine("INVALID TIME");
            //        }
            //        Console.WriteLine("INVALID ID NUMBER");
            //        int unserID = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine("PATIENT CHECK IN SYSTEM");
            //    userAnswer = Console.ReadLine();
            //}


            //string playAgain;

            //do
            //{
            //    Console.WriteLine("Great Game!");
            //    Console.WriteLine("Do you want to play again? (YES/NO)");
            //    playAgain = Console.ReadLine().ToUpper();
            //}
            //while (playAgain == "YES");

            //Console.WriteLine("Thanks for playing the game");



            //string classResults;

            //do
            //{
            //    Console.WriteLine("What's the letter grade in the specified class");
            //    classResults = Console.ReadLine();
            //    Console.WriteLine("What is your letter grade in this class?");
            //    classResults = Console.ReadLine();
            //}

            //while (className == Console.ReadLine());

            //Console.WriteLine("What class would you like add to your GPA calculation?");

            //for(int i = 1; i <= 20; i++)
            //{
            //    if(i % 13 == 0)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("The loop has finished.");


            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 1; j <= 8; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }





            //Under is loops starting from 10 depleting by 1 all the way to 0

            //for(int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //Section below is a while loop 

            //Console.WriteLine("Do you want to play the game? (YES/NO)");
            //string playAgain = Console.ReadLine();
            //while(playAgain == "YES" )
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("do you want to play again? (YES/NO)");
            //    playAgain = Console.ReadLine();

            //}


            //Console.WriteLine("Would you like to check in for your appointment?");
            //string userAnswer = Console.ReadLine().ToLower();
            //while (userAnswer == "yes")
            //{
            //    {
            //        Console.WriteLine("What's your 6-digit patient ID");
            //        {
            //            Console.WriteLine("What's your appointment time?");
            //            Console.WriteLine("INVALID TIME");
            //        }
            //        Console.WriteLine("INVALID ID NUMBER");
            //        int unserID = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine("PATIENT CHECK IN SYSTEM");
            //    userAnswer = Console.ReadLine();
            //}


            //string playAgain;

            //do
            //{
            //    Console.WriteLine("Great Game!");
            //    Console.WriteLine("Do you want to play again? (YES/NO)");
            //    playAgain = Console.ReadLine().ToUpper();
            //}
            //while (playAgain == "YES");

            //Console.WriteLine("Thanks for playing the game");



            //string classResults;

            //do
            //{
            //    Console.WriteLine("What's the letter grade in the specified class");
            //    classResults = Console.ReadLine();
            //    Console.WriteLine("What is your letter grade in this class?");
            //    classResults = Console.ReadLine();
            //}

            //while (className == Console.ReadLine());

            //Console.WriteLine("What class would you like add to your GPA calculation?");

            //for(int i = 1; i <= 20; i++)
            //{
            //    if(i % 13 == 0)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("The loop has finished.");


            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 1; j <= 8; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();

            }


            }
    }
}
