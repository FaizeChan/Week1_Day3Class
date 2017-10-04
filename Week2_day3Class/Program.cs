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


            string playAgain;

            do
            {
                Console.WriteLine("Great Game!");
                Console.WriteLine("Do you want to play again? (YES/NO)");
                playAgain = Console.ReadLine().ToUpper();
            }
            while (playAgain == "YES");

            Console.WriteLine("Thanks for playing the game");


        }
    }
}
