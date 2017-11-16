using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPSnake.Persistance
{
    /// <summary>
    /// Represents a position on the board in the Snake game.
    /// </summary>
    public interface IPosition
    {
        /// <summary>
        /// Gets the horizontal index of the position.
        /// </summary>
        /// <value>
        /// The horizontal index.
        /// </value>
        Int32 XIndex { get; }

        /// <summary>
        /// Gets the vertical index of the position.
        /// </summary>
        /// <value>
        /// The vertical index.
        /// </value>
        Int32 YIndex { get; }
    }
}
