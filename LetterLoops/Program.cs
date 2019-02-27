using System;
using System.Collections.Generic;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> letters = new List<string>();

            Console.WriteLine("Enter some random letters");

            var input = Console.ReadLine();

            char[] characters = input.ToCharArray();
            foreach (char c in characters)
            {
                //Label1.Text += c.ToString() + " ";
                Console.WriteLine(c.ToString());
                Console.ReadLine();
            }

            //   int i,j;
            //   int n=5;

            //for(i=1;i<=n;i++)
            //{
            //    for(j=1;j<=i;j++)
            //    {
            //        Console.Write((char)(i+64));

            //    }

            //    Console.WriteLine("");
            //}
            //   Console.ReadLine();
        }
          
        
    }
}
