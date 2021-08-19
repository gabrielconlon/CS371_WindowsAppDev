using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompoundInterest
{
    public partial class CompoundInterest : Form
    {
        public CompoundInterest()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double principle = Convert.ToDouble(principle_tb.Text);
            double interest = Convert.ToDouble(interest_tb.Text);
            int years = Convert.ToInt32(years_updown.Value);

            string display = "Year\tAmount\r\n";

            for (int cnt = 1; cnt <= years; ++cnt)
            {
                double amt = principle * Math.Pow(1 + interest / 100, cnt);
                display += cnt + "\t"; 
                display += string.Format("{0:C} ", amt) + "\r\n";
            }

            display_tb.Text = display;
        }

        private void drawComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics graphics = drawingPanel.CreateGraphics();
            Pen pen = new Pen(Color.DarkGreen);

            graphics.Clear(drawingPanel.BackColor);

            switch (drawComboBox.SelectedIndex)
            {
                case 0:
                    graphics.DrawEllipse(pen, 10, 10, 30, 30);
                    break;
                case 1:
                    graphics.DrawRectangle(pen, 10, 45, 30, 30);
                    break;
                case 2:
                    graphics.FillEllipse(new SolidBrush(Color.Blue),
                        10, 80, 30, 30);
                    break;
            }

            graphics.Dispose();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            changer.ForeColor = Color.Red;
        }

        private void size14_RBTN_CheckedChanged(object sender, EventArgs e)
        {
            changer.Font = new Font(changer.Font.FontFamily, 14);
        }

        private void sizenince_RBTN_CheckedChanged(object sender, EventArgs e)
        {
            changer.Font = new Font(changer.Font.FontFamily, 9);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            changer.ForeColor = Color.Blue;
        }

    }
}
