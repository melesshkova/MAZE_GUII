using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Labitint
{
    public abstract class GameObject
    {
        public PictureBox PictureBox { get; private set; }

        protected GameObject(PictureBox pictureBox)
        {
            PictureBox = pictureBox;
        }

        public Rectangle Bounds => PictureBox.Bounds;
    }

    public class Player : GameObject
    {
        public Player(PictureBox pictureBox) : base(pictureBox) { }

        public void Move(int deltaX, int deltaY)
        {
            PictureBox.Left += deltaX;
            PictureBox.Top += deltaY;
        }
    }
    public class Wall : GameObject
    {
        public Wall(PictureBox pictureBox) : base(pictureBox) { }

    }


    public class Exit : GameObject
    {
        public Exit(PictureBox pictureBox) : base(pictureBox) { }
    }

    public class Coin : GameObject
    {
        public Coin(PictureBox pictureBox) : base(pictureBox) { }
    }

    public class Key : GameObject
    {
        public Key(PictureBox pictureBox) : base(pictureBox) { }

        public bool IsCollected { get; private set; } = false;

        public void Collect()
        {
            IsCollected = true;
            PictureBox.Dispose(); // Опционально: убрать изображение ключа с формы после сбора
        }
    }

    public class Door : GameObject
    {

        public Door(PictureBox pictureBox) : base(pictureBox) { }
    }

}


