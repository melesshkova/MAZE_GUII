using System;
using System.Windows.Forms;

namespace Labitint
{
    public partial class Level1 : Form
    {
        private LevelManager levelManager;
        private List<PictureBox> coinPictureBoxes;

        public Level1()
        {
            InitializeComponent();
            coinPictureBoxes = new List<PictureBox>();
            levelManager = new LevelManager(this, 1, TimeSpan.FromMinutes(1), CoinsCollected, KeysCollected, timer2, timer1, BoostActivate);

            // Ensure that buttons do not take focus
            Quit.TabStop = false;
            Pause.TabStop = false;
            BoostActivate.TabStop = false;

            // Set up form-level key handling
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Level1_KeyDown);
            this.Click += (sender, e) => this.Focus();

            // Assign the event handler for the Quit button
            Quit.Click += new EventHandler(Quit_Click);

            // Hide the BoostActivate button initially
            BoostActivate.Visible = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Right || keyData == Keys.W || keyData == Keys.A || keyData == Keys.S || keyData == Keys.D || keyData == Keys.Space)
            {
                levelManager.HandleKeyDown(new KeyEventArgs(keyData));
                return true; // Indicate that the key event has been handled
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Level1_KeyDown(object sender, KeyEventArgs e)
        {
            levelManager.HandleKeyDown(e);
        }

        public void ResumeGame()
        {
            levelManager.ResumeGame();
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

        private void Quit_Click(object sender, EventArgs e)
        {
            levelManager.QuitGame();
        }

        private void BoostActivate_Click(object sender, EventArgs e)
        {
            levelManager.ActivateBoost();
        }
    }
}
