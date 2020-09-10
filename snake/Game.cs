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
        readonly Collection<Position> allPosibleFoodPositions = new Collection<Position>();
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
            for (var i = 1; i < columns - 1; i++)
            {
                for (var j = 1; j < rows - 1; j++)
                {
                    allPosibleFoodPositions.Add(new Position(i, j));
                }
            }
        }

        public Position GetNewPositionForFood()
        {
            var avoidSkippingAllPositions = 2;
            int k = (new Random()).Next(1, allPosibleFoodPositions.Count - snake.GetLength - avoidSkippingAllPositions);
            return allPosibleFoodPositions.Except(snake.GetBodyPositions())
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
