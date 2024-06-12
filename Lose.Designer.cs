namespace Labitint
{
    partial class Lose
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
            Results = new Button();
            CoinsCollected = new Label();
            timer2 = new Label();
            Quit = new Button();
            Start = new Button();
            Back = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Results
            // 
            Results.BackColor = Color.LavenderBlush;
            Results.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Results.ForeColor = Color.DeepPink;
            Results.Location = new Point(175, 296);
            Results.Name = "Results";
            Results.Size = new Size(394, 37);
            Results.TabIndex = 21;
            Results.Text = "Rating table";
            Results.UseVisualStyleBackColor = false;
            Results.Click += Results_Click;
            // 
            // CoinsCollected
            // 
            CoinsCollected.BackColor = Color.LightPink;
            CoinsCollected.Font = new Font("Book Antiqua", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CoinsCollected.ForeColor = Color.White;
            CoinsCollected.ImageAlign = ContentAlignment.BottomLeft;
            CoinsCollected.Location = new Point(191, 188);
            CoinsCollected.Margin = new Padding(4, 0, 4, 0);
            CoinsCollected.Name = "CoinsCollected";
            CoinsCollected.Size = new Size(359, 33);
            CoinsCollected.TabIndex = 20;
            CoinsCollected.Text = "Coins:";
            // 
            // timer2
            // 
            timer2.BackColor = Color.LightPink;
            timer2.Font = new Font("Book Antiqua", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            timer2.ForeColor = Color.White;
            timer2.ImageAlign = ContentAlignment.BottomLeft;
            timer2.Location = new Point(191, 143);
            timer2.Margin = new Padding(4, 0, 4, 0);
            timer2.Name = "timer2";
            timer2.Size = new Size(359, 33);
            timer2.TabIndex = 19;
            timer2.Text = "Time:";
            // 
            // Quit
            // 
            Quit.BackColor = Color.LavenderBlush;
            Quit.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Quit.ForeColor = Color.DeepPink;
            Quit.Location = new Point(687, 405);
            Quit.Name = "Quit";
            Quit.Size = new Size(96, 37);
            Quit.TabIndex = 18;
            Quit.Text = "Quit";
            Quit.UseVisualStyleBackColor = false;
            Quit.Click += Quit_Click;
            // 
            // Start
            // 
            Start.BackColor = Color.LavenderBlush;
            Start.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Start.ForeColor = Color.DeepPink;
            Start.Location = new Point(318, 405);
            Start.Name = "Start";
            Start.Size = new Size(147, 37);
            Start.TabIndex = 17;
            Start.Text = "Next Level";
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click;
            // 
            // Back
            // 
            Back.BackColor = Color.LavenderBlush;
            Back.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.DeepPink;
            Back.Location = new Point(7, 405);
            Back.Name = "Back";
            Back.Size = new Size(96, 37);
            Back.TabIndex = 16;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(267, 49);
            label1.Name = "label1";
            label1.Size = new Size(230, 56);
            label1.TabIndex = 22;
            label1.Text = "You Lose!";
            // 
            // Lose
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
            Name = "Lose";
            Text = "Lose";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Results;
        private Label CoinsCollected;
        private Label timer2;
        private Button Quit;
        private Button Start;
        private Button Back;
        private Label label1;
    }
}