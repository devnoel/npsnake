using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPSnake.Model
{
    class Level : ILevel
    {
        public Int32 Id { get; internal set; }
        public String Name { get; internal set; }
        public Int32 BoardSize { get; internal set; }

        public Level() { }
    }
}
