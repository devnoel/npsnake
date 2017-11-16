using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSnake.Model
{
    /// <summary>
    /// Represents a state of the Snake game.
    /// Intended for communication between the Model and View layers.
    /// </summary>
    interface IGameState
    {
        /// <summary>
        /// Gets the size of the board.
        /// </summary>
        /// <value>
        /// The size of the board.
        /// </value>
        Int32 BoardSize { get; }

        /// <summary>
        /// Gets the tiles of the obstacles.
        /// </summary>
        /// <value>
        /// The tiles of the obstacles.
        /// </value>
        IEnumerable<ITile> Obstacles { get; }

        /// <summary>
        /// Gets the tiles of the the snake body.
        /// </summary>
        /// <value>
        /// The tiles of the snake body.
        /// </value>
        IEnumerable<ITile> SnakeBody { get; }

        /// <summary>
        /// Gets the tile of the egg that's currently on the board.
        /// </summary>
        /// <value>
        /// The tile of the egg.
        /// </value>
        ITile Egg { get; }
    }
}
