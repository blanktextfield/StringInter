﻿using System;

namespace StringInter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. The app asks for the user`s first name and stores it in a seperate variable
             * 2. The app asks for the user`s last name and stores it in a seperate variable
              */
            string FirstName;
            string LastName;
            Console.WriteLine("What`s your first name?");
            FirstName = Console.ReadLine();
            Console.WriteLine("what`s your last name?");
            LastName = Console.ReadLine();
            Console.WriteLine("Hello," + FirstName + " " + LastName);
            Console.WriteLine($"Hello, ");
            //Console.Write("Hello, + Fisrtname + " " + Lastname);
            //string interpolation
            //$ - alt + ctrl+4 {alt gr + 7,} - alt gr + 0
            

            


        }
    }
}
