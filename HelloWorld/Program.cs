using System;

namespace Revature.Week1.HelloWorld //namespace scope
{
    //class, struct, interface, enum
    class Program //class scope
    {
        private static void Main()
        {
            //ask for name
            Console.WriteLine("enter your name: ");
            //string in
            var input = Console.ReadLine();
            //stdout to print your name
            Console.WriteLine($"Hello {input}");
        }

        //function or method scope - different but rn using interchangeably
        private void UiPath() //method scope
        {
            { //block scope
            }
        }
    }
}