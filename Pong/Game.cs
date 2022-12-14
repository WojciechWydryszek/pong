using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pong
{
    public partial class Game : Form
    {
        Timer myTimer = new Timer();

        private static Boolean startBall,
                               onePLayer,
                               pause;
                
        private static int speedBot,
                           ballX,
                           ballY,
                           pointsPlayer,
                           pointsBot;

        private int difficulty;

        private const int topMoviment = 85,
                          botMoviment = 465;

        public Game() // constructor for restart game
        {
            InitializeComponent();
            startValues();
        }
        public Game(int difficulty, bool b) // pass if is game for 1 or 2 players
        {
            InitializeComponent();
            this.difficulty = difficulty;
            onePLayer = b;
            startValues();
        }

        private void startValues() // initial values
        {
            if(difficulty == 1)
                speedBot = 2;
            else if (difficulty == 2)
                speedBot = 5;
            else if(difficulty == 3)
                speedBot = 9;
            else if(difficulty == 4)
                speedBot = 9;
            ballX = -5;
            ballY = 5;
            pointsPlayer = 0;
            pointsBot = 0;
            pause = false;
            startBall = false;
            label3.Visible = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // overide medoth for keyboard load
        {
            Point positionPlayer = panel1.Location,
                  positionBot = panel2.Location;

            if (pause)
            {
                if (keyData != Keys.Enter && keyData.ToString().Equals("Escape"))
                {
                    Home home = new Home();
                    home.Show();
                    this.Close();
                }
            }

            if (keyData != Keys.Enter && keyData.ToString().Equals("Escape"))
            {
                startBall = false;
                timer1.Stop();
                label1.Visible = true;
                pause = true;
                label2.Visible = true;
                label3.Visible = true;
            }
            if (!pause)
            {

                if (keyData != Keys.Enter && keyData.ToString().Equals("W") && positionPlayer.Y >= topMoviment) // player 1 controls
                {
                    panel1.Location = new Point(positionPlayer.X, positionPlayer.Y - 15);

                    return base.ProcessCmdKey(ref msg, keyData);
                }
                if (keyData != Keys.Enter && keyData.ToString().Equals("S") && positionPlayer.Y <= botMoviment)
                {
                    panel1.Location = new Point(positionPlayer.X, positionPlayer.Y + 15);

                    return base.ProcessCmdKey(ref msg, keyData);
                }
                if (!onePLayer)
                {
                    if (keyData != Keys.Enter && keyData.ToString().Equals("Up") && positionBot.Y >= topMoviment) // player 2 controls, just in mode 2 players
                    {
                        panel2.Location = new Point(positionBot.X, positionBot.Y - 15);

                        return base.ProcessCmdKey(ref msg, keyData);

                    }
                    if (keyData != Keys.Enter && keyData.ToString().Equals("Down") && positionBot.Y <= botMoviment)
                    {
                        panel2.Location = new Point(positionBot.X, positionBot.Y + 15);

                        return base.ProcessCmdKey(ref msg, keyData);
                    }
                }

            }

            if (keyData == Keys.Enter) // press entre for star round
            {
                startBall = true;
                label1.Visible = false;
                timer1.Start();
                pause = false;
                label2.Visible = false;
                label3.Visible = false;
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
                if (difficulty == 4)
                {
                    if (ballPosition.Y >= 550)
                    {
                        panel2.Location = new Point(positionBot.X, positionBot.Y = positionBot.Y);
                    } else if (ballPosition.Y <= 110)
                    {
                        panel2.Location = new Point(positionBot.X, positionBot.Y = positionBot.Y);
                    }
                    else
                    {
                        panel2.Location = new Point(positionBot.X, ballPosition.Y - 50);
                    }
                }
                else
                {
                    panel2.Location = new Point(positionBot.X, positionBot.Y + speedBot);
                    if (panel2.Top < topMoviment || panel2.Top > botMoviment)
                    {
                        speedBot = -speedBot;
                    }
                }
            }
            if (startBall)
            {
                PicBoxBall.Location = new Point(ballPosition.X + ballX, ballPosition.Y + ballY);

                if (PicBoxBall.Bounds.IntersectsWith(panel1.Bounds) || PicBoxBall.Bounds.IntersectsWith(panel2.Bounds))
                {
                    ballX = -ballX;
                    PicBoxBall.Location = new Point(ballPosition.X + 4, ballPosition.Y + ballY);
                }

                if (PicBoxBall.Top < topMoviment || PicBoxBall.Top + PicBoxBall.Height > ClientSize.Height)
                {
                    ballY = -ballY;
                    PicBoxBall.Location = new Point(ballPosition.X + 4, ballPosition.Y + ballY);
                }

                if (PicBoxBall.Left < 0) // player 2 has gol
                {
                    AddPoint(false);
                }
                
                if (PicBoxBall.Left + PicBoxBall.Width > ClientSize.Width) // player 1 has gol
                {
                    AddPoint(true);
                }
                marcador2.Text = pointsBot.ToString();
                marcador1.Text = pointsPlayer.ToString();
            }
            
        }

        private void AddPoint(bool player)
        {
            PicBoxBall.Left = 430;
            PicBoxBall.Top = 320;
            ballX = -ballX;
            if (player)
                pointsPlayer++;
            else
                pointsBot++;
            startBall = false;
            label1.Visible = true;
            winner();
        }

        private void winner() // set String for winner form
        {
            String message = null;
            if (pointsBot == 5)
            {
                if (onePLayer)
                {
                    message = "CPU WINS THE GAME";
                } else
                {
                    message = "PLAYER 2 WINS THE GAME";
                }

                RestartPoints(message);
            }
            else if (pointsPlayer == 5)
            {
                message = "PLAYER 1 WINS THE GAME";

                RestartPoints(message);
            }
        }
        private void RestartPoints(String message)
        {
            Winner form = new Winner(message);

            form.Show();

            pointsPlayer = 0;
            pointsBot = 0;

            myTimer.Stop();

            this.Close();
        }
    }
}