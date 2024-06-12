using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Labitint
{
    public partial class Choose_Level : Form
    {
        private Audio audio;
        public Choose_Level()
        {
            InitializeComponent();
            audio = new Audio();
        }

        private void Level2_Click(object sender, EventArgs e)
        {
            Level2 levelForm = new Level2();

            // Откройте форму Settings
            levelForm.Show();
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Intro introForm = new Intro();

            // Откройте форму Settings
            introForm.Show();
            this.Hide();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            audio.StopIntro();
            this.Close();
        }

        private void Level1_Click(object sender, EventArgs e)
        {
            Level1 levelForm = new Level1();

            // Откройте форму Settings
            levelForm.Show();
            this.Hide();
        }

        private void Level3_Click(object sender, EventArgs e)
        {
            Level3 levelForm = new Level3();

            // Откройте форму Settings
            levelForm.Show();
            this.Hide();
        }

        private void RandomLevel()
        {
            Random random = new Random();
            int level = random.Next(1, 4); // Генерируем случайное число от 1 до 3

            // Открываем соответствующий случайно выбранный уровень
            switch (level)
            {
                case 1:
                    Level1 level1Form = new Level1();
                    level1Form.Show();
                    break;
                case 2:
                    Level2 level2Form = new Level2();
                    level2Form.Show();
                    break;
                case 3:
                    Level3 level3Form = new Level3();
                    level3Form.Show();
                    break;
                default:
                    // Если случайно сгенерированное число не попадает в диапазон 1-3, показываем сообщение об ошибке
                    MessageBox.Show("Ошибка: Невозможно загрузить случайный уровень.");
                    break;
            }

            // Закрываем текущую форму выбора уровня
            this.Hide();
        }

        private void Random_Click(object sender, EventArgs e)
        {
            RandomLevel();
        }
    }
}