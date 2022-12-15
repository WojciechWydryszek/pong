using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Difficulty : Form
    {

        bool onePlayer;

        public Difficulty()
        {
            InitializeComponent();
        }

        public Difficulty(bool onePlayer)
        {
            this.onePlayer = onePlayer;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game game = new Game(1, onePlayer);
            game.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game game = new Game(2, onePlayer);
            game.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Game game = new Game(3, onePlayer);
            game.Show();
            this.Close();
        }
    }
}
