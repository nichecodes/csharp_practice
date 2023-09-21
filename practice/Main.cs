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

            Console.WriteLine(DelegateTest.AddThis(2, 3,  (int x, int y) => { return x + y; }));
            // Now lets Try an anonymous method

            FootballMatch game = new FootballMatch("Barcelona", "Madrid");

            game.GoalNotifier += (string name, int score1, int score2) => Console.WriteLine(name + " scored!" + String.Format("Current score is: {0} to {1} ", score1, score2));

            Console.WriteLine(game.GoalNotifier.GetInvocationList);
            game.teamScore(1);
            game.teamScore(2); 

            

        }
    }
}
