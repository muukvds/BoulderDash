using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.enums;

namespace BoulderDash.model
{
   public class Boulder : GameObject
    {

        public Boulder()
        {
            CanMoveOn = false;
        }

        public override string GetIcon()
        {
            return "O";
        }

        public override void Action()
        {

        }

        public override void CheckSurroundings()
        {
            if (CurrentLocation.NeighbourTile(Direction.DOWN).CanBeMovedOn())
            {
                Move(Direction.DOWN);
            }
            else
            {
                if (CurrentLocation.NeighbourTile(Direction.RIGHT).CanBeMovedOn())
                {
                    if (CurrentLocation.NeighbourTile(Direction.RIGHT).NeighbourTile(Direction.DOWN).CanBeMovedOn())
                    {
                        Move(Direction.RIGHT);
                    }
                    else
                    {
                        if (CurrentLocation.NeighbourTile(Direction.LEFT).CanBeMovedOn())
                        {
                            if (CurrentLocation.NeighbourTile(Direction.LEFT).NeighbourTile(Direction.DOWN).CanBeMovedOn())
                            {
                                Move(Direction.LEFT);
                            }
                        }
                    }
                }
                else if (CurrentLocation.NeighbourTile(Direction.LEFT).CanBeMovedOn())
                {
                    if (CurrentLocation.NeighbourTile(Direction.LEFT).NeighbourTile(Direction.DOWN).CanBeMovedOn())
                    {
                        Move(Direction.LEFT);
                    }
                    else
                    {
                        if (CurrentLocation.NeighbourTile(Direction.RIGHT).CanBeMovedOn())
                        {
                            if (CurrentLocation.NeighbourTile(Direction.RIGHT).NeighbourTile(Direction.DOWN)
                                .CanBeMovedOn())
                            {
                                Move(Direction.RIGHT);
                            }
                        }
                    }
                }
            }
        }

 

        public override bool Move(Direction direction)
        {
            bool isCrushable = true;
            if (CurrentLocation.NeighbourTile(direction).GetGameObject() != null)
            {
                isCrushable=CurrentLocation.NeighbourTile(direction).GetGameObject().Crushable;
            }

            if (isCrushable)
            {
                CurrentLocation.NeighbourTile(direction).Crush();
                CurrentLocation.NeighbourTile(direction).MoveGameObjectTo(this);
            }

            return true;
        }
    }
}
