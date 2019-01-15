using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using BoulderDash.controller;
using BoulderDash.enums;

namespace BoulderDash.model
{
    public class GameModel
    {
        private GameController _controller;

        private Timer _gameTimer;
        private int _playTime;

        private Tile _firstTile;

        private int _diamonds;
        private int _diamondsPickedUp;
        private List<FireFly> _fireFlys;


        public Player Player { get; set; }
        private Exit Exit { get; set; }

        public GameModel(GameController controller)
        {
            _controller = controller;
            _fireFlys = new List<FireFly>();

            _gameTimer = new Timer(1000);
            _gameTimer.Elapsed += OnTimedEvent;

        }

        public void SetPlayTime(int time)
        {
            _playTime = time;
        }

        public void MovePlayer(Direction direction)
        {
            if (direction != Direction.STAY)
            {
                Player.Move(direction);
            }
            
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
            _gameTimer.Start();
        }

        public void Update()
        {
            _controller.ShowGame(_firstTile);
        }

        public void AddFireFly(FireFly fireFly)
        {
            _fireFlys.Add(fireFly);
        }

        public void FireFlyDestroyed(FireFly fireFly)
        {

            _fireFlys.Remove(fireFly);

            Player.Score += 250;
        }

        public void AddExit(Exit exit)
        {
            Exit = exit;
        }

        public void PickUpDiamond()
        {
            _diamondsPickedUp++;
            Player.Score += 10;
            if (_diamondsPickedUp >= _diamonds)
            {
                Exit.Open();
            }
        }

        public void AddDiamond()
        {
            _diamonds++;
        }

        public void WinGame()
        {
            _gameTimer.Stop();
            Player.Score += _playTime * 10;
            _controller.EindGame(Player.Score, _playTime);
        }

        public void EndGame()
        {
            _controller.LostGame();
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            _playTime--;
            if (_playTime <= 0)
            {
                _gameTimer.Stop();
                EndGame();
            }

        }

    }
}
