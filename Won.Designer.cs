namespace Labitint
{
    partial class Win
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
            Back = new Button();
            Start = new Button();
            Quit = new Button();
            timer2 = new Label();
            CoinsCollected = new Label();
            Results = new Button();
            label1 = new Label();
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
            Back.TabIndex = 10;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Start
            // 
            Start.BackColor = Color.LavenderBlush;
            Start.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Start.ForeColor = Color.DeepPink;
            Start.Location = new Point(323, 401);
            Start.Name = "Start";
            Start.Size = new Size(147, 37);
            Start.TabIndex = 11;
            Start.Text = "Next Level";
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
            Quit.TabIndex = 12;
            Quit.Text = "Quit";
            Quit.UseVisualStyleBackColor = false;
            Quit.Click += Quit_Click;
            // 
            // timer2
            // 
            timer2.BackColor = Color.LightPink;
            timer2.Font = new Font("Book Antiqua", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            timer2.ForeColor = Color.White;
            timer2.ImageAlign = ContentAlignment.BottomLeft;
            timer2.Location = new Point(196, 139);
            timer2.Margin = new Padding(4, 0, 4, 0);
            timer2.Name = "timer2";
            timer2.Size = new Size(359, 33);
            timer2.TabIndex = 13;
            timer2.Text = "Time:";
            // 
            // CoinsCollected
            // 
            CoinsCollected.BackColor = Color.LightPink;
            CoinsCollected.Font = new Font("Book Antiqua", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CoinsCollected.ForeColor = Color.White;
            CoinsCollected.ImageAlign = ContentAlignment.BottomLeft;
            CoinsCollected.Location = new Point(196, 184);
            CoinsCollected.Margin = new Padding(4, 0, 4, 0);
            CoinsCollected.Name = "CoinsCollected";
            CoinsCollected.Size = new Size(359, 33);
            CoinsCollected.TabIndex = 14;
            CoinsCollected.Text = "Coins:";
            // 
            // Results
            // 
            Results.BackColor = Color.LavenderBlush;
            Results.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Results.ForeColor = Color.DeepPink;
            Results.Location = new Point(180, 292);
            Results.Name = "Results";
            Results.Size = new Size(394, 37);
            Results.TabIndex = 15;
            Results.Text = "Rating table";
            Results.UseVisualStyleBackColor = false;
            Results.Click += Results_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(286, 49);
            label1.Name = "label1";
            label1.Size = new Size(232, 56);
            label1.TabIndex = 16;
            label1.Text = "You Won!";
            // 
            // Win
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Results);
            Controls.Add(CoinsCollected);
            Controls.Add(timer2);
            Controls.Add(Quit);
            Controls.Add(Start);
            Controls.Add(Back);
            Name = "Win";
            Text = "Win";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Back;
        private Button Start;
        private Button Quit;
        private Label timer2;
        private Label CoinsCollected;
        private Button Results;
        private Label label1;
    }
}