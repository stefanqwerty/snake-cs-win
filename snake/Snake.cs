using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Snake
{
    public class Snake
    {
        private SnakeElement head;
        private int growfactor = 2;
        public Direction direction;
        
        public SnakeElement Head { get => head; private set { head = value; GetLength++; } }

        public int GetLength { get; private set; } = 0;

        public Snake()
        {
        }

        public enum Direction
        {
            up,
            right,
            down,
            left
        }

        public class SnakeElement
        {
            public Position position;
            public SnakeElement next;

            public SnakeElement(Position sendPosition)
            {
                position = sendPosition;
            }
        }

        public Snake(int rows, int columns)
        {
            Head = new SnakeElement(new Position(columns / 2, rows / 2));

            //GetLength = 1;
            direction = Direction.up;
        }

        public void Move(Position position)
        {
            if (growfactor > 0)
            {
                growfactor--;
                GrowNewHead(position);
                return;
            }

            var currentElement = head;
            var newNextPosition = currentElement.position;
            while (currentElement.next != null)
            {
                var temp = currentElement.next.position;
                currentElement.next.position = newNextPosition;
                newNextPosition = temp;
                currentElement = currentElement.next;
            }

            head.position = position;
        }

        public bool TryChangeDirection(Direction newDirection)
        {
            if ((newDirection == Direction.up && direction == Direction.down)
             || (newDirection == Direction.right && direction == Direction.left)
             || (newDirection == Direction.down && direction == Direction.up)
             || (newDirection == Direction.left && direction == Direction.right))
            {
                return false;
            }

            direction = newDirection;
            
            return true;
        }

        public void GrowNewHead(Position position)
        {
            var element = new SnakeElement(position);
            element.next = Head;
            Head = element;
        }

        public Collection<Position> GetBodyPositions()
        {
            var result = new Collection<Position>();
            var currentSnakeElement = Head.next;
            while (currentSnakeElement != null)
            {
                result.Add(currentSnakeElement.position);
                currentSnakeElement = currentSnakeElement.next;
            }

            return result;
        }

        internal void Eat(Food food)
        {
            growfactor += food.Value;
        }

        public Position GetNextPosition()
        {
            return direction switch
            {
                Direction.up => new Position(Head.position.column, Head.position.row - 1),
                Direction.right => new Position(Head.position.column + 1, Head.position.row),
                Direction.down => new Position(Head.position.column, Head.position.row + 1),
                Direction.left => new Position(Head.position.column - 1, Head.position.row),
                _ => null
            };
        }
    }
}
