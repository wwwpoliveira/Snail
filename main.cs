//
// Ficheiro teste para arquiver no git
// Pedro Oliveira 
// github.com/wwwpoliveira/snail.git
//

using System;
using System.Threading;

class App {

    static void Main(string[] args) {

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;

        int x = Console.WindowWidth *2;
        int y = Console.WindowHeight *2;

        Console.SetWindowSize(x, y);


        Console.WriteLine("{0} {1}", x, y);
        Console.ReadKey();

		Random rnd= new Random();
		for (int i=0; i<=2000; i++) {
			int rndnumber = rnd.Next(1,100);
            Console.Write("{0} ", rndnumber);
		}
        
        Console.Title = "The title has changed!";
		Console.ResetColor();
		Console.ReadKey();

        int n = 0;
        do
        {
            Console.SetCursorPosition(rnd.Next(0, Console.WindowWidth), rnd.Next(0, Console.WindowHeight));
            Console.Write(" ");
            //Thread.Sleep(1);
            n++;
        } while(n<10000);
		Console.Clear();


    }
}
