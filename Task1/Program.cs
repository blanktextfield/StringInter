using System;
using System.Diagnostics.CodeAnalysis;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. program asks for user`s first and lastname
             * 2. program asks for user`s year of birth
             * 3.program greets the user by their name and displays their age
             */
            string FirstName;
            Console.WriteLine("What`s your full name?");
            FirstName = Console.ReadLine();
            
          
            Console.WriteLine("Hello," + FirstName + " ");

            Console.WriteLine("What`s user`s year of birth");
            string userinput;
            userinput = Console.ReadLine();
            int Yearofbirth;
            //parsing string to interger (number)
            Yearofbirth = Int32.Parse(userinput);
            int Age = 2020 - Yearofbirth;
            Console.WriteLine("Hello " + FirstName + " you`re " + Age + " years old");



        }
    }
}
