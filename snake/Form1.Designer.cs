namespace Snake
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelRight = new System.Windows.Forms.Label();
            this.labelDown = new System.Windows.Forms.Label();
            this.labelLeft = new System.Windows.Forms.Label();
            this.labelUp = new System.Windows.Forms.Label();
            this.gameSnakeLength = new System.Windows.Forms.Label();
            this.countdownLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.Count);
            // 
            // labelRight
            // 
            this.labelRight.BackColor = System.Drawing.Color.Gray;
            this.labelRight.Location = new System.Drawing.Point(1632, 32);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(32, 960);
            this.labelRight.TabIndex = 13;
            this.labelRight.Text = " ";
            // 
            // labelDown
            // 
            this.labelDown.BackColor = System.Drawing.Color.Gray;
            this.labelDown.Location = new System.Drawing.Point(32, 992);
            this.labelDown.Name = "labelDown";
            this.labelDown.Size = new System.Drawing.Size(1600, 32);
            this.labelDown.TabIndex = 14;
            this.labelDown.Text = " ";
            // 
            // labelLeft
            // 
            this.labelLeft.BackColor = System.Drawing.Color.Gray;
            this.labelLeft.ForeColor = System.Drawing.Color.White;
            this.labelLeft.Location = new System.Drawing.Point(0, 32);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(32, 960);
            this.labelLeft.TabIndex = 15;
            this.labelLeft.Text = " ";
            // 
            // labelUp
            // 
            this.labelUp.BackColor = System.Drawing.Color.Gray;
            this.labelUp.Location = new System.Drawing.Point(32, 0);
            this.labelUp.Name = "labelUp";
            this.labelUp.Size = new System.Drawing.Size(1600, 32);
            this.labelUp.TabIndex = 16;
            this.labelUp.Text = " ";
            // 
            // gameSnakeLength
            // 
            this.gameSnakeLength.AutoSize = true;
            this.gameSnakeLength.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameSnakeLength.ForeColor = System.Drawing.Color.Yellow;
            this.gameSnakeLength.Location = new System.Drawing.Point(1546, 901);
            this.gameSnakeLength.Name = "gameSnakeLength";
            this.gameSnakeLength.Size = new System.Drawing.Size(16, 17);
            this.gameSnakeLength.TabIndex = 10;
            this.gameSnakeLength.Text = "0";
            // 
            // countdownLabel
            // 
            this.countdownLabel.Font = new System.Drawing.Font("Courier New", 240F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel.ForeColor = System.Drawing.Color.Green;
            this.countdownLabel.Location = new System.Drawing.Point(318, 183);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(1137, 652);
            this.countdownLabel.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1664, 1024);
            this.ControlBox = false;
            this.Controls.Add(this.countdownLabel);
            this.Controls.Add(this.labelUp);
            this.Controls.Add(this.labelLeft);
            this.Controls.Add(this.labelDown);
            this.Controls.Add(this.labelRight);
            this.Controls.Add(this.gameSnakeLength);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snek";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.Label labelDown;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.Label labelUp;
        private System.Windows.Forms.Label gameSnakeLength;
        private System.Windows.Forms.Label countdownLabel;
    }
}

