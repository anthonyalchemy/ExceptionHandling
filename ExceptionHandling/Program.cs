using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exception handling is where a prgram will crash due to an error in code
            //so try and exception handle to tell user about their error 
            //will try the code and goes to throw it will go to catch and show error 

            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine(num1 / num2);

            }
            catch (DivideByZeroException e)// parameter to get more info from the error and will only catch one from zero 
            {
                Console.WriteLine(e.Message);// try program by dividing by zero
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);// try program by dividing by letter
            }
           // finally //code will always get executed no matter what
            //{

            //}

           
            Console.ReadLine();

        }
    }
}
