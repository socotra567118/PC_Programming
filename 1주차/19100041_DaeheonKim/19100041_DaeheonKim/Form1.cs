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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int currentNumber = Convert.ToInt32(count.Text);

            count.Text = Convert.ToString(currentNumber += 1);
        }
    }
}
