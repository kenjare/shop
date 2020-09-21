using System;

namespace HelloWorld
{
   public class Program
    {
        static void Main(string[] args)
        {
            //Create a new instance of a Game
            Game game = new Game();
            //Run the Game
            game.Run();
            //Wait before closing
            Console.ReadKey();
        }
    }
}
