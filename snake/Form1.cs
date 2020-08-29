using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        Color inactiveColor = SystemColors.ControlDark;
        Color activeColor = Color.Green;
        Game g = new Game();

        public Form1()
        {
            InitializeComponent();
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
            head.Left = convert(g.snake.Head.position.column);
            head.Top = convert(g.snake.Head.position.row);

            headLeft.Text = head.Left.ToString();
            headTop.Text = head.Top.ToString();
            g.NextFrame();
        }

        private int convert(int pos) => head.Width * pos;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Food_Click(object sender, EventArgs e)
        {

        }
    }
}