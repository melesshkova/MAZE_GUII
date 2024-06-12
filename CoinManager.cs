using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Labitint
{
    public class CoinManager
    {
        private List<PictureBox> coinPictureBoxes;
        private Player player;
        private Boost boost;

        public event Action CoinCollected;

        public CoinManager(List<PictureBox> coinPictureBoxes, Player player, Boost boost)
        {
            this.coinPictureBoxes = coinPictureBoxes;
            this.player = player;
            this.boost = boost;
        }

        public void CheckCollisionWithPlayer()
        {
            for (int i = 0; i < coinPictureBoxes.Count; i++)
            {
                PictureBox coinPictureBox = coinPictureBoxes[i];
                if (player.Bounds.IntersectsWith(coinPictureBox.Bounds))
                {
                    coinPictureBox.Dispose();
                    coinPictureBoxes.RemoveAt(i);
                    CoinCollected?.Invoke();
                    boost.OnCoinCollected();
                    break;
                }
            }
        }
    }
}
