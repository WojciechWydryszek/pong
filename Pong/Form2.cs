using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form2 : Form
    {
        Timer myTimer = new Timer();

        static Boolean startBall,
                       onePLayer;
                
        static int speedBot,
                   ballX,
                   ballY,
                   pointsPlayer,
                   pointsBot;


        public Form2() // constructor for restart game
        {
            InitializeComponent();
            startValues();
        }
        public Form2(bool b) // pass if is game for 1 or 2 players
        {
            InitializeComponent();
            onePLayer = b;
            startValues();
        }

        private void startValues() // initial values
        {
            speedBot = 3;
            ballX = -5;
            ballY = 5;
            pointsPlayer = 0;
            pointsBot = 0;
            startBall = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // overide medoth for keyboard load
        {

            if (keyData != Keys.Enter && keyData.ToString().Equals("W")) // player 1 controls
            {
                Point position = panel1.Location;
                if (position.Y >= 10)
                {
                    panel1.Location = new Point(position.X, position.Y - 15);

                }
                return base.ProcessCmdKey(ref msg, keyData);
            } if (keyData != Keys.Enter && keyData.ToString().Equals("S"))
            { 
                Point position = panel1.Location;
                if (position.Y <= 410)
                {
                    panel1.Location = new Point(position.X, position.Y + 15);
                }
                return base.ProcessCmdKey(ref msg, keyData);
            } if (!onePLayer)
            {
                if (keyData != Keys.Enter && keyData.ToString().Equals("Up")) // player 2 controls, just in mode 2 players
                {
                    Point position = panel2.Location;
                    if (position.Y >= 10)
                    {
                        panel2.Location = new Point(position.X, position.Y - 15);

                    }
                    return base.ProcessCmdKey(ref msg, keyData);
                } if (keyData != Keys.Enter && keyData.ToString().Equals("Down"))
                {
                    Point position = panel2.Location;
                    if (position.Y <= 410)
                    {
                        panel2.Location = new Point(position.X, position.Y + 15);
                    }
                    return base.ProcessCmdKey(ref msg, keyData);
                }
            } if (keyData == Keys.Enter) // press entre for star round
            {
                startBall = true;
                label1.Visible = false;
            }
                return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            myTimer.Start();

            Point positionBot = panel2.Location,
                  ballPosition = PicBoxBall.Location,
                  playerPosition = panel1.Location,
                  botPosition = panel2.Location;

            if (onePLayer)
            {
                panel2.Location = new Point(positionBot.X, positionBot.Y + speedBot);
                if (panel2.Top < 10 || panel2.Top > 430)
                {
                    speedBot = -speedBot;
                }
            }
            if (startBall)
            {
                PicBoxBall.Location = new Point(ballPosition.X + ballX, ballPosition.Y + ballY);

                if (PicBoxBall.Bounds.IntersectsWith(panel1.Bounds) || PicBoxBall.Bounds.IntersectsWith(panel2.Bounds))
                {
                    ballX = -ballX;
                }

                if (PicBoxBall.Top < 10 || PicBoxBall.Top + PicBoxBall.Height > ClientSize.Height)
                {
                    ballY = -ballY;
                }
                if (PicBoxBall.Left < 0) // player 2 has gol
                {
                    PicBoxBall.Left = 434;
                    ballX = -ballX;
                    pointsBot++;
                    startBall = false;
                    winner();
                }
                
                if (PicBoxBall.Left + PicBoxBall.Width > ClientSize.Width) // player 1 has gol
                {
                    PicBoxBall.Left = 434;
                    ballX = -ballX;
                    pointsPlayer++;
                    startBall = false;
                    winner();
                }
                marcador2.Text = pointsBot.ToString();
                marcador1.Text = pointsPlayer.ToString();
            }
            
        }
        private void winner() // ser String for winner form
        {
            if (pointsBot == 5)
            {
                if (onePLayer)
                {
                    Form3 form = new Form3("CPU WIN THE GAME");
                    form.Show();

                    pointsPlayer = 0;
                    pointsBot = 0;

                    this.Close(); // close for prevent bugs with timer
                } else
                {
                    Form3 form = new Form3("PLAYER 2 WIN THE GAME");
                    form.Show();

                    pointsPlayer = 0;
                    pointsBot = 0;

                    this.Close();
                }
            } else if (pointsPlayer == 5)
            {
                Form3 form = new Form3("PLAYER 1 WIN THE GAME");
                form.Show();

                pointsPlayer = 0;
                pointsBot = 0;

                this.Close();
            }
        }
    }
}