using System;
using System.Collections.Generic;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> let = new List<string>();

            Console.WriteLine("Enter some random letters");



            var input = Console.ReadLine();


            //char[] characters = input.ToCharArray();
            string[] stringLetters = new string[input.Length];
            char[] charArray = input.ToCharArray();

            foreach (var item in charArray)
            {
                Console.Write(item + "-");
                
            }
            Console.ReadLine();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    stringLetters[i] = $"{input[i]}";
            //    Console.WriteLine(input[i]);
            //    Console.ReadLine();
            //}

            //string testString;
            //Console.Write("Enter Random letters with no spaces : ");
            //testString = Console.ReadLine();
            //Console.WriteLine("You entered '{0}'", testString);
            //Console.WriteLine("Hit Enter to continue.");
            //Console.ReadLine();


        }
          
        
    }
}
