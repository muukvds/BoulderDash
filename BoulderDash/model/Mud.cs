using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.enums;

namespace BoulderDash.model
{
    public class Mud : GameObject
    {

        public Mud()
        {
            CanMoveOn = false;
            CanSupportHardenedMud = true;
        }
        

        public override void Action()
        {
           Destroy();
        }

        public override void CheckSurroundings()
        {
        
        }

        public override string GetIcon()
        {
            return "M";
        }

        public override bool Move(Direction direction)
        {
            return false;
        }
    }
}
