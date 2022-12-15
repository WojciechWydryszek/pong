namespace Pong
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.marcador1 = new System.Windows.Forms.Label();
            this.marcador2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PicBoxBall = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBall)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(34, 143);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(882, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(34, 143);
            this.panel2.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(376, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Press ENTER to start";
            // 
            // marcador1
            // 
            this.marcador1.AutoSize = true;
            this.marcador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcador1.ForeColor = System.Drawing.Color.White;
            this.marcador1.Location = new System.Drawing.Point(178, 8);
            this.marcador1.Name = "marcador1";
            this.marcador1.Size = new System.Drawing.Size(35, 37);
            this.marcador1.TabIndex = 5;
            this.marcador1.Text = "0";
            // 
            // marcador2
            // 
            this.marcador2.AutoSize = true;
            this.marcador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcador2.ForeColor = System.Drawing.Color.White;
            this.marcador2.Location = new System.Drawing.Point(684, 8);
            this.marcador2.Name = "marcador2";
            this.marcador2.Size = new System.Drawing.Size(35, 37);
            this.marcador2.TabIndex = 6;
            this.marcador2.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(2, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(928, 10);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(447, -3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 642);
            this.panel4.TabIndex = 8;
            // 
            // PicBoxBall
            // 
            this.PicBoxBall.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxBall.Image = global::Pong.Properties.Resources.Ski_trail_rating_symbol_black_circle11;
            this.PicBoxBall.Location = new System.Drawing.Point(430, 320);
            this.PicBoxBall.Name = "PicBoxBall";
            this.PicBoxBall.Size = new System.Drawing.Size(41, 42);
            this.PicBoxBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxBall.TabIndex = 3;
            this.PicBoxBall.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(389, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Press ESC to exit";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "PAUSE";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(928, 639);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PicBoxBall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.marcador2);
            this.Controls.Add(this.marcador1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox PicBoxBall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label marcador1;
        private System.Windows.Forms.Label marcador2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}