using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        readonly Color InactiveColor = SystemColors.ControlDark;
        readonly Color ActiveColor = Color.Green;
        readonly string[] CounterStrings = new string[] { "3", "2", "1", "START", "" };
        const int BlockSize = 16;
        bool Pause = false;
        public int FrameNumber = 0;
        readonly Game MyGame = new Game();
        readonly Label Food;
        List<Label> MySnake = new List<Label>();

        public Form1()
        {
            InitializeComponent();
            Cursor.Hide();
            Food = CreateLabel("", Color.Red);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            SwitchBackColor(e.KeyCode, ActiveColor);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            SwitchBackColor(e.KeyCode, InactiveColor);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32 || e.KeyChar == 27)
            {
                Pause = !Pause;
            }
        }

        private void SwitchBackColor(Keys key, Color color)
        {
            bool? _ = key switch
            {
                Keys.Up => NewDirectionRequsted(Snake.Direction.up, labelUp, color),
                Keys.Down => NewDirectionRequsted(Snake.Direction.down, labelDown, color),
                Keys.Left => NewDirectionRequsted(Snake.Direction.left, labelLeft, color),
                Keys.Right => NewDirectionRequsted(Snake.Direction.right, labelRight, color),
                _ => null
            };

        }

        private bool NewDirectionRequsted(Snake.Direction newDirection, Label label, Color color)
        {
            label.BackColor = color;
            return MyGame.snake.TryChangeDirection(newDirection);
        }

        private void Tick(object sender, EventArgs e)
        {
            if (Pause)
            {
                return;
            }

            if (MyGame.NextFrame())
            {
                RefreshSnake();
                RefreshLabelLocation(Food, MyGame.food.Position);
                gameSnakeLength.Text = MyGame.snake.GetLength.ToString();
                return;
            }

            Application.Exit();
        }

        private void Count(object sender, EventArgs e)
        {
            countdownLabel.Text = CounterStrings[FrameNumber].PadLeft(3);
            System.Threading.Thread.Sleep(800);
            FrameNumber++;
            if (FrameNumber == 5)
            {
                countdownLabel.Visible = false;
                timer1.Tick -= new System.EventHandler(Count);
                timer1.Tick += new System.EventHandler(Tick);
            }
        }

        private void RefreshSnake()
        {
            AlignSnakes();
            RefreshSnakeLocations();
        }

        private void AlignSnakes()
        {
            var count = MySnake.Count;
            for (int i = 0; i < MyGame.snake.GetLength - count; i++)
            {
                MySnake.Add(CreateLabel($"{MySnake.Count}"));
            }
        }

        private void RefreshSnakeLocations()
        {
            var i = 0;
            var snakeElement = MyGame.snake.Head;
            while (snakeElement != null)
            { 
                RefreshLabelLocation(MySnake[i++], snakeElement.position);
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
                BackColor = backColor ?? Color.FromArgb(100, 255, 100),
                Location = new Point(460, 300),
                Name = name,
                Size = new Size(BlockSize, BlockSize),
                Visible = true
            };

            Controls.Add(label);
            return label;
        }

        private int convert(int pos) => 32 + BlockSize * pos;
    }
}