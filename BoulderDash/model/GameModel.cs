using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.controller;
using BoulderDash.enums;

namespace BoulderDash.model
{
    public class GameModel
    {
        private GameController _controller;

        private Tile _firstTile;

        private int _diamonds;
        private int _destinations;
        private int _chestOnDestinations;
        private List<FireFly> _fireFlys;


        public Player Player { get; set; }

        public GameModel(GameController controller)
        {
            _controller = controller;
            _fireFlys = new List<FireFly>();
        }

        public void MovePlayer(Direction direction)
        {
            Player.Move(direction);
            foreach (FireFly fireFly in _fireFlys)
            {
                fireFly.Move(Direction.LEFT);
            }
            Update();
        }

        public void Play(Tile firstTile)
        {
            _firstTile = firstTile;
            _controller.ShowGame(_firstTile);
        }

        private void Update()
        {
            _controller.ShowGame(_firstTile);
        }

        public void AddFireFly(FireFly fireFly)
        {
            _fireFlys.Add(fireFly);
        }

        public void AddDestination()
        {
            _destinations++;
        }

        public void AddDiamond()
        {
            _diamonds++;
        }

        public void EndGame()
        {
            _controller.EindGame(Player.Score);
        }

    }
}
