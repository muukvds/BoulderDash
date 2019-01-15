using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.enums;

namespace BoulderDash.model
{
    public class FireFly : GameObject
    {

        private Direction Front;

        public FireFly()
        {
            Crushable = true;
            Front = Direction.RIGHT;
        }

        public override void Crush()
        {
            Destroy();
        }

        public override void Destroy()
        {
            base.Destroy();
            CurrentLocation.GameModel.FireFlyDestroyed(this);
        }

        public override void Action()
        {
            CurrentLocation.NeighbourTile(Direction.DOWN).NeighbourTile(Direction.LEFT).DestroyGameObject();
            CurrentLocation.NeighbourTile(Direction.DOWN).NeighbourTile(Direction.RIGHT).DestroyGameObject();
            CurrentLocation.NeighbourTile(Direction.DOWN).DestroyGameObject();

            CurrentLocation.NeighbourTile(Direction.UP).NeighbourTile(Direction.LEFT).DestroyGameObject();
            CurrentLocation.NeighbourTile(Direction.UP).NeighbourTile(Direction.RIGHT).DestroyGameObject();
            CurrentLocation.NeighbourTile(Direction.UP).DestroyGameObject();

            CurrentLocation.NeighbourTile(Direction.LEFT).DestroyGameObject();
            CurrentLocation.NeighbourTile(Direction.RIGHT).DestroyGameObject();
            CurrentLocation.DestroyGameObject();
        }

        public override string GetIcon()
        {
       
            return "F";
        }

        public override void CheckSurroundings()
        {

            if (CurrentLocation.NeighbourTile(Direction.DOWN).NeighbourTile(Direction.LEFT).GetGameObject() != null 
                && CurrentLocation.NeighbourTile(Direction.DOWN).NeighbourTile(Direction.LEFT).GetGameObject().IsPlayer)
            {
                Action();
            }
            else if (CurrentLocation.NeighbourTile(Direction.DOWN).NeighbourTile(Direction.RIGHT).GetGameObject() != null
                && CurrentLocation.NeighbourTile(Direction.DOWN).NeighbourTile(Direction.RIGHT).GetGameObject().IsPlayer)
            {
                Action();
            }
            else if (CurrentLocation.NeighbourTile(Direction.DOWN).GetGameObject() != null
                && CurrentLocation.NeighbourTile(Direction.DOWN).GetGameObject().IsPlayer)
            {
                Action();
            }


            else if (CurrentLocation.NeighbourTile(Direction.UP).NeighbourTile(Direction.LEFT).GetGameObject() != null
                && CurrentLocation.NeighbourTile(Direction.UP).NeighbourTile(Direction.LEFT).GetGameObject().IsPlayer)
            {
                Action();
            }
           else if (CurrentLocation.NeighbourTile(Direction.UP).NeighbourTile(Direction.RIGHT).GetGameObject() != null
                && CurrentLocation.NeighbourTile(Direction.UP).NeighbourTile(Direction.RIGHT).GetGameObject().IsPlayer)
            {
                Action();
            }
            else if (CurrentLocation.NeighbourTile(Direction.UP).GetGameObject() != null
                && CurrentLocation.NeighbourTile(Direction.UP).GetGameObject().IsPlayer)
            {
                Action();
            }


            else if (CurrentLocation.NeighbourTile(Direction.LEFT).GetGameObject() != null
                     && CurrentLocation.NeighbourTile(Direction.LEFT).GetGameObject().IsPlayer)
            {
                Action();
            }
            else if (CurrentLocation.NeighbourTile(Direction.RIGHT).GetGameObject() != null
                     && CurrentLocation.NeighbourTile(Direction.RIGHT).GetGameObject().IsPlayer)
            {
                Action();
            }
        
        }

        public override bool Move(Direction direction)
        {
 
            switch(Front)
            {
                case Direction.RIGHT:

                    if (CurrentLocation.NeighbourTile(Direction.UP).GetGameObject() == null)
                    {
                        MoveTo(CurrentLocation.NeighbourTile(Direction.UP));
                        Front = Direction.UP;
                    }
                    else if (CurrentLocation.NeighbourTile(Direction.RIGHT).GetGameObject() == null)
                    {
                        MoveTo(CurrentLocation.NeighbourTile(Direction.RIGHT));
                    }
                    else if (CurrentLocation.NeighbourTile(Direction.DOWN).GetGameObject() == null)
                    {
                        MoveTo(CurrentLocation.NeighbourTile(Direction.DOWN));
                        Front = Direction.DOWN;
                    }
                    else 
                    {
                        MoveTo(CurrentLocation.NeighbourTile(Direction.LEFT));
                        Front = Direction.LEFT;
                    }
               
                break;

                case Direction.DOWN:
                    if (CurrentLocation.NeighbourTile(Direction.RIGHT).GetGameObject() == null)
                    {
                        MoveTo(CurrentLocation.NeighbourTile(Direction.RIGHT));
                        Front = Direction.RIGHT;
                    }
                    else if (CurrentLocation.NeighbourTile(Direction.DOWN).GetGameObject() == null)
                    {
                        MoveTo(CurrentLocation.NeighbourTile(Direction.DOWN));
                    }
                    else if (CurrentLocation.NeighbourTile(Direction.LEFT).GetGameObject() == null)
                    {
                        MoveTo(CurrentLocation.NeighbourTile(Direction.LEFT));
                        Front = Direction.LEFT;
                    }
                    else
                    {
                        MoveTo(CurrentLocation.NeighbourTile(Direction.UP));
                        Front = Direction.UP;
                    }
                    break;

                case Direction.LEFT:
                    if (CurrentLocation.NeighbourTile(Direction.DOWN).GetGameObject() == null)
                    {
                        MoveTo(CurrentLocation.NeighbourTile(Direction.DOWN));
                        Front = Direction.DOWN;
                    }
                    else if (CurrentLocation.NeighbourTile(Direction.LEFT).GetGameObject() == null)
                    {
                        MoveTo(CurrentLocation.NeighbourTile(Direction.LEFT));
                    }
                    else if (CurrentLocation.NeighbourTile(Direction.UP).GetGameObject() == null)
                    {
                        MoveTo(CurrentLocation.NeighbourTile(Direction.UP));
                        Front = Direction.UP;
                    }
                    else
                    {
                        MoveTo(CurrentLocation.NeighbourTile(Direction.RIGHT));
                        Front = Direction.RIGHT;
                    }
                    break;

                case Direction.UP:
                    if (CurrentLocation.NeighbourTile(Direction.LEFT).GetGameObject() == null)
                    {
                        MoveTo(CurrentLocation.NeighbourTile(Direction.LEFT));
                        Front = Direction.LEFT;
                    }
                    else if (CurrentLocation.NeighbourTile(Direction.UP).GetGameObject() == null)
                    {
                        MoveTo(CurrentLocation.NeighbourTile(Direction.UP));
                    }
                    else if (CurrentLocation.NeighbourTile(Direction.RIGHT).GetGameObject() == null)
                    {
                        MoveTo(CurrentLocation.NeighbourTile(Direction.RIGHT));
                        Front = Direction.RIGHT;
                    }
                    else
                    {
                        MoveTo(CurrentLocation.NeighbourTile(Direction.DOWN));
                        Front = Direction.DOWN;
                    }
                    break;
            }

            return true;
        }
    }
}
