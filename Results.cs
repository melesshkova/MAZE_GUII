using System;
using System.IO;
using System.Windows.Forms;

namespace Labitint
{
    public partial class Results : Form
    {
        private Audio audio;
        public Results()
        {
            InitializeComponent();
            audio = new Audio();
            audio.PlayIntro();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            LoadResults();
        }

        private void LoadResults()
        {
            string filePath = @"D:\хтмл\Labitint\Labitint\GameResults.txt"; // Ensure this matches the path in LevelManager
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    // Add each line to the ListBox
                    resultsListBox.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Results file not found.");
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            audio.StopIntro();
            this.Close();
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
    }
}
