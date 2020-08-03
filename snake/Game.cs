using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Game
    {
        const int rows = 150;
        const int columns = 200;
        Collection<Position> allPositions = new Collection<Position>();
        int milisecondsBetweenFrames = 1000;
        Snake snake = new Snake(rows, columns);
        Position food;

        public enum Direction
        {
            up,
            right,
            down,
            left
        }

        public class Position
        {
            public int column;

            public int row;

            public Position()
            {
            }

            public Position(int sendColumn, int sendRow) => (column, row) = (sendColumn, sendRow);

            public bool Equals(Position other)
            {
                return column == other.column && row == other.row;
            }

            public Position Get(Direction direction)
            {
                switch (direction)
                {
                    case Direction.up:
                        return new Position(column, row - 1);
                    case Direction.down:
                        return new Position(column, row + 1);
                    case Direction.left:
                        return new Position(column - 1, row);
                    case Direction.right:
                        return new Position(column + 1, row - 1);
                    default:
                        return null;
                }
            }
        }

        enum MoveResult
        {
            Moved,
            Eat,
            Dead
        }

        class Snake
        {
            public int lenght = 0;

            public class SnakeElement
            {
                public Position position;
                public SnakeElement next;
            }

            public SnakeElement head;
            Direction direction;

            public Snake(int rows, int columns)
            {
                head.position = new Position(columns / 2, rows / 2);
                lenght = 1;
                direction = Direction.up;
            }

            public Collection<Position> GetAllPositions()
            {
                var result = new Collection<Position>();
                var currentSnakeElement = head;
                result.Add(head.position);
                while (!(currentSnakeElement is null))
                {
                    result.Add(currentSnakeElement.position);
                    currentSnakeElement = currentSnakeElement.next;
                }

                return result;
            }
        }

        public bool NextFrame()
        {
            var nextHeadPosition = snake.head.position;

            if (food.column == snake.head.position.column)
            {
                //add block
                food = GetNewPositionForFood();
            }
            if ( == snake.GetAllPositions())
            {
                return false;
                //game over
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
            snake = new Snake(columns, rows);
            food = GetNewPositionForFood();
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
