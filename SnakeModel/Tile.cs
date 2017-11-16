using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPSnake.Model
{
    class Tile : ITile
    {
        public Tile(Int32 x, Int32 y)
        {
            XIndex = x;
            YIndex = y;
        }

        public Int32 XIndex { get; }
        public Int32 YIndex { get; }
    }
}
