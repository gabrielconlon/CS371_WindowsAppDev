using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Color getColor()
        {
            switch (colorChoice.SelectedIndex)
            {
                case 0:
                    return Color.Black;
                case 1:
                    return Color.Red;
                case 2:
                    return Color.Orange;
                case 3:
                    return Color.Yellow;
                case 4:
                    return Color.Green;
                case 5:
                    return Color.Blue;
                case 6:
                    return Color.Indigo;
                case 7:
                    return Color.Violet;
            }
            return Color.Black;
        }

        private int getSize()
        {
            switch (sizeChoice.SelectedIndex)
            {
                case 0:
                    return 4;
                case 1:
                    return 8;
                case 2:
                    return 16;
                case 3:
                    return 32;
            }
            return 4;
        }

        bool drawnow = false;
        bool eraser = false;

        private void drawingCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            drawnow = true;
            if (e.Button == MouseButtons.Right)
                eraser = true;

        }

        private void drawingCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            drawnow = false;
            if (e.Button == MouseButtons.Right)
                eraser = false;
        }

        private void drawingCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawnow)
            {
                if (eraser == false)
                {
                    using (Graphics graphics = drawingCanvas.CreateGraphics())
                    {
                        graphics.FillEllipse(new SolidBrush(getColor()), e.X, e.Y, getSize(), getSize());
                    }
                }
                if (eraser == true)
                {
                    using (Graphics graphics = drawingCanvas.CreateGraphics())
                    {
                        graphics.FillEllipse(new SolidBrush(Color.White), e.X, e.Y, getSize(), getSize());
                    }
                }
            }
        }

        private void clear_BTN_Click(object sender, EventArgs e)
        {
            using(Graphics graphics = drawingCanvas.CreateGraphics())
            {
                graphics.Clear(Color.White);
            }
        }

        //private void undo_BTN_Click(object sender, EventArgs e)
        //{
        //    int count = drawingCanvas.Children.Count;

        //}


    }
}
