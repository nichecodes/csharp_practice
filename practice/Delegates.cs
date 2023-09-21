using System;
namespace Delegates
{

    public delegate void MessagePrinter();
    public delegate int MathHandler(int num1, int num2);
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
		
		public static int AddThis(int x, int y, MathHandler Adder)
		{

			return Adder(x, y);
		}
	}
}

