using System;
using Delegates;
namespace practice
{

	public class Program
	{
        static void Main(string[] args)
        { 
            MessagePrinter printer = new MessagePrinter(DelegateTest.PrintHelloWorld);

            MessagePrinter printer2 = DelegateTest.PrintHelloWorld;

            printer += DelegateTest.PrintGoodBye;
            printer2 += DelegateTest.PrintGoodBye;

            printer();
            printer2.Invoke();




        }
    }
}

