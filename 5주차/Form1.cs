using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19100041_DaeheonKim
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        static int dotNumber = 100000;

        int[] xPositions = new int[dotNumber];
        int[] yPositions = new int[dotNumber];

        (int x, int y) firstPosition = (160, 70);
        (int x, int y) secondPosition = (50, 410);
        (int x, int y) thirdPosition = (340, 290);

        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(400, 500);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Make1000Dots();
            PaintDots();
        }

        private void Make1000Dots()
        {
            for (int i = 0; i < dotNumber; i += 1)
            {
                xPositions[i] = random.Next(0, DotArea.ClientSize.Width + 1);
                yPositions[i] = random.Next(0, DotArea.ClientSize.Height + 1);
            }
        }

        private void PaintDots()
        {
            Graphics graphics = DotArea.CreateGraphics();
            Pen lightGrayPen = new Pen(Color.LightGray);
            Pen blackPen = new Pen(Color.Black);

            for (int i = 0; i < dotNumber; i += 1)
            {
                int xDot = xPositions[i];
                int yDot = yPositions[i];

                double firstArea = ReturnArea(first: (xDot, yDot), second: firstPosition, third: secondPosition);
                double secondArea = ReturnArea(first: (xDot, yDot), second: thirdPosition, third: firstPosition);
                double thirdArea = ReturnArea(first: (xDot, yDot), second: secondPosition, third: thirdPosition);

                if (IsInTriangle(first: firstArea, second: secondArea, third: thirdArea))
                {
                    graphics.DrawEllipse(blackPen, xDot, yDot, 1, 1);
                } else
                {
                    graphics.DrawEllipse(lightGrayPen, xDot, yDot, 1, 1);
                }

                
            }
        }

        private bool IsInTriangle(double first, double second, double third)
        {
            if (first < 0 && second < 0 && third < 0)
            {
                return true;
            } else if (first > 0 && second > 0 && third > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        private double ReturnArea((int xPosition, int yPosition) first, (int xPosition, int yPosition) second, (int xPosition, int yPosition) third)
        {
            int firstElement = first.xPosition * second.yPosition +
                               second.xPosition * third.yPosition +
                               third.xPosition * first.yPosition;

            int secondElement = first.xPosition * third.yPosition +
                               second.xPosition * first.yPosition +
                               third.xPosition * second.yPosition;

            return 0.5 * Convert.ToDouble(firstElement - secondElement);
        }
    }
}
