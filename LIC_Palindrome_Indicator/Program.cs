using System;

namespace LIC_Palindrome_Indicator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Please enter a string:");
                    var line = Console.ReadLine();

                    var resultString = string.Empty;
                    var checker = new PalindromeChecker(line);
                    var result = checker.IsAnagramOrPalindrome(out resultString);

                    Console.WriteLine(resultString);

                    Console.WriteLine("Press ESC to exit or any other key to contiue...");
                    if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                //log ex here....
                Console.WriteLine("Exception occured....please press any key to exit");
                Console.ReadKey(true);                
            }            
        }
    }
}
