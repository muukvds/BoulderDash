using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.enums;

namespace BoulderDash.model
{
    public abstract class GameObject
    {
        public Floor CurrentLocation { get; set; }
        public bool Movable { get; set; }
        public bool CanMoveOn { get; protected set; }

        public bool CanSupportHardenedMud { get; protected set; }

        public bool IsPlayer { get; protected set; }
        public bool IsTNT { get; protected set; }
        public bool Crushable { get; protected set; }



        public GameObject()
        {

            Crushable = false;
            Movable = true;
            CanSupportHardenedMud = false;
            IsPlayer = false;
            IsTNT = false;
        }

        public virtual bool Move(Direction direction)
        {
            return false;
        }

        public abstract void Action();

        public abstract string GetIcon();

        public abstract void CheckSurroundings();

        public virtual void Destroy()
        {
            CurrentLocation.GameObject = null;
            CurrentLocation.CheckSurroundings();
        }
        public virtual void Crush()
        { }

        protected void MoveTo(Tile target)
        {
            target.MoveGameObjectTo(this);
        }
    }
}
