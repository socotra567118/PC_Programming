using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19100041_DaeheonKim
{
    public partial class Form1 : Form
    {
        private const int SlowSpeed = 2;
        private const int FastSpeed = 4;
        private const int BallSize = 20;

        private bool isMovingRight = true;
        private bool isMovingDown = true;

        private int ballXPosition;
        private int ballYPosition;
        private double diagonal;

        private int ballSpeed = SlowSpeed;

        private Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();

            this.ClientSize = new Size(600, 400);

            diagonal = Math.Sqrt(Math.Pow(ClientSize.Width, 2) + Math.Sqrt(Math.Pow(ClientSize.Height, 2)));

            isSlow.CheckedChanged += Radio_ChangeChecked;
            isFast.CheckedChanged += Radio_ChangeChecked;

            timer.Interval = ballSpeed;
            timer.Tick += Timer_Thick;
            timer.Start();
        }

        private void Timer_Thick(object sender, EventArgs e)
        {
            double ballSpeedSqrt = Math.Sqrt(ballSpeed);

            ballXPosition += isMovingRight ? Convert.ToInt32(ballSpeedSqrt) : -Convert.ToInt32(ballSpeedSqrt);
            ballYPosition += isMovingDown ? Convert.ToInt32(ballSpeedSqrt) : -Convert.ToInt32(ballSpeedSqrt);

            if (ballXPosition < 0 || ballXPosition + BallSize > this.ClientSize.Width)
            {
                isMovingRight = !isMovingRight;
            }

            if (ballYPosition < 0 || ballYPosition + BallSize > this.ClientSize.Height)
            {
                isMovingDown = !isMovingDown;
            }

            int red = 255 - (int)(retrunLengthFromPosition() / diagonal * 255);
            int blue = (int)(retrunLengthFromPosition() / diagonal * 255);
            Color ballColor = Color.FromArgb(red, 0, blue);

            ball.BackColor = ballColor;

            ball.Location = new Point(ballXPosition, ballYPosition);
        }

        private void Radio_ChangeChecked(object sender, EventArgs e)
        {
            ballSpeed = isSlow.Checked ? SlowSpeed : FastSpeed;
            timer.Interval = Convert.ToInt32(Math.Sqrt(ballSpeed));
        }

        private double retrunLengthFromPosition()
        {
            if (ballXPosition < 0)
            {
                ballXPosition = 0;
            }
            else if (ballXPosition > this.ClientSize.Width)
            {
                ballXPosition = this.ClientSize.Width;
            }

            if (ballYPosition < 0)
            {
                ballYPosition = 0;
            }
            else if (ballYPosition > this.ClientSize.Height)
            {
                ballYPosition = this.ClientSize.Height;
            }

            return Math.Sqrt(Math.Pow(ballXPosition, 2) + Math.Pow(ballYPosition, 2));
        }


    }
}
