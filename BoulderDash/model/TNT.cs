using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Timers;
using BoulderDash.enums;

namespace BoulderDash.model
{
    public class TNT : GameObject
    {

        private Timer _timer;
        private int _counter;
        private bool _faling;
        private int _timeTillExplode = 30;


        public TNT()
        {
            _faling = false;
            Crushable = true;
            IsTNT = true;
            CanMoveOn = true;
            _counter = 0;
            _timer = new Timer(1000);
            _timer.Elapsed += OnTimedEvent;
            _timer.Start();

        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            _counter++;
            if (_counter >= _timeTillExplode)
            {
                _timer.Stop();
                Explode();
            }
            
        }

        public override void Action()
        {
            _timer.Stop();
            this.Destroy();
        }

        public override void Crush()
        {
            Explode();
        }

        public void Explode()
        {
            CurrentLocation.DestroyGameObject();
            CurrentLocation.NeighbourTile(Direction.DOWN).NeighbourTile(Direction.LEFT).DestroyGameObject();
            CurrentLocation.NeighbourTile(Direction.DOWN).NeighbourTile(Direction.RIGHT).DestroyGameObject();


            CurrentLocation.NeighbourTile(Direction.UP).NeighbourTile(Direction.LEFT).DestroyGameObject();
            CurrentLocation.NeighbourTile(Direction.UP).NeighbourTile(Direction.RIGHT).DestroyGameObject();
            CurrentLocation.NeighbourTile(Direction.UP).DestroyGameObject();

            CurrentLocation.NeighbourTile(Direction.LEFT).DestroyGameObject();
            CurrentLocation.NeighbourTile(Direction.RIGHT).DestroyGameObject();
            CurrentLocation.NeighbourTile(Direction.DOWN).DestroyGameObject();
        }

        public override string GetIcon()
        {
            return "X";
        }

        public override void CheckSurroundings()
        {
            bool moved = false;

            if (CurrentLocation.NeighbourTile(Direction.DOWN).CanBeMovedOn())
            {
                Move(Direction.DOWN);
                moved = true;
            }
            else
            {
                if (CurrentLocation.NeighbourTile(Direction.RIGHT).CanBeMovedOn())
                {
                    if (CurrentLocation.NeighbourTile(Direction.RIGHT).NeighbourTile(Direction.DOWN).CanBeMovedOn())
                    {
                        Move(Direction.RIGHT);
                        moved = true;
                    }
                    else
                    {
                        if (CurrentLocation.NeighbourTile(Direction.LEFT).CanBeMovedOn())
                        {
                            if (CurrentLocation.NeighbourTile(Direction.LEFT).NeighbourTile(Direction.DOWN).CanBeMovedOn())
                            {
                                Move(Direction.LEFT);
                                moved = true;
                            }
                        }
                    }
                }
                else if (CurrentLocation.NeighbourTile(Direction.LEFT).CanBeMovedOn())
                {
                    if (CurrentLocation.NeighbourTile(Direction.LEFT).NeighbourTile(Direction.DOWN).CanBeMovedOn())
                    {
                        Move(Direction.LEFT);
                        moved = true;
                    }
                    else
                    {
                        if (CurrentLocation.NeighbourTile(Direction.RIGHT).CanBeMovedOn())
                        {
                            if (CurrentLocation.NeighbourTile(Direction.RIGHT).NeighbourTile(Direction.DOWN)
                                .CanBeMovedOn())
                            {
                                Move(Direction.RIGHT);
                                moved = true;
                            }
                        }
                    }
                }
            }

            if (_faling)
            {
                if (!moved)
                {
                    Explode();
                }
            }
        }

        public override bool Move(Direction direction)
        {
            _faling = true;
            CurrentLocation.NeighbourTile(direction).MoveGameObjectTo(this);
            return true;
        }
    }
}
