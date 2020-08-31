using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        Color inactiveColor = SystemColors.ControlDark;
        Color activeColor = Color.Green;
        const int blockSize = 16;
        Game g = new Game();
        Label food;
        List<Label> snake = new List<Label>();

        public Form1()
        {
            InitializeComponent();
            food = CreateLabel("", Color.Red);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            SwitchBackColor(e.KeyCode, activeColor);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            SwitchBackColor(e.KeyCode, inactiveColor);
        }

        private void SwitchBackColor(Keys key, Color color)
        {
            Snake.Direction newDirection = new Snake.Direction();
            switch (key)
            {
                case Keys.Up:
                    newDirection = Snake.Direction.up;
                    labelUp.BackColor = color;
                    break;
                case Keys.Down:
                    newDirection = Snake.Direction.down;
                    labelDown.BackColor = color;
                    break;
                case Keys.Left:
                    newDirection = Snake.Direction.left;
                    labelLeft.BackColor = color;
                    break;
                case Keys.Right:
                    newDirection = Snake.Direction.right;
                    labelRight.BackColor = color;
                    break;
            }
            g.snake.TryChangeDirection(newDirection);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            headLeft.Text = convert(g.snake.Head.position.column).ToString();
            headTop.Text = convert(g.snake.Head.position.row).ToString();
            gameSnakeLength.Text = g.snake.GetLength.ToString();
            formSnakeLength.Text = snake.Count.ToString();
            if (g.NextFrame())
            {
                RefreshSnake();
                RefreshLabelLocation(food, g.food.Position);
            }
            else
            {
                Application.Exit();
            }
        }

        private void RefreshSnake()
        {
            AlignSnakes();
            RefreshSnakeLocations();
        }

        private void AlignSnakes()
        {
            for (int i = 0; i < g.snake.GetLength - snake.Count; i++)
            {
                snake.Add(CreateLabel($"{snake.Count}"));
            }
        }

        private void RefreshSnakeLocations()
        {
            var i = 0;
            var snakeElement = g.snake.Head;
            while (snakeElement != null)
            { 
                RefreshLabelLocation(snake[i++], snakeElement.position);
                snakeElement = snakeElement.next;
            }
        }

        private void RefreshLabelLocation(Label label, Position position)
        {
            var oldPosition = new Position(label.Left, label.Top);
            var convertedNewPosition = new Position(convert(position.column), convert(position.row));
            if (!oldPosition.Equals(convertedNewPosition))
            {
                label.Left = convertedNewPosition.column;
                label.Top = convertedNewPosition.row;
            }
        }

        private Label CreateLabel(string name, Color? backColor = null)
        {
            var label = new Label()
            {
                BackColor = backColor ?? Color.FromArgb(255, 192, 128),
                Location = new Point(460, 300),
                Name = name,
                Size = new Size(blockSize, blockSize),
                Visible = true
            };

            Controls.Add(label);
            return label;
        }

        private int convert(int pos) => blockSize * pos;
    }
}