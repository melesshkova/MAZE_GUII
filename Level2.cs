using System;
using System.Windows.Forms;

namespace Labitint
{
    public partial class Level2 : Form
    {
        private LevelManager levelManager;

        public Level2()
        {
            InitializeComponent();
            levelManager = new LevelManager(this, 2, TimeSpan.FromMinutes(2), CoinsCollected, KeysCollected, timer2, timer1, BoostActivate);
            Quit.TabStop = false;
            Pause.TabStop = false;

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Level2_KeyDown);
            this.Click += (sender, e) => this.Focus();
            // Hide the BoostActivate button initially
            BoostActivate.Visible = false;
            // Assign the event handler for the Quit button
            Quit.Click += new EventHandler(Quit_Click);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Right || keyData == Keys.W || keyData == Keys.A || keyData == Keys.S || keyData == Keys.D || keyData == Keys.Space)
            {
                levelManager.HandleKeyDown(new KeyEventArgs(keyData));
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Level2_KeyDown(object sender, KeyEventArgs e)
        {
            levelManager.HandleKeyDown(e);
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            levelManager.QuitGame();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            levelManager.PauseGame();

            string currentTime = timer2.Text.Substring(6);
            Pause pauseForm = new Pause(this);
            pauseForm.UpdatePauseTime(currentTime);

            pauseForm.FormClosing += (s, args) => this.Show();
            pauseForm.Show();
            this.Hide();
        }

        public void ResumeGame()
        {
            levelManager.ResumeGame();
        }
        private void BoostActivate_Click(object sender, EventArgs e)
        {
            levelManager.ActivateBoost();
        }

    }
}
