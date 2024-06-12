using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labitint
{
    public partial class GameRules : Form
    {
        private Audio audio;
        public GameRules()
        {
            InitializeComponent();
            audio = new Audio();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Intro introForm = new Intro();

            // Откройте форму Settings
            introForm.Show();
            this.Hide();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Choose_Level levelForm = new Choose_Level();

            // Откройте форму Settings
            levelForm.Show();
            this.Hide();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            audio.StopIntro();
            this.Close();
        }
    }
}
