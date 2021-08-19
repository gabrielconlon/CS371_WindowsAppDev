namespace CleanupDirectory
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
            this.Search_TB = new System.Windows.Forms.TextBox();
            this.multiline_TB = new System.Windows.Forms.TextBox();
            this.clean_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Search_TB
            // 
            this.Search_TB.Location = new System.Drawing.Point(52, 55);
            this.Search_TB.Name = "Search_TB";
            this.Search_TB.Size = new System.Drawing.Size(100, 20);
            this.Search_TB.TabIndex = 0;
            this.Search_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_TB_KeyDown);
            // 
            // multiline_TB
            // 
            this.multiline_TB.Location = new System.Drawing.Point(52, 115);
            this.multiline_TB.Multiline = true;
            this.multiline_TB.Name = "multiline_TB";
            this.multiline_TB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.multiline_TB.Size = new System.Drawing.Size(555, 298);
            this.multiline_TB.TabIndex = 1;
            this.multiline_TB.WordWrap = false;
            // 
            // clean_BTN
            // 
            this.clean_BTN.Enabled = false;
            this.clean_BTN.Location = new System.Drawing.Point(298, 55);
            this.clean_BTN.Name = "clean_BTN";
            this.clean_BTN.Size = new System.Drawing.Size(75, 23);
            this.clean_BTN.TabIndex = 2;
            this.clean_BTN.Text = "Clean";
            this.clean_BTN.UseVisualStyleBackColor = true;
            this.clean_BTN.Click += new System.EventHandler(this.clean_BTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 441);
            this.Controls.Add(this.clean_BTN);
            this.Controls.Add(this.multiline_TB);
            this.Controls.Add(this.Search_TB);
            this.Name = "Form1";
            this.Text = "CleanUp Directory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Search_TB;
        private System.Windows.Forms.TextBox multiline_TB;
        private System.Windows.Forms.Button clean_BTN;
    }
}

