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

        double xMin = -2;
        double xMax = 7;
        double yMin = -5;
        double yMax = 70;

        double[] xPoint = new double[6] { 1, 2, 3, 4, 5, 6 };
        double[] yPoint = new double[6] { 2.1, 7.7, 13.6, 27.2, 40.9, 61.1 };

        public Form1()
        {
            InitializeComponent();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            Graphics graphic = GraphicBox.CreateGraphics();
            DrawCoordinate(graphic);
            DrawPoints(graphic);
            DrawGraph(graphic);
        }

        private float ReturnXPoint(double xPoint)
        {
            return (float)(GraphicBox.ClientSize.Width * (xPoint - xMin) / (xMax - xMin));
        }

        private float ReturnYPoint(double yPoint)
        {
            return (float)(GraphicBox.ClientSize.Height * (yPoint - yMin) / (yMax - yMin));
        }

        private void DrawCoordinate(Graphics graphic)
        {
            graphic.DrawLine(new Pen(Color.LightGray), ReturnXPoint(xMin), ReturnYPoint(0), ReturnXPoint(xMax), ReturnYPoint(0));
            graphic.DrawLine(new Pen(Color.LightGray), ReturnXPoint(0), ReturnYPoint(yMin), ReturnXPoint(0), ReturnYPoint(yMax));
        }

        private void DrawPoints(Graphics graphic)
        {
            for (int i = 0; i < 6; i+=1)
            {
                float xDot = ReturnXPoint(xPoint[i]);
                float yDot = ReturnYPoint(yPoint[i]);
                graphic.DrawEllipse(new Pen(Color.Black), xDot, yDot, 1, 1);
            }
        }

        private void DrawGraph(Graphics graphics)
        {
            double sumX = 0, sumY = 0, sumXY = 0, sumXX = 0;

            for (int i = 0; i < 6;i+=1)
            {
                sumX += xPoint[i];
                sumY += yPoint[i];
                sumXY += xPoint[i] * yPoint[i];
                sumXX += xPoint[i] * xPoint[i];
            }

            double a = (6 * sumXY - sumX * sumY) / (6 * sumXX - sumX * sumX);
            double b = (sumY - a * sumX) / 6;
            double y1 = a * xMin + b;
            double y2 = a * xMax + b;

            graphics.DrawLine(new Pen(Color.Red), ReturnXPoint(xMin), ReturnYPoint(y1), ReturnXPoint(xMax), ReturnYPoint(y2));
        }
    }
}
