using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.enums;

namespace BoulderDash.model
{
    public class Floor:Tile
    {
        protected GameModel _gameModel;

        public GameModel GameModel
        {
            get { return _gameModel; }
            protected set { _gameModel = value; }
        }

        private GameObject _gameObject;
        public virtual GameObject GameObject { get { return _gameObject; } set { _gameObject = value; } }

        public Floor()
        {
           
        }

        public override string GetIcon()
        {
            if (GameObject != null)
            {
                return GameObject.GetIcon();
            }
            return ".";
        }

        public override bool CanBeMovedOn()
        {
            return _gameObject == null || _gameObject.CanMoveOn;
        }

        public Floor(GameModel gameModel)
        {
            this._gameModel = gameModel;
           
        }

        public Floor(GameModel gameModel, GameObject gameObject)
        {
            this._gameModel = gameModel;
            GameObject = gameObject;

        }

        public override GameObject GetGameObject()
        {
            return GameObject;

        }

        public override void Action()
        {
          _gameObject?.Action();
        }

        public override void Crush()
        {
            _gameObject?.Crush();
        }

        public override void DestroyGameObject()
        {
           GameObject?.Destroy();
        }

        public override void CheckSurroundings()
        {
            NeighbourTile(Direction.DOWN).NeighbourTile(Direction.DOWN)?.NeighbourTile(Direction.LEFT)?.GetGameObject()?.CheckSurroundings();
            NeighbourTile(Direction.DOWN).NeighbourTile(Direction.DOWN)?.NeighbourTile(Direction.RIGHT)?.GetGameObject()?.CheckSurroundings();
            NeighbourTile(Direction.DOWN).NeighbourTile(Direction.DOWN)?.GetGameObject()?.CheckSurroundings();

            NeighbourTile(Direction.DOWN).NeighbourTile(Direction.LEFT)?.GetGameObject()?.CheckSurroundings();
            NeighbourTile(Direction.DOWN).NeighbourTile(Direction.RIGHT)?.GetGameObject()?.CheckSurroundings();
            NeighbourTile(Direction.DOWN).GetGameObject()?.CheckSurroundings();

            NeighbourTile(Direction.UP).NeighbourTile(Direction.UP)?.NeighbourTile(Direction.LEFT)?.GetGameObject()?.CheckSurroundings();
            NeighbourTile(Direction.UP).NeighbourTile(Direction.UP)?.NeighbourTile(Direction.RIGHT)?.GetGameObject()?.CheckSurroundings();
            NeighbourTile(Direction.UP).NeighbourTile(Direction.UP)?.GetGameObject()?.CheckSurroundings();

            NeighbourTile(Direction.UP).NeighbourTile(Direction.LEFT)?.GetGameObject()?.CheckSurroundings();
            NeighbourTile(Direction.UP).NeighbourTile(Direction.RIGHT)?.GetGameObject()?.CheckSurroundings();
            NeighbourTile(Direction.UP).GetGameObject()?.CheckSurroundings();

            NeighbourTile(Direction.LEFT).NeighbourTile(Direction.LEFT)?.GetGameObject()?.CheckSurroundings();
            NeighbourTile(Direction.RIGHT).NeighbourTile(Direction.RIGHT)?.GetGameObject()?.CheckSurroundings();

            NeighbourTile(Direction.LEFT).GetGameObject()?.CheckSurroundings();
            NeighbourTile(Direction.RIGHT).GetGameObject()?.CheckSurroundings();

  
          GameObject?.CheckSurroundings();
        }

        public override void MoveGameObjectTo(GameObject gameObject)
        {
            gameObject.CurrentLocation.GameObject = null;
            gameObject.CurrentLocation = this;
            this.GameObject = gameObject;
            CheckSurroundings();
        }
    }
}
