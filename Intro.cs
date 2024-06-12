namespace Labitint
{
    public partial class Intro : Form
    {
        private Audio audio;

        public Intro()
        {
            InitializeComponent();
            audio = new Audio();
            audio.PlayIntro(); // Play music when the form is created
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            audio.StopIntro();
            this.Close();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            // Создать новый экземпляр GameManager
            GameManager gameManager = new GameManager(this.Controls, null);

            // Создать новый экземпляр формы настроек и передать ему экземпляр GameManager
            Settings settingsForm = new Settings(gameManager);

            // Показать форму настроек
            settingsForm.Show();

            // Скрыть текущую форму
            this.Hide();
        }


        private void Start_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Choose_Level form
            Choose_Level levelForm = new Choose_Level();

            // Show the Choose_Level form and hide the current form
            levelForm.Show();
            this.Hide();
        }

        private void Rules_Click(object sender, EventArgs e)
        {
            // Create a new instance of the GameRules form
            GameRules rulesForm = new GameRules();

            // Show the GameRules form and hide the current form
            rulesForm.Show();
            this.Hide();
        }
    }
}
