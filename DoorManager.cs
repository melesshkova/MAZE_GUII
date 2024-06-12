using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Labitint
{
    internal class DoorManager
    {
        private List<Door> doors;
        private Player player;
        private KeyManager keyManager;
        private Audio audio;
        public DoorManager(List<Door> doors, Player player, KeyManager keyManager)
        {
            this.doors = doors;
            this.player = player;
            this.keyManager = keyManager;
            audio = new Audio();
        }

        public async Task CheckDoorRemoval()
        {
            if (keyManager.PlayerHasKey())
            {
                Rectangle extendedPlayerBounds = new Rectangle(player.Bounds.X - 10, player.Bounds.Y - 10, player.Bounds.Width + 20, player.Bounds.Height + 20);

                foreach (var door in doors)
                {
                    if (extendedPlayerBounds.IntersectsWith(door.Bounds))
                    {
                        door.PictureBox.Dispose();
                        await audio.DoorOpened();
                        doors.Remove(door);
                        await audio.PlayGame();
                        return;
                    }
                }
            }
        }

    }

}

