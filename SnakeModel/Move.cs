using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPSnake.Model
{
    class Move
    {
        private ITile step;

        public static Move Up
        {
            get { return new Move(new Tile(0, -1)); }
        }

        public static Move Down
        {
            get { return new Move(new Tile(0, 1)); }
        }

        public static Move Left
        {
            get { return new Move(new Tile(-1, 0)); }
        }

        public static Move Right
        {
            get { return new Move(new Tile(1, 0)); }
        }

        public Move(ITile step)
        {
            this.step = step;
        }

        public Move(Move move)
        {
            step = move.step;
        }

        public Move Rotate(Direction dir)
        {
            Int32 newX = step.XIndex;
            Int32 newY = step.YIndex;
            switch (dir)
            {
                case Direction.Left:
                    newX = step.YIndex;
                    newY = -1 * step.XIndex;
                    break;
                case Direction.Right:
                    newX = -1 * step.YIndex;
                    newY = step.XIndex;
                    break;
            }
            var newStep = new Tile(newX, newY);
            return new Move(newStep);
        }

        public ITile From(ITile from)
        {
            return new Tile(from.XIndex + step.XIndex, from.YIndex + step.YIndex);
        }

        public override string ToString()
        {
            return step.ToString();
        }

        public override bool Equals(object obj)
        {
            var move = obj as Move;
            if (move == null)
                return false;
            else
                return step.Equals(move.step);
        }
    }
}
