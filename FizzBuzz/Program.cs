using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            //allow user to give upper and lower bound
            //make sure lower < upper
            //allow user to set conditions for multiples
            //count 0-100 and print each number per line
            //if number is multiple of 3, print Fizz
            //number multiple of 5 write buzz
            //number multiple of both write FizzBuzz

            //need to have fizzbuzz in another function
            //main's sole purpose is to start the program
            //fred.belotte@revature.com


            RunFizzBuzz(0, 100);


        }
        static void RunFizzBuzz(int start, int end, int inc = 1)
        {
            for (int x = start; x <= end; x += inc) //to reduce confusion between ++i and i++
            {
                PrintNumber(x);
            }
        }

        static void PrintNumber(int n, int div1 = 3, int div2 = 5)
        {
            if (n == 0)
            {
                WriteToConsole(n, "");
            }
            else if (n % (div1 * div2) == 0)
            {
                WriteToConsole(n, "FizzBuzz");

            }
            else if (n % div1 == 0)
            {
                WriteToConsole(n, "Fizz");
            }
            else if (n % div2 == 0)
            {
                WriteToConsole(n, "Buzz");
            }
            else
            {
                WriteToConsole(n, "");
            }
        }
        static void WriteToConsole(int n, string pre)
        {
            //print to screen  WriteToConsole(n);  WriteToConsole(n);
            Console.WriteLine($"{n} {pre}");
        }
    }
}