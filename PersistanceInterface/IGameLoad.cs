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
        /// Gets the identifier of the loaded game.
        /// </summary>
        /// <value>
        /// The identifier of the game.
        /// </value>
        Int32 Id { get; }

        /// <summary>
        /// Gets the name of the loaded game.
        /// </summary>
        /// <value>
        /// The name of the game.
        /// </value>
        String Name { get; }

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
