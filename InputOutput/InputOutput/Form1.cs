using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace InputOutput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void write_BTN_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                string filename = dialog.FileName;
                using (FileStream writer = new FileStream(filename, FileMode.OpenOrCreate))
                {

                    UTF8Encoding utf = new UTF8Encoding();
                    string text_nl = "\r\n" + textBox1.Text;
                    writer.Seek(0, SeekOrigin.End);
                    writer.Write(utf.GetBytes(text_nl), 0, utf.GetByteCount(text_nl));
                }
            }


        }

        

        private void open_BTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.RestoreDirectory = true; //defaults you to the directory you are running from
            dialog.Filter = "Text File(*.txt)|*.txt|All Files (*.*)|*.*";
            dialog.FilterIndex = 2;

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                string filename = dialog.FileName;
                FileStream reader = new FileStream(filename, FileMode.Open);
                byte[] buffer = new byte[reader.Length];
                UTF8Encoding utf = new UTF8Encoding();

                reader.Read(buffer, 0, buffer.Length);

                string line = new string(utf.GetChars(buffer), 0, utf.GetCharCount(buffer));

                textBox1.Text = line;
                reader.Dispose();
            }
        }
    }
}
