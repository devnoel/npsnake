using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPSnake.Persistance;

namespace NPSnake.Model
{
    class Tile : ITile
    {
        public Int32 XIndex { get; }
        public Int32 YIndex { get; }

        public Tile(Int32 x, Int32 y)
        {
            XIndex = x;
            YIndex = y;
        }

        public static Tile FromPosition(IPosition pos)
        {
            return new Tile(pos.XIndex, pos.YIndex);
        }

        public override string ToString()
        {
            return "[" + XIndex + ", " + YIndex + "]";
        }

        public override bool Equals(object obj)
        {
            var tile = obj as Tile;
            if (tile == null)
                return false;
            else
                return XIndex.Equals(tile.XIndex) &&
                    YIndex.Equals(tile.YIndex);
        }
    }
}
