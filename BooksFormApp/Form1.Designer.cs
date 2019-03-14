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
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(400, 58);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(239, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Books Form Application";
            // 
            // lblNameEntry
            // 
            this.lblNameEntry.AutoSize = true;
            this.lblNameEntry.Location = new System.Drawing.Point(230, 137);
            this.lblNameEntry.Name = "lblNameEntry";
            this.lblNameEntry.Size = new System.Drawing.Size(176, 25);
            this.lblNameEntry.TabIndex = 1;
            this.lblNameEntry.Text = "Enter your name:";
            // 
            // txtNameEntry
            // 
            this.txtNameEntry.Location = new System.Drawing.Point(412, 134);
            this.txtNameEntry.Name = "txtNameEntry";
            this.txtNameEntry.Size = new System.Drawing.Size(227, 31);
            this.txtNameEntry.TabIndex = 2;
            // 
            // btnNameEntry
            // 
            this.btnNameEntry.Location = new System.Drawing.Point(663, 113);
            this.btnNameEntry.Name = "btnNameEntry";
            this.btnNameEntry.Size = new System.Drawing.Size(107, 72);
            this.btnNameEntry.TabIndex = 3;
            this.btnNameEntry.Text = "Submit";
            this.btnNameEntry.UseVisualStyleBackColor = true;
            this.btnNameEntry.Click += new System.EventHandler(this.btnNameEntry_Click);
            // 
            // lblSelectTrans
            // 
            this.lblSelectTrans.AutoSize = true;
            this.lblSelectTrans.Location = new System.Drawing.Point(136, 239);
            this.lblSelectTrans.Name = "lblSelectTrans";
            this.lblSelectTrans.Size = new System.Drawing.Size(197, 25);
            this.lblSelectTrans.TabIndex = 4;
            this.lblSelectTrans.Text = "Select Transaction:";
            this.lblSelectTrans.Visible = false;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(347, 280);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(423, 45);
            this.btnSearchBook.TabIndex = 5;
            this.btnSearchBook.Text = "Search for a Book";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Visible = false;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(347, 353);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(423, 45);
            this.btnAddBook.TabIndex = 6;
            this.btnAddBook.Text = "Add a Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Visible = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lblKeywordSearch
            // 
            this.lblKeywordSearch.AutoSize = true;
            this.lblKeywordSearch.Location = new System.Drawing.Point(142, 494);
            this.lblKeywordSearch.Name = "lblKeywordSearch";
            this.lblKeywordSearch.Size = new System.Drawing.Size(132, 25);
            this.lblKeywordSearch.TabIndex = 7;
            this.lblKeywordSearch.Text = "Keyword(s): ";
            this.lblKeywordSearch.Visible = false;
            // 
            // txtKeywordSearch
            // 
            this.txtKeywordSearch.Location = new System.Drawing.Point(280, 491);
            this.txtKeywordSearch.Name = "txtKeywordSearch";
            this.txtKeywordSearch.Size = new System.Drawing.Size(490, 31);
            this.txtKeywordSearch.TabIndex = 8;
            this.txtKeywordSearch.Visible = false;
            // 
            // lblTransTitle
            // 
            this.lblTransTitle.AutoSize = true;
            this.lblTransTitle.Location = new System.Drawing.Point(424, 435);
            this.lblTransTitle.Name = "lblTransTitle";
            this.lblTransTitle.Size = new System.Drawing.Size(215, 25);
            this.lblTransTitle.TabIndex = 9;
            this.lblTransTitle.Text = "The Transaction Title";
            this.lblTransTitle.Visible = false;
            // 
            // lblBookTitleAdd
            // 
            this.lblBookTitleAdd.AutoSize = true;
            this.lblBookTitleAdd.Location = new System.Drawing.Point(141, 607);
            this.lblBookTitleAdd.Name = "lblBookTitleAdd";
            this.lblBookTitleAdd.Size = new System.Drawing.Size(114, 25);
            this.lblBookTitleAdd.TabIndex = 10;
            this.lblBookTitleAdd.Text = "Book Title:";
            this.lblBookTitleAdd.Visible = false;
            // 
            // lblBookAuthorAdd
            // 
            this.lblBookAuthorAdd.AutoSize = true;
            this.lblBookAuthorAdd.Location = new System.Drawing.Point(119, 672);
            this.lblBookAuthorAdd.Name = "lblBookAuthorAdd";
            this.lblBookAuthorAdd.Size = new System.Drawing.Size(136, 25);
            this.lblBookAuthorAdd.TabIndex = 11;
            this.lblBookAuthorAdd.Text = "Book Author:";
            this.lblBookAuthorAdd.Visible = false;
            // 
            // lblBookKeywordAdd
            // 
            this.lblBookKeywordAdd.AutoSize = true;
            this.lblBookKeywordAdd.Location = new System.Drawing.Point(129, 733);
            this.lblBookKeywordAdd.Name = "lblBookKeywordAdd";
            this.lblBookKeywordAdd.Size = new System.Drawing.Size(126, 25);
            this.lblBookKeywordAdd.TabIndex = 12;
            this.lblBookKeywordAdd.Text = "Keyword(s):";
            this.lblBookKeywordAdd.Visible = false;
            // 
            // txtBookTitleAdd
            // 
            this.txtBookTitleAdd.Location = new System.Drawing.Point(262, 604);
            this.txtBookTitleAdd.Name = "txtBookTitleAdd";
            this.txtBookTitleAdd.Size = new System.Drawing.Size(508, 31);
            this.txtBookTitleAdd.TabIndex = 13;
            this.txtBookTitleAdd.Visible = false;
            // 
            // txtBookAuthorAdd
            // 
            this.txtBookAuthorAdd.Location = new System.Drawing.Point(262, 669);
            this.txtBookAuthorAdd.Name = "txtBookAuthorAdd";
            this.txtBookAuthorAdd.Size = new System.Drawing.Size(508, 31);
            this.txtBookAuthorAdd.TabIndex = 14;
            this.txtBookAuthorAdd.Visible = false;
            // 
            // txtBookKeywordAdd
            // 
            this.txtBookKeywordAdd.Location = new System.Drawing.Point(261, 730);
            this.txtBookKeywordAdd.Name = "txtBookKeywordAdd";
            this.txtBookKeywordAdd.Size = new System.Drawing.Size(508, 31);
            this.txtBookKeywordAdd.TabIndex = 15;
            this.txtBookKeywordAdd.Visible = false;
            // 
            // btnSearchOK
            // 
            this.btnSearchOK.BackColor = System.Drawing.Color.Lime;
            this.btnSearchOK.Location = new System.Drawing.Point(821, 480);
            this.btnSearchOK.Name = "btnSearchOK";
            this.btnSearchOK.Size = new System.Drawing.Size(96, 52);
            this.btnSearchOK.TabIndex = 16;
            this.btnSearchOK.Text = "OK";
            this.btnSearchOK.UseVisualStyleBackColor = false;
            this.btnSearchOK.Visible = false;
            // 
            // btnSearchCancel
            // 
            this.btnSearchCancel.BackColor = System.Drawing.Color.Red;
            this.btnSearchCancel.Location = new System.Drawing.Point(948, 480);
            this.btnSearchCancel.Name = "btnSearchCancel";
            this.btnSearchCancel.Size = new System.Drawing.Size(96, 52);
            this.btnSearchCancel.TabIndex = 17;
            this.btnSearchCancel.Text = "Cancel";
            this.btnSearchCancel.UseVisualStyleBackColor = false;
            this.btnSearchCancel.Visible = false;
            this.btnSearchCancel.Click += new System.EventHandler(this.btnSearchCancel_Click);
            // 
            // btnAddOK
            // 
            this.btnAddOK.BackColor = System.Drawing.Color.Lime;
            this.btnAddOK.Location = new System.Drawing.Point(821, 796);
            this.btnAddOK.Name = "btnAddOK";
            this.btnAddOK.Size = new System.Drawing.Size(96, 52);
            this.btnAddOK.TabIndex = 18;
            this.btnAddOK.Text = "OK";
            this.btnAddOK.UseVisualStyleBackColor = false;
            this.btnAddOK.Visible = false;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.BackColor = System.Drawing.Color.Red;
            this.btnAddCancel.Location = new System.Drawing.Point(948, 796);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(96, 52);
            this.btnAddCancel.TabIndex = 19;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Visible = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 929);
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
    }
}

