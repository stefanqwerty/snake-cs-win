namespace snake
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
            this.labelUp = new System.Windows.Forms.Label();
            this.labelRight = new System.Windows.Forms.Label();
            this.labelDown = new System.Windows.Forms.Label();
            this.labelLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUp
            // 
            this.labelUp.AutoSize = true;
            this.labelUp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelUp.Location = new System.Drawing.Point(464, 70);
            this.labelUp.Name = "labelUp";
            this.labelUp.Size = new System.Drawing.Size(21, 21);
            this.labelUp.TabIndex = 0;
            this.labelUp.Text = " ";
            // 
            // labelRight
            // 
            this.labelRight.AutoSize = true;
            this.labelRight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelRight.Location = new System.Drawing.Point(831, 229);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(21, 21);
            this.labelRight.TabIndex = 3;
            this.labelRight.Text = " ";
            // 
            // labelDown
            // 
            this.labelDown.AutoSize = true;
            this.labelDown.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelDown.Location = new System.Drawing.Point(464, 375);
            this.labelDown.Name = "labelDown";
            this.labelDown.Size = new System.Drawing.Size(21, 21);
            this.labelDown.TabIndex = 4;
            this.labelDown.Text = " ";
            // 
            // labelLeft
            // 
            this.labelLeft.AutoSize = true;
            this.labelLeft.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelLeft.Location = new System.Drawing.Point(96, 229);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(21, 21);
            this.labelLeft.TabIndex = 5;
            this.labelLeft.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 500);
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
    }
}

