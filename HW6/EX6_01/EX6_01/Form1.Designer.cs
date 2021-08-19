namespace EX6_01
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
            this.Search_BTN = new System.Windows.Forms.Button();
            this.filename_TB = new System.Windows.Forms.TextBox();
            this.filename_LB = new System.Windows.Forms.Label();
            this.directory_LB = new System.Windows.Forms.Label();
            this.directory_TB = new System.Windows.Forms.TextBox();
            this.results_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Search_BTN
            // 
            this.Search_BTN.Location = new System.Drawing.Point(19, 367);
            this.Search_BTN.Name = "Search_BTN";
            this.Search_BTN.Size = new System.Drawing.Size(75, 23);
            this.Search_BTN.TabIndex = 0;
            this.Search_BTN.Text = "Search";
            this.Search_BTN.UseVisualStyleBackColor = true;
            this.Search_BTN.Click += new System.EventHandler(this.search_BTN_Click);
            // 
            // filename_TB
            // 
            this.filename_TB.Location = new System.Drawing.Point(12, 25);
            this.filename_TB.Name = "filename_TB";
            this.filename_TB.Size = new System.Drawing.Size(573, 20);
            this.filename_TB.TabIndex = 1;
            // 
            // filename_LB
            // 
            this.filename_LB.AutoSize = true;
            this.filename_LB.Location = new System.Drawing.Point(9, 9);
            this.filename_LB.Name = "filename_LB";
            this.filename_LB.Size = new System.Drawing.Size(49, 13);
            this.filename_LB.TabIndex = 2;
            this.filename_LB.Text = "Filename";
            // 
            // directory_LB
            // 
            this.directory_LB.AutoSize = true;
            this.directory_LB.Location = new System.Drawing.Point(9, 48);
            this.directory_LB.Name = "directory_LB";
            this.directory_LB.Size = new System.Drawing.Size(49, 13);
            this.directory_LB.TabIndex = 3;
            this.directory_LB.Text = "Directory";
            // 
            // directory_TB
            // 
            this.directory_TB.Location = new System.Drawing.Point(12, 65);
            this.directory_TB.Name = "directory_TB";
            this.directory_TB.Size = new System.Drawing.Size(573, 20);
            this.directory_TB.TabIndex = 4;
            // 
            // results_TB
            // 
            this.results_TB.Location = new System.Drawing.Point(12, 104);
            this.results_TB.Multiline = true;
            this.results_TB.Name = "results_TB";
            this.results_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.results_TB.Size = new System.Drawing.Size(573, 257);
            this.results_TB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.results_TB);
            this.Controls.Add(this.directory_TB);
            this.Controls.Add(this.directory_LB);
            this.Controls.Add(this.filename_LB);
            this.Controls.Add(this.filename_TB);
            this.Controls.Add(this.Search_BTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search_BTN;
        private System.Windows.Forms.TextBox filename_TB;
        private System.Windows.Forms.Label filename_LB;
        private System.Windows.Forms.Label directory_LB;
        private System.Windows.Forms.TextBox directory_TB;
        private System.Windows.Forms.TextBox results_TB;
        private System.Windows.Forms.Label label1;
    }
}

