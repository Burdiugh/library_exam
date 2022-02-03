namespace library_exam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listClients = new System.Windows.Forms.ListBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnRemoveClient = new System.Windows.Forms.Button();
            this.listBooks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listClients
            // 
            this.listClients.FormattingEnabled = true;
            this.listClients.ItemHeight = 15;
            this.listClients.Location = new System.Drawing.Point(12, 12);
            this.listClients.Name = "listClients";
            this.listClients.Size = new System.Drawing.Size(194, 334);
            this.listClients.TabIndex = 0;
            this.listClients.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listClients_MouseDoubleClick);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(508, 12);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(86, 50);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(212, 12);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(86, 50);
            this.btnAddClient.TabIndex = 4;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(508, 68);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(86, 50);
            this.btnDeleteBook.TabIndex = 5;
            this.btnDeleteBook.Text = "Remove Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.Location = new System.Drawing.Point(212, 68);
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.Size = new System.Drawing.Size(86, 50);
            this.btnRemoveClient.TabIndex = 6;
            this.btnRemoveClient.Text = "Remove Client";
            this.btnRemoveClient.UseVisualStyleBackColor = true;
            this.btnRemoveClient.Click += new System.EventHandler(this.btnRemoveClient_Click);
            // 
            // listBooks
            // 
            this.listBooks.FormattingEnabled = true;
            this.listBooks.ItemHeight = 15;
            this.listBooks.Location = new System.Drawing.Point(308, 12);
            this.listBooks.Name = "listBooks";
            this.listBooks.Size = new System.Drawing.Size(194, 334);
            this.listBooks.TabIndex = 9;
            this.listBooks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBooks_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 410);
            this.Controls.Add(this.listBooks);
            this.Controls.Add(this.btnRemoveClient);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.listClients);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listClients;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnRemoveClient;
        private System.Windows.Forms.ListBox listBooks;
    }
}
