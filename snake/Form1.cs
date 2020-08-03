using System;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml;
using System.Windows.Input;
using System.Drawing;

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

        private void SwitchBackColor(Keys key, Color color)
        {
            switch (key)
            {
                case Keys.Up:
                    labelUp.BackColor = color;
                    break;
                case Keys.Down:
                    labelDown.BackColor = color;
                    break;
                case Keys.Left:
                    labelLeft.BackColor = color;
                    break;
                case Keys.Right:
                    labelRight.BackColor = color;
                    break;
            }

        }
    }
}
