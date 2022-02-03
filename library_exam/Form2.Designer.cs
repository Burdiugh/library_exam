namespace library_exam
{
    partial class Form2
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
            this.listClients = new System.Windows.Forms.ListBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnRemovClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listClients
            // 
            this.listClients.FormattingEnabled = true;
            this.listClients.ItemHeight = 15;
            this.listClients.Location = new System.Drawing.Point(12, 12);
            this.listClients.Name = "listClients";
            this.listClients.Size = new System.Drawing.Size(202, 334);
            this.listClients.TabIndex = 0;
            this.listClients.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listClients_MouseDoubleClick);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(225, 12);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 151);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnRemovClient
            // 
            this.btnRemovClient.Location = new System.Drawing.Point(225, 169);
            this.btnRemovClient.Name = "btnRemovClient";
            this.btnRemovClient.Size = new System.Drawing.Size(75, 177);
            this.btnRemovClient.TabIndex = 2;
            this.btnRemovClient.Text = "Remove Client";
            this.btnRemovClient.UseVisualStyleBackColor = true;
            this.btnRemovClient.Click += new System.EventHandler(this.btnRemovClient_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 355);
            this.Controls.Add(this.btnRemovClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.listClients);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listClients;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnRemovClient;
    }
}