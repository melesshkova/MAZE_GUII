namespace Labitint
{
    public partial class Settings : Form
    {
        private GameManager gameManager;
        private Audio audio;

        public Settings(GameManager gameManager)
        {
            InitializeComponent();
            this.gameManager = gameManager;
            audio = new Audio();

            // Установка состояния радиокнопок при загрузке формы
            useWASD.Checked = gameManager.UseWASD;
            arrowKeys.Checked = !gameManager.UseWASD;

            // Привязка событий изменения состояния радиокнопок к обработчикам
            this.useWASD.CheckedChanged += new System.EventHandler(this.WASD_CheckedChanged);
            this.arrowKeys.CheckedChanged += new System.EventHandler(this.arrowKeys_CheckedChanged);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Intro introForm = new Intro();
            introForm.Show();
            this.Hide();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            audio.StopIntro();
            this.Close();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Choose_Level levelForm = new Choose_Level();
            levelForm.Show();
            this.Hide();
        }

        private void WASD_CheckedChanged(object sender, EventArgs e)
        {
            if (useWASD.Checked)
            {
                gameManager.UseWASD = true;
                arrowKeys.Checked = false;
                Console.WriteLine("WASD mode enabled");
            }
        }

        private void arrowKeys_CheckedChanged(object sender, EventArgs e)
        {
            if (arrowKeys.Checked)
            {
                gameManager.UseWASD = false;
                useWASD.Checked = false;
                Console.WriteLine("Arrow keys mode enabled");
            }
        }
    }
}
