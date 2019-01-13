﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.enums;

namespace BoulderDash.model
{
    public class Diamond : GameObject
    {
        public override void Action()
        {
            //todo give points to player
            throw new NotImplementedException();
        }

        public override string GetIcon()
        {
            return "0";
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
            CurrentLocation.NeighbourTile(direction).Action();
            CurrentLocation.NeighbourTile(direction).MoveGameObjectTo(this);
            return true;
        }

        public Diamond()
        {
            CanMoveOn = true;
        }
    }
}