using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace snake
{
    public class Game
    {
        const int rows = 150;
        const int columns = 200;
        Collection<Position> allPositions = new Collection<Position>();
        int milisecondsBetweenFrames = 1000;
        public Snake snake = new Snake(rows, columns);
        public Food food = new Food();

        public class Position : IComparable
        {
            public int column;
            public int row;

            public Position(int sendColumn, int sendRow) => (column, row) = (sendColumn, sendRow);

            public int CompareTo(object obj) => 0;

            public bool Equals(Position other) => column == other.column && row == other.row;
        }

        private bool IsPositionOutOfGame(Position position) => position.row < 0
                                                            && position.row >= rows
                                                            && position.column < 0
                                                            && position.column >= columns;

        //enum MoveResult
        //{
        //    Moved,
        //    Eat,
        //    Dead
        //}

        public class Snake
        {
            public int lenght = 0;
            public SnakeElement head;
            public Direction direction;

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
                head = new SnakeElement(new Position(columns / 2, rows / 2));       

                lenght = 1;
                direction = Direction.up;
            }

            public Collection<Position> GetAllPositions()
            {
                var result = new Collection<Position>();
                var currentSnakeElement = head;
                while (!(currentSnakeElement is null))
                {
                    result.Add(currentSnakeElement.position);
                    currentSnakeElement = currentSnakeElement.next;
                }

                return result;
            }

            public Position GetNextPosition()
            {
                switch (direction)
                {
                    case Direction.up:
                        return new Position(head.position.column, head.position.row - 1);
                    case Direction.down:
                        return new Position(head.position.column, head.position.row + 1);
                    case Direction.left:
                        return new Position(head.position.column - 1, head.position.row);
                    case Direction.right:
                        return new Position(head.position.column + 1, head.position.row - 1);
                    default:
                        return null;
                }
            }
        }

        public class Food
        {
            public Position position;
            public int value;

            public Food()
            {
                value = 1;
            }
        }

        public bool NextFrame()
        {
            var nextSnakePosition = snake.GetNextPosition();

            if (IsPositionOutOfGame(nextSnakePosition) || snake.GetAllPositions().Contains(nextSnakePosition))
            {
                //game over
                return false;
            }

            if (nextSnakePosition.Equals(food.position))
            {
                void grow(int n)
                {
                    Snake x = new Snake();
                    snake.lenght += n;
                    while (n > 0)
                    {
                        snake.head.position = x.GetNextPosition();
                        
                        n--;
                    }
                }
                grow(food.value);
                food.position = GetNewPositionForFood();
            }
            return true;
        }

        public void main()
        {
            //initialize game:
            //generate snake (position, direction)
            //generate food positon

            //main loop:
            //draw     
            //wait System.Threading.Thread.Sleep(milisecondsBetweenFrames);
            //get move result

            //if dead:
            //end

            //if the food was eaten:
            //snake.grow
            //generate new food position


            //increase the speed 
        }

        public Game()
        {
            LoadAllPositions();
            food.position = GetNewPositionForFood();
        }

        private void LoadAllPositions()
        {
            for (var i = 0; i < columns; i++)
            {
                for (var j = 0; j < rows; j++)
                {
                    allPositions.Add(new Position(i, j));
                }
            }
        }

        public void mainLoop()
        {
            //draw
            System.Threading.Thread.Sleep(milisecondsBetweenFrames);
            NextFrame();
            milisecondsBetweenFrames--;
        }



        public Position GetNewPositionForFood()
        {
            int k = (new Random()).Next(1, columns * rows - snake.lenght - 1);
            return allPositions.Except(snake.GetAllPositions())
                               .OrderBy(x => x)
                               .Skip(k - 1)
                               .First();
        }
    }
}
