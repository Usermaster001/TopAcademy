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
    public partial class GameTicTacToe : Form
    {
        private int step { get; set; } = 1;
        private int[][] board = { new int[] { 0, 0, 0},
            new int[] { 0, 0, 0 }, new int[] { 0, 0, 0}};

        public GameTicTacToe()
        {
            InitializeComponent();
        }

        private void CheckWin()
        {
            if (board[0][0] ==  board[0][1] && board[0][1] == board[0][2] &&
                board[0][0] != 0 && board[0][1] != 0 && board[0][2] != 0 ||
                board[1][0] == board[1][1] && board[1][1] == board[1][2] &&
                board[1][0] != 0 && board[1][1] != 0 && board[1][2] != 0 ||
                board[2][0] == board[2][1] && board[2][1] == board[2][2] &&
                board[2][0] != 0 && board[2][1] != 0 && board[2][2] != 0     ||

                board[0][0] == board[1][0] && board[1][0] == board[2][0] &&
                board[0][0] != 0 && board[1][0] != 0 && board[2][0] != 0 ||
                board[0][1] == board[1][1] && board[1][1] == board[2][1] &&
                board[0][1] != 0 && board[1][1] != 0 && board[2][1] != 0 ||
                board[0][2] == board[1][2] && board[1][2] == board[2][2] &&
                board[0][2] != 0 && board[1][2] != 0 && board[2][2] != 0     ||

                board[0][0] == board[1][1] && board[1][1] == board[2][2] &&
                board[0][0] != 0 && board[1][1] != 0 && board[2][2] != 0 ||
                board[0][2] == board[1][1] && board[1][1] == board[2][0] &&
                board[0][2] != 0 && board[1][1] != 0 && board[2][0] != 0
                )
            {
                MessageBox.Show("Win");
                if(step % 2 ==0)
                {
                    label1.Text = (int.Parse(label1.Text) + 1).ToString();
                }
                else
                {
                    label2.Text = (int.Parse(label2.Text) + 1).ToString();
                }

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                board = new int[][]{new int[] { 0, 0, 0 },new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 }};
                step = 1;
            }
        }

        private void GameTicTacToe_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(button1.Text))
            {
                if (step % 2 != 0)
                {
                    button1.Text = "X";
                    board[0][0] = -1;
                    step++;
                }
                else
                {
                    button1.Text = "O";
                    board[0][0] = 1;
                    step++;
                }
                CheckWin();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(button2.Text))
            {
                if (step % 2 != 0)
                {
                    button2.Text = "X";
                    board[0][1] = -1;
                    step++;
                }
                else
                {
                    button2.Text = "O";
                    board[0][1] = 1;
                    step++;
                }
                CheckWin();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(button3.Text))
            {
                if (step % 2 != 0)
                {
                    button3.Text = "X";
                    board[0][2] = -1;
                    step++;
                }
                else
                {
                    button3.Text = "O";
                    board[0][2] = 1;
                    step++;
                }
                CheckWin();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(button6.Text))
            {
                if (step % 2 != 0)
                {
                    button6.Text = "X";
                    board[1][0] = -1;
                    step++;
                }
                else
                {
                    button6.Text = "O";
                    board[1][0] = 1;
                    step++;
                }
                CheckWin();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(button5.Text))
            {
                if (step % 2 != 0)
                {
                    button5.Text = "X";
                    board[1][1] = -1;
                    step++;
                }
                else
                {
                    button5.Text = "O";
                    board[1][1] = 1;
                    step++;
                }
                CheckWin();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(button4.Text))
            {
                if (step % 2 != 0)
                {
                    button4.Text = "X";
                    board[1][2] = -1;
                    step++;
                }
                else
                {
                    button4.Text = "O";
                    board[1][2] = 1;
                    step++;
                }
                CheckWin();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(button9.Text))
            {
                if (step % 2 != 0)
                {
                    button9.Text = "X";
                    board[2][0] = -1;
                    step++;
                }
                else
                {
                    button9.Text = "O";
                    board[2][0] = 1;
                    step++;
                }
                CheckWin();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(button8.Text))
            {
                if (step % 2 != 0)
                {
                    button8.Text = "X";
                    board[2][1] = -1;
                    step++;
                }
                else
                {
                    button8.Text = "O";
                    board[2][1] = 1;
                    step++;
                }
                CheckWin();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(button7.Text))
            {
                if (step % 2 != 0)
                {
                    button7.Text = "X";
                    board[2][2] = -1;
                    step++;
                }
                else
                {
                    button7.Text = "O";
                    board[2][2] = 1;
                    step++;
                }
                CheckWin();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
