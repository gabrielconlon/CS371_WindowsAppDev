namespace EX5_2
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
            this.drawingCanvas = new System.Windows.Forms.Panel();
            this.colorBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorChoice = new System.Windows.Forms.ComboBox();
            this.sizeBox = new System.Windows.Forms.GroupBox();
            this.sizeChoice = new System.Windows.Forms.ComboBox();
            this.clear_BTN = new System.Windows.Forms.Button();
            this.undo_BTN = new System.Windows.Forms.Button();
            this.colorBox.SuspendLayout();
            this.sizeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingCanvas
            // 
            this.drawingCanvas.BackColor = System.Drawing.Color.White;
            this.drawingCanvas.Location = new System.Drawing.Point(215, -1);
            this.drawingCanvas.Name = "drawingCanvas";
            this.drawingCanvas.Size = new System.Drawing.Size(384, 497);
            this.drawingCanvas.TabIndex = 0;
            this.drawingCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingCanvas_MouseDown);
            this.drawingCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingCanvas_MouseMove);
            this.drawingCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingCanvas_MouseUp);
            // 
            // colorBox
            // 
            this.colorBox.Controls.Add(this.label1);
            this.colorBox.Controls.Add(this.colorChoice);
            this.colorBox.Location = new System.Drawing.Point(5, 5);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(199, 77);
            this.colorBox.TabIndex = 1;
            this.colorBox.TabStop = false;
            this.colorBox.Text = "Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Holding the right mouse button \r\nwill erase";
            // 
            // colorChoice
            // 
            this.colorChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorChoice.FormattingEnabled = true;
            this.colorChoice.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Indigo",
            "Violet"});
            this.colorChoice.Location = new System.Drawing.Point(10, 19);
            this.colorChoice.Name = "colorChoice";
            this.colorChoice.Size = new System.Drawing.Size(121, 21);
            this.colorChoice.TabIndex = 1;
            // 
            // sizeBox
            // 
            this.sizeBox.Controls.Add(this.sizeChoice);
            this.sizeBox.Location = new System.Drawing.Point(5, 88);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(195, 62);
            this.sizeBox.TabIndex = 2;
            this.sizeBox.TabStop = false;
            this.sizeBox.Text = "Size";
            // 
            // sizeChoice
            // 
            this.sizeChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeChoice.FormattingEnabled = true;
            this.sizeChoice.Items.AddRange(new object[] {
            "4pt",
            "8pt",
            "16pt",
            "32pt"});
            this.sizeChoice.Location = new System.Drawing.Point(10, 20);
            this.sizeChoice.Name = "sizeChoice";
            this.sizeChoice.Size = new System.Drawing.Size(121, 21);
            this.sizeChoice.TabIndex = 0;
            // 
            // clear_BTN
            // 
            this.clear_BTN.Location = new System.Drawing.Point(63, 426);
            this.clear_BTN.Name = "clear_BTN";
            this.clear_BTN.Size = new System.Drawing.Size(75, 23);
            this.clear_BTN.TabIndex = 3;
            this.clear_BTN.Text = "Clear";
            this.clear_BTN.UseVisualStyleBackColor = true;
            this.clear_BTN.Click += new System.EventHandler(this.clear_BTN_Click);
            // 
            // undo_BTN
            // 
            this.undo_BTN.Location = new System.Drawing.Point(63, 397);
            this.undo_BTN.Name = "undo_BTN";
            this.undo_BTN.Size = new System.Drawing.Size(75, 23);
            this.undo_BTN.TabIndex = 4;
            this.undo_BTN.Text = "Undo";
            this.undo_BTN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(596, 490);
            this.Controls.Add(this.undo_BTN);
            this.Controls.Add(this.clear_BTN);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.drawingCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.colorBox.ResumeLayout(false);
            this.colorBox.PerformLayout();
            this.sizeBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawingCanvas;
        private System.Windows.Forms.GroupBox colorBox;
        private System.Windows.Forms.GroupBox sizeBox;
        private System.Windows.Forms.Button clear_BTN;
        private System.Windows.Forms.ComboBox colorChoice;
        private System.Windows.Forms.ComboBox sizeChoice;
        private System.Windows.Forms.Button undo_BTN;
        private System.Windows.Forms.Label label1;
    }
}

