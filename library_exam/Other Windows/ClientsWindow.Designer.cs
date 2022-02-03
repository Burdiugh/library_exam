namespace library_exam.Other_Windows
{
    partial class ClientsWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.numericMoney = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value of money";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(13, 95);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(240, 31);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(64, 18);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(189, 23);
            this.tbName.TabIndex = 3;
            // 
            // numericMoney
            // 
            this.numericMoney.Location = new System.Drawing.Point(118, 62);
            this.numericMoney.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericMoney.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMoney.Name = "numericMoney";
            this.numericMoney.Size = new System.Drawing.Size(135, 23);
            this.numericMoney.TabIndex = 4;
            this.numericMoney.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ClientsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 138);
            this.Controls.Add(this.numericMoney);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientsWindow";
            this.Text = "ClientsWindow";
            ((System.ComponentModel.ISupportInitialize)(this.numericMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.NumericUpDown numericMoney;
    }
}