namespace Labitint
{
    partial class Results
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.Button quitButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            resultsListBox = new ListBox();
            quitButton = new Button();
            Start = new Button();
            Back = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // resultsListBox
            // 
            resultsListBox.BackColor = Color.LightPink;
            resultsListBox.BorderStyle = BorderStyle.None;
            resultsListBox.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultsListBox.ForeColor = Color.White;
            resultsListBox.FormattingEnabled = true;
            resultsListBox.ItemHeight = 28;
            resultsListBox.Location = new Point(32, 104);
            resultsListBox.Margin = new Padding(4, 5, 4, 5);
            resultsListBox.Name = "resultsListBox";
            resultsListBox.Size = new Size(747, 280);
            resultsListBox.TabIndex = 0;
            // 
            // quitButton
            // 
            quitButton.BackColor = Color.LavenderBlush;
            quitButton.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quitButton.ForeColor = Color.DeepPink;
            quitButton.Location = new Point(701, 434);
            quitButton.Margin = new Padding(4, 5, 4, 5);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(100, 35);
            quitButton.TabIndex = 1;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = false;
            quitButton.Click += Quit_Click;
            // 
            // Start
            // 
            Start.BackColor = Color.LavenderBlush;
            Start.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Start.ForeColor = Color.DeepPink;
            Start.Location = new Point(326, 434);
            Start.Name = "Start";
            Start.Size = new Size(147, 37);
            Start.TabIndex = 19;
            Start.Text = "Next Level";
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click;
            // 
            // Back
            // 
            Back.BackColor = Color.LavenderBlush;
            Back.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.DeepPink;
            Back.Location = new Point(12, 434);
            Back.Name = "Back";
            Back.Size = new Size(96, 37);
            Back.TabIndex = 18;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(298, 34);
            label1.Name = "label1";
            label1.Size = new Size(193, 56);
            label1.TabIndex = 20;
            label1.Text = "Results:";
            // 
            // Results
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(814, 483);
            Controls.Add(label1);
            Controls.Add(Start);
            Controls.Add(Back);
            Controls.Add(quitButton);
            Controls.Add(resultsListBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Results";
            Text = "Results";
            Load += Results_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button Start;
        private Button Back;
        private Label label1;
    }
}