using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChildForms
{
    public partial class Address : Form
    {
        public Address()
        {
            InitializeComponent();
        }

        private void goodbye_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
