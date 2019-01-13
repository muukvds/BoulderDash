using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.enums;

namespace BoulderDash.model
{
   public class Player : GameObject
    {
        public int Score { get; set; }


        public Player()
        {
            Score = 0;
        }

        public override void Destroy()
        {
            //CurrentLocation.GameModel.EndGame();
        }

        public override bool Move(Direction direction)
        {
            bool moved = false;
           
            //todo fix cast
           var targetFloor = CurrentLocation.NeighbourTile(direction);
            if (CurrentLocation.NeighbourTile(direction).CanBeMovedOn())
            {
                targetFloor.Action();
                MoveTo(targetFloor);
                moved = true;
            }
            else
            {
                targetFloor.Action();
            }


            return moved;
        }

        public override string GetIcon()
        {
            return "@";
        }

        public override void Action()
        {
           
        }

        public override void CheckSurroundings()
        {
            
        }
    }
}
