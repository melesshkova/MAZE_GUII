namespace Labitint
{
    partial class GameRules
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Back = new Button();
            Start = new Button();
            Quit = new Button();
            textBox4 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightPink;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Book Antiqua", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(24, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(558, 33);
            textBox2.TabIndex = 0;
            textBox2.Text = " > Use the arrow keys or WASD to move";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightPink;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Book Antiqua", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(24, 179);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(558, 33);
            textBox3.TabIndex = 2;
            textBox3.Text = " > Try to reach the goal";
            // 
            // Back
            // 
            Back.BackColor = Color.LavenderBlush;
            Back.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.DeepPink;
            Back.Location = new Point(12, 401);
            Back.Name = "Back";
            Back.Size = new Size(96, 37);
            Back.TabIndex = 5;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Start
            // 
            Start.BackColor = Color.LavenderBlush;
            Start.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Start.ForeColor = Color.DeepPink;
            Start.Location = new Point(343, 401);
            Start.Name = "Start";
            Start.Size = new Size(96, 37);
            Start.TabIndex = 6;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click;
            // 
            // Quit
            // 
            Quit.BackColor = Color.LavenderBlush;
            Quit.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Quit.ForeColor = Color.DeepPink;
            Quit.Location = new Point(692, 401);
            Quit.Name = "Quit";
            Quit.Size = new Size(96, 37);
            Quit.TabIndex = 7;
            Quit.Text = "Quit";
            Quit.UseVisualStyleBackColor = false;
            Quit.Click += Quit_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LightPink;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Book Antiqua", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(24, 218);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(558, 33);
            textBox4.TabIndex = 9;
            textBox4.Text = " > Collect coins and keys to open the doors";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(227, 60);
            label1.Name = "label1";
            label1.Size = new Size(289, 56);
            label1.TabIndex = 16;
            label1.Text = "Game Rules:";
            // 
            // GameRules
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(Quit);
            Controls.Add(Start);
            Controls.Add(Back);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Name = "GameRules";
            Text = "Rules";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox3;
        private Button Back;
        private Button Start;
        private Button Quit;
        private TextBox textBox4;
        private Label label1;
    }
}