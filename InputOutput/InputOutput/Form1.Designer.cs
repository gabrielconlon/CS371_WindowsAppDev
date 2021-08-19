namespace InputOutput
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.open_BTN = new System.Windows.Forms.Button();
            this.write_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(801, 332);
            this.textBox1.TabIndex = 0;
            // 
            // open_BTN
            // 
            this.open_BTN.Location = new System.Drawing.Point(115, 350);
            this.open_BTN.Name = "open_BTN";
            this.open_BTN.Size = new System.Drawing.Size(143, 27);
            this.open_BTN.TabIndex = 1;
            this.open_BTN.Text = "In the beginning...";
            this.open_BTN.UseVisualStyleBackColor = true;
            this.open_BTN.Click += new System.EventHandler(this.open_BTN_Click);
            // 
            // write_BTN
            // 
            this.write_BTN.Location = new System.Drawing.Point(86, 393);
            this.write_BTN.Name = "write_BTN";
            this.write_BTN.Size = new System.Drawing.Size(197, 30);
            this.write_BTN.TabIndex = 2;
            this.write_BTN.Text = "Alas, all good things must come to an end...";
            this.write_BTN.UseVisualStyleBackColor = true;
            this.write_BTN.Click += new System.EventHandler(this.write_BTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 600);
            this.Controls.Add(this.write_BTN);
            this.Controls.Add(this.open_BTN);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button open_BTN;
        private System.Windows.Forms.Button write_BTN;
    }
}

