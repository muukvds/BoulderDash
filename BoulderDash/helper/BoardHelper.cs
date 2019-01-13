using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.controller;
using BoulderDash.enums;
using BoulderDash.model;

namespace BoulderDash.helper
{
    public class BoardHelper
    {

        private GameModel _Model;
        private GameController _Controller;
        private LevelData _levelData;

        public BoardHelper( GameModel gameModel, GameController gameController)
        {

            _Model = gameModel;
            _Controller = gameController;
            _levelData = new LevelData();


        }

        public Tile getBoard(int levelNumber)
        {

            return generateTiles(_levelData.GetLevel(levelNumber));
        }

        private Tile generateTiles(char[,] lBoard)
        {
            Tile firstTile = null;

            for (int height = 0; height < LevelData.Level_height; height++)
            {
                bool firstOfRow = true;

                for (int width = 0; width < LevelData.Level_width; width++)
                {
                    char tile = lBoard[height, width];
                        Tile newTile;
         
                    switch (tile)
                    {
                        case 'R':
                            Player player = new Player();
                            newTile = new Floor(_Model, player);
                            player.CurrentLocation = (Floor)newTile;
                            _Controller.SetPlayer(player);
                            break;

                        case 'M':
                            Mud mud = new Mud();
                            newTile = new Floor(_Model, mud);
                            mud.CurrentLocation = (Floor)newTile;
                            break;

                        case 'B':
                            Boulder boulder = new Boulder();
                            newTile = new Floor(_Model, boulder);
                            boulder.CurrentLocation = (Floor)newTile;
                            break;

                        case 'D':
                            Diamond diamond = new Diamond();
                            newTile = new Floor(_Model, diamond);
                            diamond.CurrentLocation = (Floor)newTile;
                            _Model.AddDiamond();
                            break;

                        case 'W':
                            Wall wall = new Wall();
                            newTile = new Floor(_Model, wall);
                            wall.CurrentLocation = (Floor)newTile;
                            break;

                        case 'S':
                            newTile = new SteelWall();
                            break;

                        case 'F':
                            FireFly fireFly = new FireFly();
                            newTile = new Floor(_Model, fireFly);
                            fireFly.CurrentLocation = (Floor)newTile;
                            _Model.AddFireFly(fireFly);
                            break;

                        case 'E':
                            newTile = new Exit();
                            break;

                        case 'H':
                            HardenedMud hardenedMud = new HardenedMud();
                            newTile = new Floor(_Model, hardenedMud);
                            hardenedMud.CurrentLocation = (Floor)newTile;
                            break;

                        case 'T':
                            TNT tnt = new TNT();
                            newTile = new Floor(_Model, tnt);
                            tnt.CurrentLocation = (Floor)newTile;
                            break;

                        default:
                            newTile = new Floor(_Model);
                            break;

                    }

                    if (firstTile != null)
                    {
                        if (firstOfRow)
                        {
                            firstTile.SetTile(newTile, Direction.DOWN);
                            firstOfRow = false;
                        }
                        else
                        {
                            firstTile.SetTile(newTile, Direction.RIGHT);
                        }
                    }
                    else
                    {
                        firstTile = newTile;
                        firstOfRow = false;
                    }
                }        
            }
  
            return firstTile;

        }

    }
}
