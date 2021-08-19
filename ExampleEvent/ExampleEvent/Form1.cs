using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExampleEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayLabel.Text = textBox1.Text;
        }

        private void hide_1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            textBox1.Visible = false;
            displayLabel.Visible = false;
        }

        private void unhide_1_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            textBox1.Visible = true;
            displayLabel.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (checkBox1.Checked)
                changedisplaylabel.BorderStyle = BorderStyle.Fixed3D;
            else
                changedisplaylabel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            changedisplaylabel.Font = new Font(changedisplaylabel.Font,changedisplaylabel.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            changedisplaylabel.Font = new Font(changedisplaylabel.Font, changedisplaylabel.Font.Style ^ FontStyle.Italic);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            changedisplaylabel.ForeColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            changedisplaylabel.ForeColor = Color.Blue;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            changedisplaylabel.ForeColor = Color.Black;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            changedisplaylabel.Font = new Font(changedisplaylabel.Font.FontFamily, 14);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            changedisplaylabel.Font = new Font(changedisplaylabel.Font.FontFamily, 24);
        }

        private int imagenumber = -1;

        private void nextimage_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(string.Format("image{0}", ++imagenumber % 3));
        }

        private bool drawnow = false;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drawnow = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drawnow = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawnow)
            {
                using (Graphics graphics = panel1.CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(Color.Blue), e.X, e.Y, 4, 4);
                }
            }
        }
    }
}
