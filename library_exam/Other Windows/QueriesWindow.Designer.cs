namespace library_exam.Other_Windows
{
    partial class QueriesWindow
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
            this.listView = new System.Windows.Forms.ListBox();
            this.btnGetNewestBooks = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.comboGenres = new System.Windows.Forms.ComboBox();
            this.btnOverprice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.FormattingEnabled = true;
            this.listView.ItemHeight = 15;
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(189, 349);
            this.listView.TabIndex = 0;
            // 
            // btnGetNewestBooks
            // 
            this.btnGetNewestBooks.Location = new System.Drawing.Point(207, 12);
            this.btnGetNewestBooks.Name = "btnGetNewestBooks";
            this.btnGetNewestBooks.Size = new System.Drawing.Size(99, 53);
            this.btnGetNewestBooks.TabIndex = 1;
            this.btnGetNewestBooks.Text = "Get published Books after";
            this.btnGetNewestBooks.UseVisualStyleBackColor = true;
            this.btnGetNewestBooks.Click += new System.EventHandler(this.btnGetNewestBooks_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(312, 25);
            this.datePicker.MaxDate = new System.DateTime(2022, 2, 3, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(241, 23);
            this.datePicker.TabIndex = 2;
            this.datePicker.Value = new System.DateTime(2022, 2, 3, 0, 0, 0, 0);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(207, 89);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(99, 53);
            this.btnDiscount.TabIndex = 3;
            this.btnDiscount.Text = "Set Discount 10% to";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // comboGenres
            // 
            this.comboGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGenres.FormattingEnabled = true;
            this.comboGenres.Location = new System.Drawing.Point(432, 105);
            this.comboGenres.Name = "comboGenres";
            this.comboGenres.Size = new System.Drawing.Size(121, 23);
            this.comboGenres.TabIndex = 4;
            // 
            // btnOverprice
            // 
            this.btnOverprice.Location = new System.Drawing.Point(312, 89);
            this.btnOverprice.Name = "btnOverprice";
            this.btnOverprice.Size = new System.Drawing.Size(99, 53);
            this.btnOverprice.TabIndex = 5;
            this.btnOverprice.Text = "Set overprice on 10% to";
            this.btnOverprice.UseVisualStyleBackColor = true;
            this.btnOverprice.Click += new System.EventHandler(this.btnOverprice_Click);
            // 
            // QueriesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 374);
            this.Controls.Add(this.btnOverprice);
            this.Controls.Add(this.comboGenres);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.btnGetNewestBooks);
            this.Controls.Add(this.listView);
            this.Name = "QueriesWindow";
            this.Text = "QueriesWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listView;
        private System.Windows.Forms.Button btnGetNewestBooks;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.ComboBox comboGenres;
        private System.Windows.Forms.Button btnOverprice;
    }
}