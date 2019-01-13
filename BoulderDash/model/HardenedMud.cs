using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.enums;

namespace BoulderDash.model
{
    public class HardenedMud : GameObject
    {

        private int _strength;

        public HardenedMud()
        {
            CanSupportHardenedMud = true;
            CanMoveOn = false;
            _strength = 2;

        }

        public override void Action()
        {
            _strength--;
            if (_strength < 1)
            Destroy();
        }

        public override void CheckSurroundings()
        {
            int supportingObjects = 0;

            if (!CurrentLocation.NeighbourTile(Direction.DOWN).CanBeMovedOn())
            {
                supportingObjects = 2;
            }

            if (CurrentLocation.NeighbourTile(Direction.UP).GetGameObject() != null)
            {
                if (CurrentLocation.NeighbourTile(Direction.UP).GetGameObject().CanSupportHardenedMud)
                {
                    supportingObjects++;
                }
            }

            if (CurrentLocation.NeighbourTile(Direction.RIGHT).GetGameObject() != null)
            {
                if (CurrentLocation.NeighbourTile(Direction.RIGHT).GetGameObject().CanSupportHardenedMud)
                {
                    supportingObjects++;
                }
            }

            if (CurrentLocation.NeighbourTile(Direction.LEFT).GetGameObject() != null)
            {
                if (CurrentLocation.NeighbourTile(Direction.LEFT).GetGameObject().CanSupportHardenedMud)
                {
                    supportingObjects++;
                }
            }

            if (supportingObjects < 2)
            {
                Move(Direction.DOWN);
            }
        }

        public override string GetIcon()
        {
            return"H";
        }

        public override bool Move(Direction direction)
        {
            CurrentLocation.NeighbourTile(direction).Action();
            CurrentLocation.NeighbourTile(direction).MoveGameObjectTo(this);
            return true;
        }
    }
}
