using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPSnake.Persistance
{
    /// <summary>
    /// Data source of the game.
    /// Provides data of saved game configurations.
    /// </summary>
    public interface IPersistance
    {
        /// <summary>
        /// Loads all games.
        /// </summary>
        /// <returns>The games.</returns>
        IEnumerable<IGameLoad> LoadGames();

        /// <summary>
        /// Loads one game by its identifier.
        /// </summary>
        /// <param name="id">The game's identifier.</param>
        /// <returns>The game.</returns>
        IGameLoad LoadGameById(Int32 id);
    }
}
