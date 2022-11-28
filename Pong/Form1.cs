using System;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(true);
            form.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 form = new Form2(false);
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
            controls.Show();
        }
    }
}
