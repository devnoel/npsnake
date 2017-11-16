using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPSnake.Model
{
    class Snake
    {
        private Move previousMove;
        private Move nextMove;
        private ITile head;
        private Queue<ITile> body;

        public Int32 Length { get { return body.Count; } }

        public IEnumerable<ITile> Body { get { return new List<ITile>(body.Reverse()); } }

        public Snake(IEnumerable<ITile> body)
        {
            if(body == null)
                throw new ArgumentException("The snake's body should not be null.");
            this.body = new Queue<ITile>(body.Reverse());
            if (this.body.Count == 0)
                throw new ArgumentException("The snake's body should contain at least one element.");

            SetHeadAndMoveFromBody(body);
        }

        private void SetHeadAndMoveFromBody(IEnumerable<ITile> body)
        {
            var enumerator = body.GetEnumerator();
            enumerator.MoveNext();
            head = enumerator.Current;
            if (enumerator.MoveNext())
            {
                ITile neck = enumerator.Current;
                var moveTile = new Tile(head.XIndex - neck.XIndex, head.YIndex - neck.YIndex);
                nextMove = new Move(moveTile);
            }
            else
            {
                nextMove = Move.Up;
            }
            previousMove = nextMove;
        }

        public void MoveOn()
        {
            MoveOnAndGrow();
            Shrink();
        }

        private void Shrink()
        {
            body.Dequeue();
        }

        public void MoveOnAndGrow()
        {
            head = nextMove.From(head);
            body.Enqueue(head);
            previousMove = nextMove;
        }

        public void Turn(Direction direction)
        {
            nextMove = previousMove.Rotate(direction);
        }
    }
}
