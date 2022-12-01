using System;
using System.Windows.Forms;

namespace Pong
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game form = new Game(true);
            form.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Game form = new Game(false);
            form.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Controls controls = new Controls();
            controls.ShowDialog();
        }
    }
}
