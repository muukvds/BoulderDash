using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.model
{
    public class SteelWall:Tile
    {
      

        public override bool CanBeMovedOn()
        {
            return false;
        }

        public override void CheckSurroundings()
        {

        }

        public override void DestroyGameObject()
        {
         
        }

        public override string GetIcon()
        {
            return "█";
        }

        public override void MoveGameObjectTo(GameObject gameObject)
        {
       
        }
    }
}
