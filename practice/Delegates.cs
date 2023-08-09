using System;
namespace Delegates
{

    delegate void MessagePrinter();

    public class DelegateTest
	{
		public static void PrintHelloWorld()
		{
			Console.WriteLine("Hello World!");
		}

		public static void PrintGoodBye()
		{
			Console.WriteLine("Good Bye");

		}
	}
}

