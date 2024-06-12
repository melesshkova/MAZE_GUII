using System;
using System.Windows.Forms;

namespace Labitint
{
    public partial class Lose : Form
    {
        public Lose()
        {
            InitializeComponent();
          
        }

        public void UpdateTime(string time)
        {
            timer2.Text = $"Time: {time}";
        }

        public void UpdateCoins(int coins)
        {
            CoinsCollected.Text = $"Coins: {coins}";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Intro introForm = new Intro();
            introForm.Show();
            this.Hide();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Choose_Level levelForm = new Choose_Level();
            levelForm.Show();
            this.Hide();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Results_Click(object sender, EventArgs e)
        {
            Results resultsForm = new Results();
            resultsForm.Show();
            this.Hide();
        }
    }
}