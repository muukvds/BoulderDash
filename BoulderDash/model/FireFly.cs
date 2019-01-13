using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.enums;

namespace BoulderDash.model
{
    public class FireFly : GameObject
    {
        public override void Action()
        {
            throw new NotImplementedException();
        }

        public override string GetIcon()
        {
       
            return "F";
        }

        public override void CheckSurroundings()
        {
            throw new NotImplementedException();
        }

        public override bool Move(Direction direction)
        {
            throw new NotImplementedException();
        }
    }
}
