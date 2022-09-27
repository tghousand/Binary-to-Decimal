using System;

/*
 * Binary to Decimal
 * Turns a binary string to a base 10 integer
 * Tyler Housand
 * 9/27/2022
 */

namespace Binary_to_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            String userInput;
            Boolean acceptableInput;
            do{
                Console.Write("Please input a binary value (1's and 0's): ");
                userInput = Console.ReadLine();
                acceptableInput = binaryCheck(userInput);
            }while (acceptableInput == false);
            Console.WriteLine(Convert.ToInt32(userInput, 2));
        }

        //checks if the user input a binary string
        public static bool binaryCheck(string userInput)
        {
            char c;
            for(int x = 0; x < userInput.Length; x++){
                c = userInput.ToCharArray()[x];
                if(c != '0' && c != '1'){
                    Console.WriteLine("Invalid input. Please try again.");
                    return false;
                }
            }
            return true;
        }
    }
}
