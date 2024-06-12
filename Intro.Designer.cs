namespace Labitint
{
    partial class Intro
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            Settings = new Button();
            Start = new Button();
            Quit = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            Rules = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // Settings
            // 
            Settings.BackColor = Color.White;
            Settings.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Settings.ForeColor = Color.DeepPink;
            Settings.Location = new Point(12, 213);
            Settings.Name = "Settings";
            Settings.Size = new Size(382, 44);
            Settings.TabIndex = 0;
            Settings.Text = "Settings";
            Settings.TextAlign = ContentAlignment.MiddleLeft;
            Settings.UseVisualStyleBackColor = false;
            Settings.Click += Settings_Click;
            // 
            // Start
            // 
            Start.BackColor = Color.LavenderBlush;
            Start.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Start.ForeColor = Color.DeepPink;
            Start.Location = new Point(231, 360);
            Start.Name = "Start";
            Start.Size = new Size(163, 44);
            Start.TabIndex = 1;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click;
            // 
            // Quit
            // 
            Quit.BackColor = Color.LavenderBlush;
            Quit.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Quit.ForeColor = Color.DeepPink;
            Quit.Location = new Point(400, 360);
            Quit.Name = "Quit";
            Quit.Size = new Size(163, 44);
            Quit.TabIndex = 2;
            Quit.Text = "Quit";
            Quit.UseVisualStyleBackColor = false;
            Quit.Click += Quit_Click;
            // 
            // Rules
            // 
            Rules.BackColor = Color.White;
            Rules.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Rules.ForeColor = Color.DeepPink;
            Rules.Location = new Point(400, 213);
            Rules.Name = "Rules";
            Rules.Size = new Size(388, 44);
            Rules.TabIndex = 4;
            Rules.Text = "Game rules";
            Rules.TextAlign = ContentAlignment.MiddleLeft;
            Rules.UseVisualStyleBackColor = false;
            Rules.Click += Rules_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(73, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 110);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(545, 272);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 82);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(32, 313);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(105, 82);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(693, 152);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(66, 66);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(196, 74);
            label1.Name = "label1";
            label1.Size = new Size(454, 72);
            label1.TabIndex = 16;
            label1.Text = "The Magic Maze:";
            // 
            // Intro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Rules);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(Quit);
            Controls.Add(Start);
            Controls.Add(Settings);
            Controls.Add(pictureBox1);
            Name = "Intro";
            Text = "Intro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Settings;
        private Button Start;
        private Button Quit;
        private System.Windows.Forms.Timer timer1;
        private Button Rules;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
    }
}