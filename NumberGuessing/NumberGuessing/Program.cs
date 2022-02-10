using System;

namespace NumberGuessing
{
    internal class Program
    {
        static int GetGuess(int actualNumber) 
        {

            //checking correct input.
            bool status = int.TryParse(Console.ReadLine(), out int result);

            //verifying result (using tertiary operator)
            string finalResult = (status) ?
                (actualNumber == result) ? $"Number {result} is Correct. You guessed it right! Yay! \n" : "You Lose. Please guess Correctly. Try Again. \n"
                : "Please enter in integer format \n";


            Console.WriteLine(finalResult);
            return result;
        }

        static void Main(string[] args)
        {
            {
                int actualNumber = 10;
                int result;

                Console.WriteLine("Guess the Number");
                Console.WriteLine("Hint: Decimal Number System");

                
                do{
                    result = GetGuess(actualNumber);
                }while (result != actualNumber) ;

                
                Console.WriteLine("Press any Key to exit.");

                Console.ReadLine();
            }


            /*
             Note:
            Here actual number is hard-coded but can come from database as well if you want. 
            */

        }
    }
}
