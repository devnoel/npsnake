using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPSnake.Persistance;

namespace NPSnake.Model
{
    public interface IModel
    {
        //TODO add events        
        /// <summary>
        /// Sets the persistance object used by model.
        /// </summary>
        /// <param name="persistance">The persistance object.</param>
        void SetPersistance(IPersistance persistance);

        /// <summary>
        /// Gets the available levels of the game.
        /// </summary>
        /// <returns>The levels.</returns>
        IEnumerable<ILevel> GetLevels();

        /// <summary>
        /// Selects the level of the game by its id.
        /// </summary>
        /// <param name="levelId">The level identifier.</param>
        void SelectLevel(Int32 levelId);

        /// <summary>
        /// Starts the game.
        /// </summary>
        void StartGame();

        /// <summary>
        /// Turns the snake left.
        /// </summary>
        void TurnSnakeLeft();

        /// <summary>
        /// Turns the snake right.
        /// </summary>
        void TurnSnakeRight();

        /// <summary>
        /// Turns the snake back forward if it was turned left or right
        /// since the last state change event.
        /// </summary>
        void TurnSnakeForward();

        /// <summary>
        /// Pauses the game or resumes it if it was already paused.
        /// The remaining game-time until the next state change is the same
        /// at the pause start and at the pause end.
        /// </summary>
        void TogglePause();
    }
}
