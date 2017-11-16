using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPSnake.Persistance
{
    /// <summary>
    /// Represents a game setup of the Snake game.
    /// Intended for communication between the Persistance and Model layers.
    /// </summary>
    public interface IGameLoad
    {
        /// <summary>
        /// Gets the size of the board.
        /// </summary>
        /// <value>
        /// The size of the board.
        /// </value>
        Int32 BoardSize { get; }

        /// <summary>
        /// Gets the positions of the obstacles on the board.
        /// </summary>
        /// <value>
        /// The positions of the obstacles.
        /// </value>
        IEnumerable<IPosition> Obstacles { get; }

        /// <summary>
        /// Gets the positions of the the snake body.
        /// </summary>
        /// <value>
        /// The positions of the snake body.
        /// </value>
        IEnumerable<IPosition> SnakeBody { get; }
    }
}
