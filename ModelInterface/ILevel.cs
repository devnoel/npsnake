using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSnake.Model
{
    /// <summary>
    /// Represents a level of the Snake game.
    /// Intended for communication between the Model and View layers.
    /// </summary>
    interface ILevel
    {
        /// <summary>
        /// Gets the identifier of the level.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        Int32 Id { get; }

        /// <summary>
        /// Gets the name of the level.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        String Name { get; }

        /// <summary>
        /// Gets the size of the level's board.
        /// </summary>
        /// <value>
        /// The size of the board.
        /// </value>
        Int32 BoardSize { get; }
    }
}
