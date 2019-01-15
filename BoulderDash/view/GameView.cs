using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.controller;
using BoulderDash.enums;
using BoulderDash.model;

namespace BoulderDash.view
{
    public class GameView
    {
        private GameController _controller;

        public GameView(GameController controller)
        {
            _controller = controller;
        }

        public void PrintMenu()
        {
            Console.Clear();

            Console.WriteLine("______________________________________________________");
            Console.WriteLine("| Welkom bij BoulderDask                             |");
            Console.WriteLine("| betekenis van de symbolen   | doel van het spel    |");
            Console.WriteLine("|                             |                      |");
            Console.WriteLine("| spatie : outerspace         | haal alle diamanten  |");
            Console.WriteLine("|     █ : steelWall           | op en ga naar de     |");
            Console.WriteLine("|     . : vloer               | exit                 |");
            Console.WriteLine("|     O : Boulder             |                      |");
            Console.WriteLine("|     0 : Diamant             |                      |");
            Console.WriteLine("|     X : TNT                 |                      |");
            Console.WriteLine("|     @ : Rockford (player)   |                      |");
            Console.WriteLine("|     M : Mud                 |                      |");
            Console.WriteLine("|     H : Hardened Mud        |                      |");
            Console.WriteLine("|     F : Firefly             |                      |");
            Console.WriteLine("|     # : Wall                |                      |");
            Console.WriteLine("|____________________________________________________|");
            Console.WriteLine("");
            Console.WriteLine("> Kies een level (1 - 3), s = stop");

            string sInput = Console.ReadLine();

            if (sInput == "s")
            {
                _controller.Quit();
            }
            else
            {
                _controller.PlayGame(sInput);

            }
        }

        public void PrintGame(Tile FirstTile)
        {
            Console.Clear();
            Tile CurrentTile = FirstTile;
            Tile FirstLineTile = FirstTile;

            while (CurrentTile != null)
            {
                if (CurrentTile.NeighbourTile(Direction.RIGHT) != null)
                {
                    Console.Write(CurrentTile.GetIcon());
                    CurrentTile = CurrentTile.NeighbourTile(Direction.RIGHT);
                }
                else
                {
                    FirstLineTile = FirstLineTile.NeighbourTile(Direction.DOWN);
                    Console.WriteLine(CurrentTile.GetIcon());

                    if (FirstLineTile == null) { break; }
                    CurrentTile = FirstLineTile;
                }
            }
            _controller.MovePlayer(WaitForInput());
        }

        public void LostGame()
        {
            Console.WriteLine("Game verloren je bent dood.");
            Console.ReadLine();
            _controller.Quit();
        }

        public void EindGame(int score,int timeLeft)
        {
            Console.WriteLine("Game voltooid je hebt een score van {0}, met {1} seconde over", score,timeLeft);
            Console.ReadLine();
            _controller.Quit();
        }


        private Direction WaitForInput()
        {
            Direction direction = Direction.UP;
            bool actionKey = false;
            while (!actionKey)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow:
                            direction = Direction.UP;
                            actionKey = true;
                            break;
                        case ConsoleKey.DownArrow:
                            direction = Direction.DOWN;
                            actionKey = true;
                            break;
                        case ConsoleKey.LeftArrow:
                            direction = Direction.LEFT;
                            actionKey = true;
                            break;
                        case ConsoleKey.RightArrow:
                            direction = Direction.RIGHT;
                            actionKey = true;
                            break;
                        case ConsoleKey.Spacebar:
                            direction = Direction.STAY;
                            actionKey = true;
                            break;
                        case ConsoleKey.Escape:
                          //  _controller.Quit();
                            break;
                    }
                }
            }
            return direction;
        }

    }
}
