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
            this.labelUp = new System.Windows.Forms.Label();
            this.labelRight = new System.Windows.Forms.Label();
            this.labelDown = new System.Windows.Forms.Label();
            this.labelLeft = new System.Windows.Forms.Label();
            this.head = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.headLeft = new System.Windows.Forms.Label();
            this.headTop = new System.Windows.Forms.Label();
            this.Food = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUp
            // 
            this.labelUp.AutoSize = true;
            this.labelUp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelUp.Location = new System.Drawing.Point(964, -2);
            this.labelUp.Name = "labelUp";
            this.labelUp.Size = new System.Drawing.Size(21, 21);
            this.labelUp.TabIndex = 0;
            this.labelUp.Text = " ";
            // 
            // labelRight
            // 
            this.labelRight.AutoSize = true;
            this.labelRight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelRight.Location = new System.Drawing.Point(987, 21);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(21, 21);
            this.labelRight.TabIndex = 3;
            this.labelRight.Text = " ";
            // 
            // labelDown
            // 
            this.labelDown.AutoSize = true;
            this.labelDown.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelDown.Location = new System.Drawing.Point(964, 43);
            this.labelDown.Name = "labelDown";
            this.labelDown.Size = new System.Drawing.Size(21, 21);
            this.labelDown.TabIndex = 4;
            this.labelDown.Text = " ";
            // 
            // labelLeft
            // 
            this.labelLeft.AutoSize = true;
            this.labelLeft.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelLeft.Location = new System.Drawing.Point(941, 21);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(21, 21);
            this.labelLeft.TabIndex = 5;
            this.labelLeft.Text = " ";
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.head.Location = new System.Drawing.Point(460, 300);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(16, 16);
            this.head.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // headLeft
            // 
            this.headLeft.AutoSize = true;
            this.headLeft.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLeft.Location = new System.Drawing.Point(900, 11);
            this.headLeft.Name = "headLeft";
            this.headLeft.Size = new System.Drawing.Size(16, 17);
            this.headLeft.TabIndex = 7;
            this.headLeft.Text = "0";
            // 
            // headTop
            // 
            this.headTop.AutoSize = true;
            this.headTop.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headTop.Location = new System.Drawing.Point(901, 31);
            this.headTop.Name = "headTop";
            this.headTop.Size = new System.Drawing.Size(16, 17);
            this.headTop.TabIndex = 8;
            this.headTop.Text = "0";
            // 
            // Food
            // 
            this.Food.BackColor = System.Drawing.Color.Red;
            this.Food.Location = new System.Drawing.Point(512, 256);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(16, 16);
            this.Food.TabIndex = 9;
            this.Food.Click += new System.EventHandler(this.Food_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.headTop);
            this.Controls.Add(this.headLeft);
            this.Controls.Add(this.head);
            this.Controls.Add(this.labelLeft);
            this.Controls.Add(this.labelDown);
            this.Controls.Add(this.labelRight);
            this.Controls.Add(this.labelUp);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sarpiliii";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUp;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.Label labelDown;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.Label head;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label headLeft;
        private System.Windows.Forms.Label headTop;
        private System.Windows.Forms.Label Food;
    }
}

