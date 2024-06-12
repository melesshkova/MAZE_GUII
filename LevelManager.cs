using System;
using System.IO;
using System.Windows.Forms;

namespace Labitint
{
    internal class LevelManager
    {
        private GameManager gameManager;
        private DateTime startTime;
        private TimeSpan duration;
        private int countCoins;
        private int countKeys;
        private TimeSpan remainingTime;
        private Form levelForm;
        private Label coinsCollectedLabel;
        private Label keysCollectedLabel;
        private Label timerLabel;
        private System.Windows.Forms.Timer timer;
        private Button boostActivateButton;

        public event Action LevelExitReached; // Define the LevelExitReached event
        private int currentLevel; // Track the current level number

        private Audio audio;

        public LevelManager(Form levelForm, int level, TimeSpan duration, Label coinsCollectedLabel, Label keysCollectedLabel, Label timerLabel, System.Windows.Forms.Timer timer, Button boostActivateButton)
        {
            this.levelForm = levelForm;
            this.currentLevel = level; // Set the current level
            this.duration = duration;
            this.coinsCollectedLabel = coinsCollectedLabel;
            this.keysCollectedLabel = keysCollectedLabel;
            this.timerLabel = timerLabel;
            this.timer = timer;
            this.boostActivateButton = boostActivateButton;

            InitializeGame();

            startTime = DateTime.Now;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            this.levelForm.KeyPreview = true;
            this.levelForm.KeyDown += new KeyEventHandler(LevelForm_KeyDown);
            audio = new Audio();
            audio.PlayGame(); // Play game music when level starts
        }

        private void InitializeGame()
        {
            gameManager = new GameManager(this.levelForm.Controls, boostActivateButton);
            gameManager.CoinManager.CoinCollected += OnCoinCollected;
            gameManager.KeyManager.KeyCollected += OnKeyCollected;
            gameManager.LevelExitReached += OnLevelExitReached; // Add an event for when the player reaches the exit
        }

        public void HandleKeyDown(KeyEventArgs e)
        {
            gameManager.HandleKeyDown(e);
        }

        private void LevelForm_KeyDown(object sender, KeyEventArgs e)
        {
            HandleKeyDown(e);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            remainingTime = duration - elapsedTime;

            if (remainingTime.TotalSeconds <= 0)
            {
                timer.Stop();
                LoseGame();
            }
            else
            {
                timerLabel.Text = $"Time: {remainingTime:mm\\:ss}";
            }
        }

        private async void OnCoinCollected()
        {
            await audio.CoinCollected();
            countCoins++;
            UpdateCoinLabel();
            await audio.PlayGame(); // Continue playing game sound after collecting a coin
        }

        private async void OnKeyCollected()
        {
            await audio.KeyCollected();
            countKeys++;
            UpdateKeyLabel();
            await audio.PlayGame();
        }

        private void UpdateCoinLabel()
        {
            coinsCollectedLabel.Text = $"Coins: {countCoins}";
        }

        private void UpdateKeyLabel()
        {
            keysCollectedLabel.Text = $"Keys: {countKeys}";
        }

        public void QuitGame()
        {
            audio.StopGame();
            timer.Stop();
            levelForm.Close();
        }

        public void PauseGame()
        {
            timer.Stop();
        }

        public void ResumeGame()
        {
            startTime = DateTime.Now - (duration - remainingTime);
            timer.Start();
        }

        public void ActivateBoost()
        {
            if (countCoins >= 5)
            {
                countCoins -= 5; // Вычесть 5 монет
                UpdateCoinLabel(); // Обновить метку с количеством монет
                gameManager.SetPlayerSpeed(20);
                System.Windows.Forms.Timer boostTimer = new System.Windows.Forms.Timer(); // Установить таймер ускорения
                boostTimer.Interval = 5000; // Продолжительность ускорения 5 секунд
                boostTimer.Tick += (s, e) =>
                {
                    gameManager.SetPlayerSpeed(10); // Восстановить обычную скорость после окончания ускорения
                    boostTimer.Stop();
                };
                boostTimer.Start();
            }
            else
            {
                MessageBox.Show("You must have 5 coins or more!");
            }
        }


        private void LoseGame()
        {
            audio.StopGame();
            audio.PlayLose();
            timer.Stop();
            // Calculate the elapsed time when the game was lost
            TimeSpan elapsedTime = DateTime.Now - startTime;
            string elapsedTimeString = elapsedTime.ToString(@"mm\:ss");

            levelForm.FormClosed += (sender, args) =>
            {
                Lose loseForm = new Lose();
                loseForm.UpdateTime(elapsedTimeString);
                loseForm.UpdateCoins(countCoins); // Pass the collected coins count
                loseForm.Show();
            };
            SaveGameResult("lose", elapsedTimeString); // Save the game result with elapsed time
            levelForm.Close();
        }

        private void WinGame()
        {
            audio.StopGame();
            audio.PlayWin();
            timer.Stop();
            // Calculate the elapsed time when the level was completed
            TimeSpan elapsedTime = DateTime.Now - startTime;
            string elapsedTimeString = elapsedTime.ToString(@"mm\:ss");

            levelForm.FormClosed += (sender, args) =>
            {
                Win winForm = new Win();
                winForm.UpdateTime(elapsedTimeString);
                winForm.UpdateCoins(countCoins); // Pass the collected coins count
                winForm.Show();
            };
            SaveGameResult("won", elapsedTimeString); // Save the game result with elapsed time
            levelForm.Close();
        }

        private void OnLevelExitReached()
        {
            WinGame();
        }

        private void SaveGameResult(string result, string elapsedTime)
        {
            try
            {
                // Update the file path to match the one in Results form
                string filePath = @"D:\хтмл\Labitint\Labitint\GameResults.txt";
                int level = GetCurrentLevel();
                int coins = countCoins;
                string resultLine = $"Time: {elapsedTime}     Level: {level}     Result: {result}    Coins: {coins}";
                File.AppendAllLines(filePath, new[] { resultLine });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении результата: {ex.Message}");
            }
        }

        private int GetCurrentLevel()
        {
            return currentLevel;
        }
    }
}