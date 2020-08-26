using System;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml;
using System.Windows.Input;
using System.Drawing;
using System.Resources;

namespace snake
{
    public partial class Form1 : Form
    {
        Color inactiveColor = SystemColors.ControlDark;
        Color activeColor = Color.Green;

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

        Game g = new Game();

        private void SwitchBackColor(Keys key, Color color)
        {
            switch (key)
            {
                case Keys.Up:
                    g.snake.direction = Game.Snake.Direction.up;
                    break;
                case Keys.Down:
                    g.snake.direction = Game.Snake.Direction.down;
                    break;
                case Keys.Left:
                    g.snake.direction = Game.Snake.Direction.left;
                    break;
                case Keys.Right:
                    g.snake.direction = Game.Snake.Direction.right;
                    break;
            }

        }
    }
}
