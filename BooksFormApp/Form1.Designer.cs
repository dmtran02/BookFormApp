namespace BooksFormApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNameEntry = new System.Windows.Forms.Label();
            this.txtNameEntry = new System.Windows.Forms.TextBox();
            this.btnNameEntry = new System.Windows.Forms.Button();
            this.lblSelectTrans = new System.Windows.Forms.Label();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lblKeywordSearch = new System.Windows.Forms.Label();
            this.txtKeywordSearch = new System.Windows.Forms.TextBox();
            this.lblTransTitle = new System.Windows.Forms.Label();
            this.lblBookTitleAdd = new System.Windows.Forms.Label();
            this.lblBookAuthorAdd = new System.Windows.Forms.Label();
            this.lblBookKeywordAdd = new System.Windows.Forms.Label();
            this.txtBookTitleAdd = new System.Windows.Forms.TextBox();
            this.txtBookAuthorAdd = new System.Windows.Forms.TextBox();
            this.txtBookKeywordAdd = new System.Windows.Forms.TextBox();
            this.btnSearchOK = new System.Windows.Forms.Button();
            this.btnSearchCancel = new System.Windows.Forms.Button();
            this.btnAddOK = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(200, 30);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(118, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Books Form Application";
            // 
            // lblNameEntry
            // 
            this.lblNameEntry.AutoSize = true;
            this.lblNameEntry.Location = new System.Drawing.Point(115, 71);
            this.lblNameEntry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameEntry.Name = "lblNameEntry";
            this.lblNameEntry.Size = new System.Drawing.Size(87, 13);
            this.lblNameEntry.TabIndex = 1;
            this.lblNameEntry.Text = "Enter your name:";
            // 
            // txtNameEntry
            // 
            this.txtNameEntry.Location = new System.Drawing.Point(206, 70);
            this.txtNameEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNameEntry.Name = "txtNameEntry";
            this.txtNameEntry.Size = new System.Drawing.Size(116, 20);
            this.txtNameEntry.TabIndex = 2;
            // 
            // btnNameEntry
            // 
            this.btnNameEntry.Location = new System.Drawing.Point(332, 59);
            this.btnNameEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNameEntry.Name = "btnNameEntry";
            this.btnNameEntry.Size = new System.Drawing.Size(54, 37);
            this.btnNameEntry.TabIndex = 3;
            this.btnNameEntry.Text = "Submit";
            this.btnNameEntry.UseVisualStyleBackColor = true;
            this.btnNameEntry.Click += new System.EventHandler(this.btnNameEntry_Click);
            // 
            // lblSelectTrans
            // 
            this.lblSelectTrans.AutoSize = true;
            this.lblSelectTrans.Location = new System.Drawing.Point(68, 124);
            this.lblSelectTrans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectTrans.Name = "lblSelectTrans";
            this.lblSelectTrans.Size = new System.Drawing.Size(99, 13);
            this.lblSelectTrans.TabIndex = 4;
            this.lblSelectTrans.Text = "Select Transaction:";
            this.lblSelectTrans.Visible = false;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(174, 146);
            this.btnSearchBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(212, 23);
            this.btnSearchBook.TabIndex = 5;
            this.btnSearchBook.Text = "Search for a Book";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Visible = false;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(174, 184);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(212, 23);
            this.btnAddBook.TabIndex = 6;
            this.btnAddBook.Text = "Add a Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Visible = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lblKeywordSearch
            // 
            this.lblKeywordSearch.AutoSize = true;
            this.lblKeywordSearch.Location = new System.Drawing.Point(71, 257);
            this.lblKeywordSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKeywordSearch.Name = "lblKeywordSearch";
            this.lblKeywordSearch.Size = new System.Drawing.Size(65, 13);
            this.lblKeywordSearch.TabIndex = 7;
            this.lblKeywordSearch.Text = "Keyword(s): ";
            this.lblKeywordSearch.Visible = false;
            // 
            // txtKeywordSearch
            // 
            this.txtKeywordSearch.Location = new System.Drawing.Point(140, 255);
            this.txtKeywordSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKeywordSearch.Name = "txtKeywordSearch";
            this.txtKeywordSearch.Size = new System.Drawing.Size(247, 20);
            this.txtKeywordSearch.TabIndex = 8;
            this.txtKeywordSearch.Visible = false;
            // 
            // lblTransTitle
            // 
            this.lblTransTitle.AutoSize = true;
            this.lblTransTitle.Location = new System.Drawing.Point(212, 226);
            this.lblTransTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransTitle.Name = "lblTransTitle";
            this.lblTransTitle.Size = new System.Drawing.Size(108, 13);
            this.lblTransTitle.TabIndex = 9;
            this.lblTransTitle.Text = "The Transaction Title";
            this.lblTransTitle.Visible = false;
            // 
            // lblBookTitleAdd
            // 
            this.lblBookTitleAdd.AutoSize = true;
            this.lblBookTitleAdd.Location = new System.Drawing.Point(70, 316);
            this.lblBookTitleAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookTitleAdd.Name = "lblBookTitleAdd";
            this.lblBookTitleAdd.Size = new System.Drawing.Size(58, 13);
            this.lblBookTitleAdd.TabIndex = 10;
            this.lblBookTitleAdd.Text = "Book Title:";
            this.lblBookTitleAdd.Visible = false;
            // 
            // lblBookAuthorAdd
            // 
            this.lblBookAuthorAdd.AutoSize = true;
            this.lblBookAuthorAdd.Location = new System.Drawing.Point(60, 349);
            this.lblBookAuthorAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookAuthorAdd.Name = "lblBookAuthorAdd";
            this.lblBookAuthorAdd.Size = new System.Drawing.Size(69, 13);
            this.lblBookAuthorAdd.TabIndex = 11;
            this.lblBookAuthorAdd.Text = "Book Author:";
            this.lblBookAuthorAdd.Visible = false;
            // 
            // lblBookKeywordAdd
            // 
            this.lblBookKeywordAdd.AutoSize = true;
            this.lblBookKeywordAdd.Location = new System.Drawing.Point(64, 381);
            this.lblBookKeywordAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookKeywordAdd.Name = "lblBookKeywordAdd";
            this.lblBookKeywordAdd.Size = new System.Drawing.Size(62, 13);
            this.lblBookKeywordAdd.TabIndex = 12;
            this.lblBookKeywordAdd.Text = "Keyword(s):";
            this.lblBookKeywordAdd.Visible = false;
            // 
            // txtBookTitleAdd
            // 
            this.txtBookTitleAdd.Location = new System.Drawing.Point(131, 314);
            this.txtBookTitleAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBookTitleAdd.Name = "txtBookTitleAdd";
            this.txtBookTitleAdd.Size = new System.Drawing.Size(256, 20);
            this.txtBookTitleAdd.TabIndex = 13;
            this.txtBookTitleAdd.Visible = false;
            // 
            // txtBookAuthorAdd
            // 
            this.txtBookAuthorAdd.Location = new System.Drawing.Point(131, 348);
            this.txtBookAuthorAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBookAuthorAdd.Name = "txtBookAuthorAdd";
            this.txtBookAuthorAdd.Size = new System.Drawing.Size(256, 20);
            this.txtBookAuthorAdd.TabIndex = 14;
            this.txtBookAuthorAdd.Visible = false;
            // 
            // txtBookKeywordAdd
            // 
            this.txtBookKeywordAdd.Location = new System.Drawing.Point(130, 380);
            this.txtBookKeywordAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBookKeywordAdd.Name = "txtBookKeywordAdd";
            this.txtBookKeywordAdd.Size = new System.Drawing.Size(256, 20);
            this.txtBookKeywordAdd.TabIndex = 15;
            this.txtBookKeywordAdd.Visible = false;
            // 
            // btnSearchOK
            // 
            this.btnSearchOK.BackColor = System.Drawing.Color.Lime;
            this.btnSearchOK.Location = new System.Drawing.Point(410, 250);
            this.btnSearchOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchOK.Name = "btnSearchOK";
            this.btnSearchOK.Size = new System.Drawing.Size(48, 27);
            this.btnSearchOK.TabIndex = 16;
            this.btnSearchOK.Text = "OK";
            this.btnSearchOK.UseVisualStyleBackColor = false;
            this.btnSearchOK.Visible = false;
            this.btnSearchOK.Click += new System.EventHandler(this.btnSearchOK_Click);
            // 
            // btnSearchCancel
            // 
            this.btnSearchCancel.BackColor = System.Drawing.Color.Red;
            this.btnSearchCancel.Location = new System.Drawing.Point(474, 250);
            this.btnSearchCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchCancel.Name = "btnSearchCancel";
            this.btnSearchCancel.Size = new System.Drawing.Size(48, 27);
            this.btnSearchCancel.TabIndex = 17;
            this.btnSearchCancel.Text = "Cancel";
            this.btnSearchCancel.UseVisualStyleBackColor = false;
            this.btnSearchCancel.Visible = false;
            this.btnSearchCancel.Click += new System.EventHandler(this.btnSearchCancel_Click);
            // 
            // btnAddOK
            // 
            this.btnAddOK.BackColor = System.Drawing.Color.Lime;
            this.btnAddOK.Location = new System.Drawing.Point(410, 414);
            this.btnAddOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddOK.Name = "btnAddOK";
            this.btnAddOK.Size = new System.Drawing.Size(48, 27);
            this.btnAddOK.TabIndex = 18;
            this.btnAddOK.Text = "OK";
            this.btnAddOK.UseVisualStyleBackColor = false;
            this.btnAddOK.Visible = false;
            this.btnAddOK.Click += new System.EventHandler(this.btnAddOK_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.BackColor = System.Drawing.Color.Red;
            this.btnAddCancel.Location = new System.Drawing.Point(474, 414);
            this.btnAddCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(48, 27);
            this.btnAddCancel.TabIndex = 19;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Visible = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(426, 446);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 36);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 483);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddCancel);
            this.Controls.Add(this.btnAddOK);
            this.Controls.Add(this.btnSearchCancel);
            this.Controls.Add(this.btnSearchOK);
            this.Controls.Add(this.txtBookKeywordAdd);
            this.Controls.Add(this.txtBookAuthorAdd);
            this.Controls.Add(this.txtBookTitleAdd);
            this.Controls.Add(this.lblBookKeywordAdd);
            this.Controls.Add(this.lblBookAuthorAdd);
            this.Controls.Add(this.lblBookTitleAdd);
            this.Controls.Add(this.lblTransTitle);
            this.Controls.Add(this.txtKeywordSearch);
            this.Controls.Add(this.lblKeywordSearch);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.lblSelectTrans);
            this.Controls.Add(this.btnNameEntry);
            this.Controls.Add(this.txtNameEntry);
            this.Controls.Add(this.lblNameEntry);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Book Forms Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNameEntry;
        private System.Windows.Forms.TextBox txtNameEntry;
        private System.Windows.Forms.Button btnNameEntry;
        private System.Windows.Forms.Label lblSelectTrans;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label lblKeywordSearch;
        private System.Windows.Forms.TextBox txtKeywordSearch;
        private System.Windows.Forms.Label lblTransTitle;
        private System.Windows.Forms.Label lblBookTitleAdd;
        private System.Windows.Forms.Label lblBookAuthorAdd;
        private System.Windows.Forms.Label lblBookKeywordAdd;
        private System.Windows.Forms.TextBox txtBookTitleAdd;
        private System.Windows.Forms.TextBox txtBookAuthorAdd;
        private System.Windows.Forms.TextBox txtBookKeywordAdd;
        private System.Windows.Forms.Button btnSearchOK;
        private System.Windows.Forms.Button btnSearchCancel;
        private System.Windows.Forms.Button btnAddOK;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnExit;
    }
}

