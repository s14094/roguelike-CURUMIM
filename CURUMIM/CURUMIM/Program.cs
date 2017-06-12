using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CURUMIM
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            while (RunGame())
            {

            }

            Console.ResetColor();
            Console.Clear();


            bool RunGame()
            {
                Console.CursorVisible = false;

                Game game = new Game();

                //while (game.Update())
                //{
                    // Tiny nap to stop the CPU from melting.
                //    Thread.Sleep(10);
                //}

                //return game.Restart;
                return true;
            }
        }
    }
}
