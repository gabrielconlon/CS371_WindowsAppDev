using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX6_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PeopleDataDataContext database = new PeopleDataDataContext();
        private void name_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (name_CB.SelectedIndex)
            {
                case 0:
                    var allPeoplebylastname = from person in database.Peoples
                                              orderby person.LastName ascending
                                               select person;
                    textBox1.Text = "Ordered by Last Name:\r\n";
                    foreach (var person in allPeoplebylastname)
                    {
                        textBox1.Text += person.LastName + " " + person.FirstName + " " + person.Rank + "\r\n";
                    }
                    break;
                case 1:
                    var allpeoplebyfirstname = from person in database.Peoples
                                               orderby person.FirstName ascending
                                               select person;
                    textBox1.Text = "Ordered by First Name:\r\n";
                    foreach (var person in allpeoplebyfirstname)
                    {
                        textBox1.Text += person.FirstName + " " + person.LastName + " " + person.Rank + "\r\n";
                    }
                    break;
                case 2 :
                    var allpeoplebyrank = from person in database.Peoples
                                          orderby person.RankCode descending
                                          select person;
                    textBox1.Text = "Ordered by Rank:\r\n";
                    foreach (var person in allpeoplebyrank)
                    {
                        textBox1.Text += person.Rank + " " + person.LastName + " " + person.FirstName + "\r\n";
                    }
                    break;
            }
        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rosterDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rosterDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.rosterDataSet.People);

        }
    }
}
