using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Height = 500;
        }

        private void btnNameEntry_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNameEntry.Text))
            {
                MessageBox.Show("Please enter a name in the textbox to continue.", "Name Not Found");
                txtNameEntry.Focus();
            }
            else
            {
                lblNameEntry.Text = "Name: ";
                btnNameEntry.Visible = false;
                txtNameEntry.ReadOnly = true;
                lblSelectTrans.Visible = true;
                btnSearchBook.Visible = true;
                btnAddBook.Visible = true;
            }
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            btnAddBook.Visible = false;
            btnSearchBook.Enabled = false;

            lblTransTitle.Text = "Search Book Transaction";
            lblTransTitle.Visible = true;

            lblKeywordSearch.Visible = true;
            txtKeywordSearch.Visible = true;

            btnSearchOK.Visible = true;
            btnSearchCancel.Visible = true;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            btnSearchBook.Visible = false;
            btnAddBook.Enabled = false;

            lblTransTitle.Text = "Add Book Transaction";
            lblTransTitle.Visible = true;

            lblBookTitleAdd.Visible = true;
            txtBookTitleAdd.Visible = true;
            lblBookAuthorAdd.Visible = true;
            txtBookAuthorAdd.Visible = true;
            lblBookKeywordAdd.Visible = true;
            txtBookKeywordAdd.Visible = true;

            btnAddOK.Visible = true;
            btnAddCancel.Visible = true;
        }

        private void btnSearchCancel_Click(object sender, EventArgs e)
        {
            btnAddBook.Visible = true;
            btnSearchBook.Enabled = true;

            lblTransTitle.Text = "Transaction Title";
            lblTransTitle.Visible = false;

            lblKeywordSearch.Visible = false;
            txtKeywordSearch.Visible = false;
            txtKeywordSearch.Text = "";

            btnSearchOK.Visible = false;
            btnSearchCancel.Visible = false;
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            btnSearchBook.Visible = true;
            btnAddBook.Enabled = true;

            lblTransTitle.Text = "Transaction Title";
            lblTransTitle.Visible = false;

            lblBookTitleAdd.Visible = false;
            txtBookTitleAdd.Visible = false;
            txtBookTitleAdd.Text = "";
            lblBookAuthorAdd.Visible = false;
            txtBookAuthorAdd.Visible = false;
            txtBookAuthorAdd.Text = "";
            lblBookKeywordAdd.Visible = false;
            txtBookKeywordAdd.Visible = false;
            txtBookKeywordAdd.Text = "";

            btnAddOK.Visible = false;
            btnAddCancel.Visible = false;
        }
    }
}
