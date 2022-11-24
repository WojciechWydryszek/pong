namespace Pong
{
    partial class Form2
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
            this.PicBoxBall = new System.Windows.Forms.PictureBox();
            this.marcador1 = new System.Windows.Forms.Label();
            this.marcador2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBall)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(34, 143);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Press ENTER to start";
            // 
            // PicBoxBall
            // 
            this.PicBoxBall.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxBall.Image = global::Pong.Properties.Resources.Ski_trail_rating_symbol_black_circle1;
            this.PicBoxBall.Location = new System.Drawing.Point(434, 219);
            this.PicBoxBall.Name = "PicBoxBall";
            this.PicBoxBall.Size = new System.Drawing.Size(43, 47);
            this.PicBoxBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxBall.TabIndex = 3;
            this.PicBoxBall.TabStop = false;
            // 
            // marcador1
            // 
            this.marcador1.AutoSize = true;
            this.marcador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcador1.Location = new System.Drawing.Point(177, 22);
            this.marcador1.Name = "marcador1";
            this.marcador1.Size = new System.Drawing.Size(29, 31);
            this.marcador1.TabIndex = 5;
            this.marcador1.Text = "0";
            // 
            // marcador2
            // 
            this.marcador2.AutoSize = true;
            this.marcador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcador2.Location = new System.Drawing.Point(738, 22);
            this.marcador2.Name = "marcador2";
            this.marcador2.Size = new System.Drawing.Size(29, 31);
            this.marcador2.TabIndex = 6;
            this.marcador2.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.marcador2);
            this.Controls.Add(this.marcador1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicBoxBall);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
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
    }
}