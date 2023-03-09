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

        private void toBitBtn_Click(object sender, EventArgs e)
        {
            SetCheckBoxes(Convert.ToUInt32(numberLabel.Text));
        }

        private void fromBitBtn_Click(object sender, EventArgs e)
        {
            numberLabel.Text = GetFromCheckBoxes().ToString();
        }

        private void onBtn_Click(object sender, EventArgs e)
        {
            ToggleBit(value: true);
        }

        private void offBtn_Click(object sender, EventArgs e)
        {
            ToggleBit(value: false);
        }

        private void toggleBtn_Click(object sender, EventArgs e)
        {
            check1.Checked = (check1.Checked) ? false : true;
            check2.Checked = (check2.Checked) ? false : true;
            check3.Checked = (check3.Checked) ? false : true;
            check4.Checked = (check4.Checked) ? false : true;
            check5.Checked = (check5.Checked) ? false : true;
            check6.Checked = (check6.Checked) ? false : true;
            check7.Checked = (check7.Checked) ? false : true;
            check8.Checked = (check8.Checked) ? false : true;

            numberLabel.Text = GetFromCheckBoxes().ToString();
        }

        private void shiftUpBtn_Click(object sender, EventArgs e)
        {
            ShiftNumber(isUp: true);
        }

        private void shiftDownBtn_Click(object sender, EventArgs e)
        {
            ShiftNumber(isUp: false);
        }


        private void SetCheckBoxes(uint number)
        {
            check1.Checked = ((number & 0x01) != 0) ? true : false;
            check2.Checked = ((number & 0x02) != 0) ? true : false;
            check3.Checked = ((number & 0x04) != 0) ? true : false;
            check4.Checked = ((number & 0x08) != 0) ? true : false;
            check5.Checked = ((number & 0x10) != 0) ? true : false;
            check6.Checked = ((number & 0x20) != 0) ? true : false;
            check7.Checked = ((number & 0x40) != 0) ? true : false;
            check8.Checked = ((number & 0x80) != 0) ? true : false;
        }

        private uint GetFromCheckBoxes()
        {
            uint decimalNumber = 0;

            if (check1.Checked) decimalNumber = decimalNumber | (0x01 << 0);
            if (check2.Checked) decimalNumber = decimalNumber | (0x01 << 1);
            if (check3.Checked) decimalNumber = decimalNumber | (0x01 << 2);
            if (check4.Checked) decimalNumber = decimalNumber | (0x01 << 3);
            if (check5.Checked) decimalNumber = decimalNumber | (0x01 << 4);
            if (check6.Checked) decimalNumber = decimalNumber | (0x01 << 5);
            if (check7.Checked) decimalNumber = decimalNumber | (0x01 << 6);
            if (check8.Checked) decimalNumber = decimalNumber | (0x01 << 7);

            return decimalNumber;
        }

        private void ToggleBit(bool value)
        {
            uint currentNumber = GetFromCheckBoxes();
            uint newNumber = Convert.ToUInt32(0x1 << Convert.ToInt32(indexLabel.Text));

            currentNumber = value ? currentNumber | newNumber : currentNumber & ~newNumber;

            numberLabel.Text = currentNumber.ToString();
            SetCheckBoxes(currentNumber);
        }

        private void ShiftNumber(bool isUp)
        {
            uint cuurentNumber = isUp ? GetFromCheckBoxes() << 1 : GetFromCheckBoxes() >> 1;
            numberLabel.Text = cuurentNumber.ToString();
            SetCheckBoxes(cuurentNumber);
        }
    }
}
