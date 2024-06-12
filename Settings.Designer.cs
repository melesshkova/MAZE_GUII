namespace Labitint
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            useWASD = new RadioButton();
            arrowKeys = new RadioButton();
            Back = new Button();
            Start = new Button();
            Quit = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // useWASD
            // 
            useWASD.AutoSize = true;
            useWASD.Font = new Font("Book Antiqua", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            useWASD.ForeColor = Color.White;
            useWASD.Location = new Point(215, 174);
            useWASD.Name = "useWASD";
            useWASD.Size = new Size(103, 32);
            useWASD.TabIndex = 2;
            useWASD.Text = "WASD";
            useWASD.UseVisualStyleBackColor = true;
            useWASD.CheckedChanged += WASD_CheckedChanged;
            // 
            // arrowKeys
            // 
            arrowKeys.AutoCheck = false;
            arrowKeys.AutoSize = true;
            arrowKeys.Font = new Font("Book Antiqua", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            arrowKeys.ForeColor = Color.White;
            arrowKeys.Location = new Point(420, 174);
            arrowKeys.Name = "arrowKeys";
            arrowKeys.Size = new Size(141, 32);
            arrowKeys.TabIndex = 3;
            arrowKeys.Text = "Arrow keys";
            arrowKeys.UseVisualStyleBackColor = true;
            arrowKeys.CheckedChanged += arrowKeys_CheckedChanged;
            // 
            // Back
            // 
            Back.BackColor = Color.LavenderBlush;
            Back.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.DeepPink;
            Back.Location = new Point(12, 401);
            Back.Name = "Back";
            Back.Size = new Size(96, 37);
            Back.TabIndex = 4;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Start
            // 
            Start.BackColor = Color.LavenderBlush;
            Start.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Start.ForeColor = Color.DeepPink;
            Start.Location = new Point(345, 401);
            Start.Name = "Start";
            Start.Size = new Size(96, 37);
            Start.TabIndex = 5;
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
            Quit.TabIndex = 6;
            Quit.Text = "Quit";
            Quit.UseVisualStyleBackColor = false;
            Quit.Click += Quit_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(608, 249);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 78);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(273, 44);
            label1.Name = "label1";
            label1.Size = new Size(206, 56);
            label1.TabIndex = 16;
            label1.Text = "Settings:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(286, 119);
            label2.Name = "label2";
            label2.Size = new Size(155, 28);
            label2.TabIndex = 17;
            label2.Text = "Control keys:";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(Quit);
            Controls.Add(Start);
            Controls.Add(Back);
            Controls.Add(arrowKeys);
            Controls.Add(useWASD);
            Name = "Settings";
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton useWASD;
        private RadioButton arrowKeys;
        private Button Back;
        private Button Start;
        private Button Quit;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
    }
}