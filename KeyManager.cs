using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Labitint
{
    public class KeyManager
    {
        private List<Key> keys;
        private Player player;

        // Событие для уведомления о сборе ключа
        public event Action KeyCollected;

        public KeyManager(List<Key> keys, Player player)
        {
            this.keys = keys;
            this.player = player;
        }

        public void CheckCollection()
        {
            foreach (var key in keys)
            {
                if (player.Bounds.IntersectsWith(key.Bounds) && !key.IsCollected)
                {
                    key.Collect();
                    KeyCollected?.Invoke(); // Вызываем событие при сборе ключа
                }
            }
        }

        public bool PlayerHasKey()
        {
            foreach (var key in keys)
            {
                if (key.IsCollected)
                {
                    return true;
                }
            }
            return false;
        }
    }


}
