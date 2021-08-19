using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyBooks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BooksDataContext database = new BooksDataContext();

        private void query_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (query_CB.SelectedIndex)
            {
                case 0: //titles
                    var allTitle = from title in database.Titles
                                   select title.Title1;
                    display_TB.Text = "All Titles: \r\n";
                    foreach (var title in allTitle)
                        display_TB.Text += title + "\r\n";
                    break;
                case 1: //authors
                    var allAuthors = from author in database.Authors
                                     orderby author.LastName
                                     select author;
                    display_TB.Text = "All Authors:\r\n";
                    foreach (var author in allAuthors)
                        display_TB.Text += author.FirstName + " " + author.LastName + "\r\n";
                    break;
                case 2:
                    var titlesbyauthor = from author in database.Authors
                                         select new
                                         {
                                             Name = author.FirstName + " " + author.LastName,
                                             Titles = from title in author.AuthorISBNs
                                                      select title.Title.Title1
                                         };
                    display_TB.Text = "Titles Grouped by Author\r\n";
                    foreach (var author in titlesbyauthor)
                    {
                        display_TB.Text += author.Name + "\r\n";
                        foreach (var title in author.Titles)
                        {
                            display_TB.Text += "\t\t" + title + "\r\n";
                        }
                    }
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            authorBindingSource.DataSource = from author in database.Authors
                                             select author;

        }

        private void authorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            authorBindingSource.EndEdit();
            database.SubmitChanges();
        }




    }
}
