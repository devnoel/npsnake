using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPSnake.Persistance
{
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
