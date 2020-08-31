using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Linq;

namespace Snake
{
    public class Game
    {
        const int columns = 100;
        const int rows = 60;
        readonly Collection<Position> allPositions = new Collection<Position>();
        int milisecondsBetweenFrames = 1000;
        public Snake snake = new Snake(rows, columns);
        public Food food = new Food();

        public Game()
        {
            LoadAllPositions();
            food.SetPositionAndValue(GetNewPositionForFood());
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

        public Position GetNewPositionForFood()
        {
            int k = (new Random()).Next(1, columns * rows - snake.GetLength - 1);
            return allPositions.Except(snake.GetBodyPositions())
                               .OrderBy(x => x)
                               .Skip(k - 1)
                               .First();
        }

        public bool NextFrame()
        {
            var nextSnakePosition = snake.GetNextPosition();
            Debug.Print(nextSnakePosition.ToString());
            if (nextSnakePosition.Equals(food.Position))
            {
                snake.Eat(food);
                food.SetPositionAndValue(GetNewPositionForFood());
            }

            snake.Move(nextSnakePosition);

            if (nextSnakePosition.IsOutOfGame(columns, rows) || snake.GetBodyPositions().Contains(snake.Head.position, new PositionComparer()))
            {
                //game over
                return false;
            }

            return true;
        }
    }
}
