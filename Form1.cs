using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Pingpong
{
    public partial class Form1 : Form
    {
        public int speedLeft = 12;   //speed of ball
        public int speedTop = 12;
        public int point = 0;   // scored point


        public Form1()
        {
            InitializeComponent();
            
            timer1.Enabled = true;
            Cursor.Hide();// hide coursor

            this.FormBorderStyle = FormBorderStyle.None;//remove border 
            this.TopMost = true;                        // Bring the form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds;  // make it fullscreen

            racket.Top = BackGround.Bottom - (BackGround.Bottom / 10);  //set the postion of racket
            gameover.Left = (BackGround.Width / 2) - (gameover.Width / 2);
            gameover.Top = (BackGround.Height / 2) - (gameover.Height / 2);
            gameover.Visible = false;
           ;
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);

            ball.Left += speedLeft;
            ball.Top += speedTop;
            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom
                    && ball.Left >= racket.Left && ball.Right <= racket.Right)  // Collision
            {
                speedTop += 2;
                speedLeft += 2;
                speedTop = -speedTop;   //change direction
                point += 1;
                point_lbl.Text= point.ToString();//print point
                Random r = new Random();
                ball.Top = r.Next(1, 50);
                ball.Left = r.Next(1, 1500);


                Random a = new Random();
                BackGround.BackColor = Color.FromArgb(a.Next(150, 255),
                    a.Next(150, 255), a.Next(150, 255));

            }

            if (ball.Left <= BackGround.Left)
            {
                speedLeft = -speedLeft;
            }

            if (ball.Right >= BackGround.Right)
            {
                speedLeft = -speedLeft;
            }

            if (ball.Top <= BackGround.Top)
            {
                speedTop = -speedTop;
            }

            if (ball.Bottom >= BackGround.Bottom)
            {
                timer1.Enabled = false; //ball ís out-> game end
                gameover.Visible = true;
                
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)   //press esc to quit
            {
                this.Close();
                
            }
            if (e.KeyCode== Keys.F1)    //Game restart 
            {
                ball.Top = 50;
                ball.Left = 50;
                speedLeft = 12;   
                speedTop = 12;
                point = 0;
                point_lbl.Text = "0";
                timer1.Enabled = true;
                gameover.Visible = false;

            }
        }

        
    }
}
