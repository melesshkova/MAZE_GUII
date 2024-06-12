namespace Labitint
{
    partial class Choose_Level
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose_Level));
            Back = new Button();
            Quit = new Button();
            Level1 = new Button();
            Level2 = new Button();
            Level3 = new Button();
            Random = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.LavenderBlush;
            Back.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.DeepPink;
            Back.Location = new Point(12, 401);
            Back.Name = "Back";
            Back.Size = new Size(96, 37);
            Back.TabIndex = 6;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Quit
            // 
            Quit.BackColor = Color.LavenderBlush;
            Quit.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Quit.ForeColor = Color.DeepPink;
            Quit.Location = new Point(692, 401);
            Quit.Name = "Quit";
            Quit.Size = new Size(96, 37);
            Quit.TabIndex = 8;
            Quit.Text = "Quit";
            Quit.UseVisualStyleBackColor = false;
            Quit.Click += Quit_Click;
            // 
            // Level1
            // 
            Level1.BackColor = Color.LavenderBlush;
            Level1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Level1.ForeColor = Color.DeepPink;
            Level1.Location = new Point(292, 144);
            Level1.Name = "Level1";
            Level1.Size = new Size(163, 44);
            Level1.TabIndex = 9;
            Level1.Text = "Level 1";
            Level1.UseVisualStyleBackColor = false;
            Level1.Click += Level1_Click;
            // 
            // Level2
            // 
            Level2.BackColor = Color.LavenderBlush;
            Level2.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Level2.ForeColor = Color.DeepPink;
            Level2.Location = new Point(292, 211);
            Level2.Name = "Level2";
            Level2.Size = new Size(163, 44);
            Level2.TabIndex = 10;
            Level2.Text = "Level 2 ";
            Level2.UseVisualStyleBackColor = false;
            Level2.Click += Level2_Click;
            // 
            // Level3
            // 
            Level3.BackColor = Color.LavenderBlush;
            Level3.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Level3.ForeColor = Color.DeepPink;
            Level3.Location = new Point(292, 281);
            Level3.Name = "Level3";
            Level3.Size = new Size(163, 44);
            Level3.TabIndex = 11;
            Level3.Text = "Level 3";
            Level3.UseVisualStyleBackColor = false;
            Level3.Click += Level3_Click;
            // 
            // Random
            // 
            Random.BackColor = Color.LavenderBlush;
            Random.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Random.ForeColor = Color.DeepPink;
            Random.Location = new Point(254, 349);
            Random.Name = "Random";
            Random.Size = new Size(252, 44);
            Random.TabIndex = 12;
            Random.Text = "Random Level";
            Random.UseVisualStyleBackColor = false;
            Random.Click += Random_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(-1, 108);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(226, 268);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(562, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 268);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(226, 41);
            label1.Name = "label1";
            label1.Size = new Size(313, 56);
            label1.TabIndex = 15;
            label1.Text = "Choose Level:";
            // 
            // Choose_Level
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(Random);
            Controls.Add(Level3);
            Controls.Add(Level2);
            Controls.Add(Level1);
            Controls.Add(Quit);
            Controls.Add(Back);
            Name = "Choose_Level";
            Text = "Choose_Level";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Back;
        private Button Quit;
        private Button Level1;
        private Button Level2;
        private Button Level3;
        private Button Random;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
    }
}