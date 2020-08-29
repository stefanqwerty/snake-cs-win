using System;

namespace Snake
{
    public class Food
    {
        public int Value { get; private set; }
        public Position Position { get; private set; }

        public Food()
        {
            Value = 0;
        }

        public void SetPositionAndValue(Position position)
        {
            Position = position;
            SetNextFoodValue();
        }

        private void SetNextFoodValue()
        {
            Value++;
        }
    }
}
