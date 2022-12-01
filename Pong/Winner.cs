using System;
using System.Windows.Forms;

namespace Pong
{
    public partial class Winner : Form
    {
        public Winner(String text)
        {
            InitializeComponent();
            label1.Text = text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Game form = new Game();
            form.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Home form = new Home();
            form.Show();
            this.Close();
        }
    }
}
