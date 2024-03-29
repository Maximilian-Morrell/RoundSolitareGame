using RoundSolitareGame.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundSolitareGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateBoard(int SizeMultiplicator)
        {
            Board board = new Board(SizeMultiplicator);
            MainLayoutParent.Controls.Add(Board.GeneratePlayField(board), 0, 0);
        }

        private void TopBar_GenerateGame_Click(object sender, EventArgs e)
        {
            GenerateBoard(1);
        }
    }
}
