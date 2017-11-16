using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPSnake.Model
{
    class GameState : IGameState
    {
        public Int32 BoardSize { get; internal set; }
        public IEnumerable<ITile> Obstacles { get; internal set; }
        public IEnumerable<ITile> SnakeBody { get; internal set; }
        public ITile Egg { get; internal set; }
        
        public GameState() { }
    }
}
