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
        int imp = 0;
        bool onePlayer;
       

        public Difficulty()
        {
            InitializeComponent();
        }

        public Difficulty(bool onePlayer)
        {
            this.onePlayer = onePlayer;

            InitializeComponent();
            button4.Visible = false;

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Game game = new Game(4, onePlayer);
            game.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            imp = imp + 1;
            if (imp == 3)
            {
                button4.Visible = true;
            }
        }
    }
}
