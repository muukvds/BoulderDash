using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.model
{
    public class Exit : Floor
    {

        public override GameObject GameObject
        {
            set
            {
                base.GameObject = value;
             
            }
        }
        public override string GetIcon()
        {
            return "E";
        }

        public Exit()
        {
            
        }
    }
}
