using System;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form3 : Form
    {
        public Form3(String text)
        {
            InitializeComponent();
            label1.Text = text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
