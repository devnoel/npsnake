using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPSnake.Persistance;

namespace NPSnake.Model
{
    public class SnakeModel : IModel
    {
        private Int32 boardSize;
        private IEnumerable<ITile> obstacles;
        private Snake snake;
        private ITile currentEgg;
        private IPersistance persistance;
        private Int32 gameSpeed;
        private GameTimer timer;

        public event EventHandler<IGameState> StateChanged;
        public event EventHandler<Int32> GameOver;

        #region Persistance operations

        public void SetPersistance(IPersistance persistance)
        {
            this.persistance = persistance;
        }

        public IEnumerable<ILevel> GetLevels()
        {
            CheckPersistance();
            IEnumerable<IGameLoad> gameLoads = persistance.LoadGames();
            IEnumerable<ILevel> levels = gameLoads.Select(GetLevelFromGameLoad);
            return levels;
        }

        private void CheckPersistance()
        {
            if (persistance == null)
            {
                throw new Exception("Cannot perform persistance operations" +
                    " - persistance object has not been set.");
            }
        }

        private ILevel GetLevelFromGameLoad(IGameLoad gameLoad)
        {
            var level = new Level
            {
                Id = gameLoad.Id,
                Name = gameLoad.Name,
                BoardSize = gameLoad.BoardSize
            };
            return level;
        }

        public void SelectLevel(Int32 levelId)
        {
            CheckPersistance();
            IGameLoad gameLoad = persistance.LoadGameById(levelId);
            boardSize = gameLoad.BoardSize;
            obstacles = gameLoad.Obstacles.Select(Tile.FromPosition);
            IEnumerable<ITile> snakeBody = gameLoad.SnakeBody.Select(Tile.FromPosition);
            snake = new Snake(snakeBody);
        }

        #endregion

        public void StartGame()
        {

        }

        public void TurnSnakeLeft() { }
        public void TurnSnakeRight() { }
        public void TurnSnakeForward() { }
        public void TogglePause() { }
    }
}
