using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPSnake.Model
{
    /// <summary>
    /// Represents a tile of the board in the Snake game.
    /// </summary>
    public interface ITile
    {
        /// <summary>
        /// Gets the horizontal index of the tile.
        /// </summary>
        /// <value>
        /// The horizontal index.
        /// </value>
        Int32 XIndex { get; }

        /// <summary>
        /// Gets the vertical index of the tile.
        /// </summary>
        /// <value>
        /// The vertical index.
        /// </value>
        Int32 YIndex { get; }
    }
}
