using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Игры_на_WF
{
    public partial class GameSnake : Form
    {
        private int appleX, appleY;
        private PictureBox apple;
        private int _wight = 900;
        private int _hight = 800;
        private int _sizeOfOneBlock = 40;
        private int dirX, dirY;

        public GameSnake()
        {
            InitializeComponent();
            apple = new PictureBox();
            apple.BackColor = Color.Red;
            apple.Size = new Size(_sizeOfOneBlock, _sizeOfOneBlock);
            dirX = 1;
            dirY = 0;
            timer1.Tick += new EventHandler(Update);
            this.Width = _wight;
            this.Height = _hight;
            this.KeyDown += new KeyEventHandler(Move);
            this.KeyDown += new KeyEventHandler(Update);
            GeneralMap();
        }


        private void Move(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Up":
                    dirX = 0;
                    dirY = -1;
                    break;
                case "Down":
                    dirX = 0;
                    dirY = 1;
                    break;
                case "Right":
                    dirX = 1;
                    dirY = 0;
                    break;
                case "Left":
                    dirX = -1;
                    dirY = 0;
                    break;
            }
        }

        private void Update(Object obj, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + _sizeOfOneBlock * dirX, 
                pictureBox1.Location.Y + _sizeOfOneBlock * dirY);
        }

        private void generalApple()
        {
            Random r = new Random();
            //apple = r.Next(0, _wight );

        }

        private void GeneralMap()
        {
            int tmp = _wight / _sizeOfOneBlock;
            int tmp2 = _hight / _sizeOfOneBlock;

            for (int i = 0; i < tmp; i++) 
            {  
                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.Black;
                pictureBox.Location = new Point(0, i * _sizeOfOneBlock);
                pictureBox.Size = new Size(_wight - 100, 1);
                this.Controls.Add(pictureBox);
            }

            for (int i = 0; i <= tmp2; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.Black;
                pictureBox.Location = new Point(i * _sizeOfOneBlock, 0);
                pictureBox.Size = new Size(1, _hight);
                this.Controls.Add(pictureBox);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GameSnake_Load(object sender, EventArgs e)
        {

        }
    }
}
