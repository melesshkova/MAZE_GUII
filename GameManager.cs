namespace Labitint
{
    public class GameManager
    {
        private Player player;
        private Exit exit;
        private List<Wall> walls = new List<Wall>();
        private List<Coin> coins = new List<Coin>();
        private List<Key> keys = new List<Key>();
        private List<Door> doors = new List<Door>();
        private GameMatrix gameMatrix;
        public CoinManager CoinManager { get; private set; }
        public KeyManager KeyManager { get; private set; }
        private DoorManager doorManager;
        private Boost boost;
        private int playerSpeed = 10;
        private bool useWASD = false;
        private bool winFormOpened = false;
        public event Action LevelExitReached;

        public GameManager(Control.ControlCollection controls, Button boostButton)
        {
            InitializeGameObjects(controls);
            InitializeGameMatrix();
            this.boost = new Boost(boostButton, this);
            CoinManager = new CoinManager(coins.ConvertAll(c => c.PictureBox), player, boost);
            KeyManager = new KeyManager(keys, player);
            doorManager = new DoorManager(doors, player, KeyManager);

            // Создаем экземпляр Settings и передаем ему текущий экземпляр GameManager
            Settings settingsForm = new Settings(this);
        }

        public bool UseWASD
        {
            get { return useWASD; }
            set { useWASD = value; }
        }

        public void SetPlayerSpeed(int speed)
        {
            playerSpeed = speed;
        }

        public void HandleKeyDown(KeyEventArgs e)
        {
            int deltaX = 0, deltaY = 0;

            if (useWASD)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        deltaX = -playerSpeed;
                        break;
                    case Keys.D:
                        deltaX = playerSpeed;
                        break;
                    case Keys.W:
                        deltaY = -playerSpeed;
                        break;
                    case Keys.S:
                        deltaY = playerSpeed;
                        break;
                    case Keys.Space:
                        KeyManager.CheckCollection();
                        doorManager.CheckDoorRemoval();
                        return;
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        deltaX = -playerSpeed;
                        break;
                    case Keys.Right:
                        deltaX = playerSpeed;
                        break;
                    case Keys.Up:
                        deltaY = -playerSpeed;
                        break;
                    case Keys.Down:
                        deltaY = playerSpeed;
                        break;
                    case Keys.Space:
                        KeyManager.CheckCollection();
                        doorManager.CheckDoorRemoval();
                        return;
                }
            }

            // Проверяем, чтобы PictureBox не выходил за пределы формы
            int nextLeft = Math.Max(0, Math.Min(player.PictureBox.Left + deltaX, player.PictureBox.Parent.Width - player.PictureBox.Width));
            int nextTop = Math.Max(0, Math.Min(player.PictureBox.Top + deltaY, player.PictureBox.Parent.Height - player.PictureBox.Height));

            Rectangle nextPlayerPos = new Rectangle(nextLeft, nextTop, player.PictureBox.Width, player.PictureBox.Height);

            // Проверяем столкновения со стенами и дверями
            if (walls.Any(wall => nextPlayerPos.IntersectsWith(wall.Bounds)) || doors.Any(door => nextPlayerPos.IntersectsWith(door.Bounds)))
            {
                return;
            }

            player.Move(deltaX, deltaY);

            // Проверяем достижение выхода из уровня
            if (player.Bounds.IntersectsWith(exit.Bounds) && !winFormOpened)
            {
                LevelExitReached?.Invoke();
            }

            CoinManager.CheckCollisionWithPlayer();
        }


        private void RemoveDoorIfPlayerHasKey()
        {
            if (KeyManager.PlayerHasKey())
            {
                Rectangle extendedPlayerBounds = new Rectangle(player.Bounds.X - 10, player.Bounds.Y - 10, player.Bounds.Width + 20, player.Bounds.Height + 20);

                for (int i = doors.Count - 1; i >= 0; i--)
                {
                    if (extendedPlayerBounds.IntersectsWith(doors[i].Bounds))
                    {
                        doors[i].PictureBox.Dispose();
                        doors.RemoveAt(i);
                    }
                }
            }
        }

        private void InitializeGameObjects(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is PictureBox pictureBox)
                {
                    switch (pictureBox.Tag)
                    {
                        case "player":
                            player = new Player(pictureBox);
                            break;
                        case "exit":
                            exit = new Exit(pictureBox);
                            break;
                        case "wall":
                            walls.Add(new Wall(pictureBox));
                            break;
                        case "coin":
                            coins.Add(new Coin(pictureBox));
                            break;
                        case "key":
                            keys.Add(new Key(pictureBox));
                            break;
                        case "door":
                            doors.Add(new Door(pictureBox));
                            break;
                    }
                }
            }
        }

        private void InitializeGameMatrix()
        {
            gameMatrix = new GameMatrix(10, 10);

            if (player != null)
            {
                gameMatrix.AddObject(player, player.PictureBox.Top / player.PictureBox.Height, player.PictureBox.Left / player.PictureBox.Width);
            }

            if (exit != null)
            {
                gameMatrix.AddObject(exit, exit.PictureBox.Top / exit.PictureBox.Height, exit.PictureBox.Left / exit.PictureBox.Width);
            }

            foreach (var wall in walls)
            {
                gameMatrix.AddObject(wall, wall.PictureBox.Top / wall.PictureBox.Height, wall.PictureBox.Left / wall.PictureBox.Width);
            }

            foreach (var coin in coins)
            {
                gameMatrix.AddObject(coin, coin.PictureBox.Top / coin.PictureBox.Height, coin.PictureBox.Left / coin.PictureBox.Width);
            }

            foreach (var key in keys)
            {
                gameMatrix.AddObject(key, key.PictureBox.Top / key.PictureBox.Height, key.PictureBox.Left / key.PictureBox.Width);
            }

            foreach (var door in doors)
            {
                gameMatrix.AddObject(door, door.PictureBox.Top / door.PictureBox.Height, door.PictureBox.Left / door.PictureBox.Width);
            }
        }
    }
}
