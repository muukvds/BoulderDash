using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.enums;

namespace BoulderDash.model
{
    public class Wall : GameObject
    {
        public override void Action()
        {
        }

        public override void CheckSurroundings()
        {
        }

        public override string GetIcon()
        {
            return "#";
        }

        public override bool Move(Direction direction)
        {
            return false;
        }
    }
}
