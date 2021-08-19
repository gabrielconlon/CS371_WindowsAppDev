using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace CleanupDirectory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Search_TB_KeyDown(object sender, KeyEventArgs e)
        {
            clean_BTN.Enabled = false;

            if (e.KeyCode != Keys.Enter)
                return;

            string filename = Search_TB.Text;
            if (File.Exists(filename))
            {


                multiline_TB.Text = "File " + filename + " exists!\r\n";
                multiline_TB.Text += "Created: " + File.GetCreationTime(filename) + "\r\n";
                multiline_TB.Text += "Modified: " + File.GetLastWriteTime(filename) + "\r\n";
                multiline_TB.Text += "Accesses: " + File.GetLastAccessTime(filename) + "\r\n";
            }
            else if(Directory.Exists(filename))
            {
                clean_BTN.Enabled = true;

                multiline_TB.Text = "Directory " + filename + " exists!\r\n";
                multiline_TB.Text += "Created: " + Directory.GetCreationTime(filename);
                multiline_TB.Text += "Modified: " + Directory.GetLastWriteTime(filename);
                multiline_TB.Text += "Accesses: " + Directory.GetLastAccessTime(filename);
            }
            else
            {
                MessageBox.Show("Name " + filename + " does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cleanDir()
        {
            string dirname = Search_TB.Text;
            string[] files = Directory.GetFiles(dirname);

            var filesBackup = from file in files
                              where Path.GetExtension(file) == ".bak"
                              select file;
            foreach (var file in filesBackup)
            {
                if (Path.GetExtension(file) == ".bak")
                {
                    DialogResult result = MessageBox.Show("Delete file " + file + " ?", "Question",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        File.Delete(file);
                    }
                }
            }
        }

        private void clean_BTN_Click(object sender, EventArgs e)
        {
            clean_BTN.Enabled = false;
            cleanDir();
            clean_BTN.Enabled = true;
        }
    }
}
