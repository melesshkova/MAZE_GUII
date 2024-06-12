namespace Labitint
{
    partial class Pause
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
            PauseTime = new TextBox();
            Continue = new Button();
            Quit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // PauseTime
            // 
            PauseTime.BackColor = Color.LightPink;
            PauseTime.BorderStyle = BorderStyle.None;
            PauseTime.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PauseTime.ForeColor = Color.White;
            PauseTime.Location = new Point(306, 149);
            PauseTime.Name = "PauseTime";
            PauseTime.Size = new Size(199, 28);
            PauseTime.TabIndex = 2;
            PauseTime.Text = "Time left: ";
            // 
            // Continue
            // 
            Continue.BackColor = Color.LavenderBlush;
            Continue.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Continue.ForeColor = Color.DeepPink;
            Continue.Location = new Point(12, 394);
            Continue.Name = "Continue";
            Continue.Size = new Size(168, 44);
            Continue.TabIndex = 3;
            Continue.Text = "Continue";
            Continue.UseVisualStyleBackColor = false;
            Continue.Click += Continue_Click;
            // 
            // Quit
            // 
            Quit.BackColor = Color.LavenderBlush;
            Quit.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Quit.ForeColor = Color.DeepPink;
            Quit.Location = new Point(625, 394);
            Quit.Name = "Quit";
            Quit.Size = new Size(163, 44);
            Quit.TabIndex = 4;
            Quit.Text = "Quit";
            Quit.UseVisualStyleBackColor = false;
            Quit.Click += Quit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(283, 55);
            label1.Name = "label1";
            label1.Size = new Size(161, 56);
            label1.TabIndex = 16;
            label1.Text = "Pause:";
            // 
            // Pause
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Quit);
            Controls.Add(Continue);
            Controls.Add(PauseTime);
            Name = "Pause";
            Text = "Pause";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox PauseTime;
        private Button Continue;
        private Button Quit;
        private Label label1;
    }
}