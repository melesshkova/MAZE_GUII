using System;
using System.Windows.Forms;

namespace Labitint
{
    public class Boost
    {
        private int collectedCoins;
        private Button boostButton;
        private GameManager gameManager;
        private System.Windows.Forms.Timer boostTimer; 
        private int boostDuration = 5000; 
        private int originalSpeed = 10;
        private int boostedSpeed = 20;

        public Boost(Button boostButton, GameManager gameManager)
        {
            this.boostButton = boostButton;
            this.gameManager = gameManager;
            this.boostTimer = new System.Windows.Forms.Timer(); 
            this.boostTimer.Interval = boostDuration;

            this.boostTimer.Tick += BoostTimer_Tick;
        }

        public void OnCoinCollected()
        {
            collectedCoins++;
            if (collectedCoins >= 5)
            {
                boostButton.Visible = true;
            }
        }

        private void BoostButton_Click(object sender, EventArgs e)
        {
            gameManager.SetPlayerSpeed(boostedSpeed);
            boostTimer.Start();
        }

        private void BoostTimer_Tick(object sender, EventArgs e)
        {
            boostTimer.Stop();
            gameManager.SetPlayerSpeed(originalSpeed);
        }
    }
}
