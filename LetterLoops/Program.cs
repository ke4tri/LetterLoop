﻿using System;
using System.Collections.Generic;

namespace LetterLoops
{
    class Program
    {


        static void Main(string[] args)
        {
            
            List<string> let = new List<string>();

            Console.WriteLine("Enter some random letters");
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();

            
            for (int i = 0; i < input.Length; i++)
            {
                int multipler = i;
                string inputString = input[i].ToString();
                string inputMulti = new string(input[i], multipler);
                string build = inputString.ToUpper() + ( input[i] + inputMulti) + "-";

                if (i == input.Length -1)
                {
                    Console.Write(build.TrimEnd('-'));
                }
                else
                {
                    Console.Write(build);
                }


            }
            Console.ReadLine();
            
        }

       
    }
}

                
                
           




         
            
            

        

        




