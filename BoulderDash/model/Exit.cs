using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.model
{
    public class Exit : Floor
    {
        private bool active;
        public override GameObject GameObject
        {
            set
            {
                if (value.IsPlayer && active)
                {
                    GameModel.WinGame();
                }
                base.GameObject = value;
             
            }
        }
        public override string GetIcon()
        {
            return "E";
        }

        public void Open()
        {
            active = true;
        }

        public Exit(GameModel gameModel)
        {
            GameModel = gameModel;
            active = false;
        }
    }
}
