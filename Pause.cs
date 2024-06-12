using System;
using System.Windows.Forms;

namespace Labitint
{
    public partial class Pause : Form
    {
        private Level1 level1Form;
        private Level2 level2Form;
        private Level3 level3Form;

        public Pause(Level1 level1)
        {
            InitializeComponent();
            level1Form = level1;
        }

        public Pause(Level2 level2)
        {
            InitializeComponent();
            level2Form = level2;
        }

        public Pause(Level3 level3)
        {
            InitializeComponent();
            level3Form = level3;
        }

        // Метод для обновления времени на метке PauseTime
        public void UpdatePauseTime(string time)
        {
            PauseTime.Text = $"Time left: {time}";
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            level1Form?.Close();
            level2Form?.Close();
            level3Form?.Close();
            Intro introForm = new Intro();

            // Откройте форму Settings
            introForm.Show();
            this.Hide();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            level1Form?.ResumeGame();
            level2Form?.ResumeGame();
            level3Form?.ResumeGame();
            this.Close();
        }
    }
}
