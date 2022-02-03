namespace library_exam.Other_Windows
{
    partial class First
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnManageClient = new System.Windows.Forms.Button();
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.btnAddPurchase = new System.Windows.Forms.Button();
            this.btnQueries = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "What do you want to do?";
            // 
            // btnManageClient
            // 
            this.btnManageClient.Location = new System.Drawing.Point(12, 42);
            this.btnManageClient.Name = "btnManageClient";
            this.btnManageClient.Size = new System.Drawing.Size(171, 53);
            this.btnManageClient.TabIndex = 1;
            this.btnManageClient.Text = "Manage Clients";
            this.btnManageClient.UseVisualStyleBackColor = true;
            this.btnManageClient.Click += new System.EventHandler(this.btnManageClient_Click);
            // 
            // btnManageBooks
            // 
            this.btnManageBooks.Location = new System.Drawing.Point(189, 42);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Size = new System.Drawing.Size(171, 53);
            this.btnManageBooks.TabIndex = 2;
            this.btnManageBooks.Text = "Manage Books";
            this.btnManageBooks.UseVisualStyleBackColor = true;
            this.btnManageBooks.Click += new System.EventHandler(this.btnManageBooks_Click);
            // 
            // btnAddPurchase
            // 
            this.btnAddPurchase.Location = new System.Drawing.Point(12, 101);
            this.btnAddPurchase.Name = "btnAddPurchase";
            this.btnAddPurchase.Size = new System.Drawing.Size(171, 53);
            this.btnAddPurchase.TabIndex = 3;
            this.btnAddPurchase.Text = "Add Purchases";
            this.btnAddPurchase.UseVisualStyleBackColor = true;
            this.btnAddPurchase.Click += new System.EventHandler(this.btnAddPurchase_Click);
            // 
            // btnQueries
            // 
            this.btnQueries.Location = new System.Drawing.Point(189, 101);
            this.btnQueries.Name = "btnQueries";
            this.btnQueries.Size = new System.Drawing.Size(171, 53);
            this.btnQueries.TabIndex = 4;
            this.btnQueries.Text = "Some Queries";
            this.btnQueries.UseVisualStyleBackColor = true;
            this.btnQueries.Click += new System.EventHandler(this.btnQueries_Click);
            // 
            // First
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 164);
            this.Controls.Add(this.btnQueries);
            this.Controls.Add(this.btnAddPurchase);
            this.Controls.Add(this.btnManageBooks);
            this.Controls.Add(this.btnManageClient);
            this.Controls.Add(this.label1);
            this.Name = "First";
            this.Text = "First";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManageClient;
        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Button btnAddPurchase;
        private System.Windows.Forms.Button btnQueries;
    }
}