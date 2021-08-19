namespace CompoundInterest
{
    partial class CompoundInterest
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
            this.components = new System.ComponentModel.Container();
            this.principle_tb = new System.Windows.Forms.TextBox();
            this.interest_tb = new System.Windows.Forms.TextBox();
            this.display_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.years_updown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.drawComboBox = new System.Windows.Forms.ComboBox();
            this.helpfultooltip = new System.Windows.Forms.ToolTip(this.components);
            this.tab_controller = new System.Windows.Forms.TabControl();
            this.colorTab = new System.Windows.Forms.TabPage();
            this.blue_RBTN = new System.Windows.Forms.RadioButton();
            this.red_RBTN = new System.Windows.Forms.RadioButton();
            this.sizeTab = new System.Windows.Forms.TabPage();
            this.size14_RBTN = new System.Windows.Forms.RadioButton();
            this.sizenince_RBTN = new System.Windows.Forms.RadioButton();
            this.changer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.years_updown)).BeginInit();
            this.tab_controller.SuspendLayout();
            this.colorTab.SuspendLayout();
            this.sizeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // principle_tb
            // 
            this.principle_tb.AcceptsReturn = true;
            this.principle_tb.Location = new System.Drawing.Point(74, 41);
            this.principle_tb.Name = "principle_tb";
            this.principle_tb.Size = new System.Drawing.Size(100, 20);
            this.principle_tb.TabIndex = 0;
            // 
            // interest_tb
            // 
            this.interest_tb.AcceptsReturn = true;
            this.interest_tb.Location = new System.Drawing.Point(74, 67);
            this.interest_tb.Name = "interest_tb";
            this.interest_tb.Size = new System.Drawing.Size(100, 20);
            this.interest_tb.TabIndex = 1;
            // 
            // display_tb
            // 
            this.display_tb.Location = new System.Drawing.Point(74, 179);
            this.display_tb.Multiline = true;
            this.display_tb.Name = "display_tb";
            this.display_tb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.display_tb.Size = new System.Drawing.Size(255, 102);
            this.display_tb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Principle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Interest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = " Yearly Amounts";
            // 
            // years_updown
            // 
            this.years_updown.Location = new System.Drawing.Point(228, 108);
            this.years_updown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.years_updown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.years_updown.Name = "years_updown";
            this.years_updown.Size = new System.Drawing.Size(113, 20);
            this.years_updown.TabIndex = 2;
            this.years_updown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Tag = " ";
            this.label4.Text = "Years";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(154, 299);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 3;
            this.btn_calc.Text = "calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // drawingPanel
            // 
            this.drawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drawingPanel.Location = new System.Drawing.Point(547, 12);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(348, 269);
            this.drawingPanel.TabIndex = 8;
            this.helpfultooltip.SetToolTip(this.drawingPanel, "This panel shows the shapes");
            // 
            // drawComboBox
            // 
            this.drawComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drawComboBox.FormattingEnabled = true;
            this.drawComboBox.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Filled Circle"});
            this.drawComboBox.Location = new System.Drawing.Point(614, 299);
            this.drawComboBox.Name = "drawComboBox";
            this.drawComboBox.Size = new System.Drawing.Size(217, 21);
            this.drawComboBox.TabIndex = 9;
            this.helpfultooltip.SetToolTip(this.drawComboBox, "This is a drop down box...");
            this.drawComboBox.SelectedIndexChanged += new System.EventHandler(this.drawComboBox_SelectedIndexChanged);
            // 
            // helpfultooltip
            // 
            this.helpfultooltip.ToolTipTitle = "My Tool Tip";
            // 
            // tab_controller
            // 
            this.tab_controller.Controls.Add(this.colorTab);
            this.tab_controller.Controls.Add(this.sizeTab);
            this.tab_controller.Location = new System.Drawing.Point(347, 1);
            this.tab_controller.Name = "tab_controller";
            this.tab_controller.SelectedIndex = 0;
            this.tab_controller.Size = new System.Drawing.Size(200, 127);
            this.tab_controller.TabIndex = 10;
            // 
            // colorTab
            // 
            this.colorTab.Controls.Add(this.blue_RBTN);
            this.colorTab.Controls.Add(this.red_RBTN);
            this.colorTab.Location = new System.Drawing.Point(4, 22);
            this.colorTab.Name = "colorTab";
            this.colorTab.Padding = new System.Windows.Forms.Padding(3);
            this.colorTab.Size = new System.Drawing.Size(192, 101);
            this.colorTab.TabIndex = 0;
            this.colorTab.Text = "Color";
            this.colorTab.UseVisualStyleBackColor = true;
            // 
            // blue_RBTN
            // 
            this.blue_RBTN.AutoSize = true;
            this.blue_RBTN.Location = new System.Drawing.Point(7, 44);
            this.blue_RBTN.Name = "blue_RBTN";
            this.blue_RBTN.Size = new System.Drawing.Size(46, 17);
            this.blue_RBTN.TabIndex = 1;
            this.blue_RBTN.TabStop = true;
            this.blue_RBTN.Text = "Blue";
            this.blue_RBTN.UseVisualStyleBackColor = true;
            this.blue_RBTN.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // red_RBTN
            // 
            this.red_RBTN.AutoSize = true;
            this.red_RBTN.Location = new System.Drawing.Point(7, 20);
            this.red_RBTN.Name = "red_RBTN";
            this.red_RBTN.Size = new System.Drawing.Size(45, 17);
            this.red_RBTN.TabIndex = 0;
            this.red_RBTN.TabStop = true;
            this.red_RBTN.Text = "Red";
            this.red_RBTN.UseVisualStyleBackColor = true;
            this.red_RBTN.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // sizeTab
            // 
            this.sizeTab.Controls.Add(this.size14_RBTN);
            this.sizeTab.Controls.Add(this.sizenince_RBTN);
            this.sizeTab.Location = new System.Drawing.Point(4, 22);
            this.sizeTab.Name = "sizeTab";
            this.sizeTab.Padding = new System.Windows.Forms.Padding(3);
            this.sizeTab.Size = new System.Drawing.Size(192, 101);
            this.sizeTab.TabIndex = 1;
            this.sizeTab.Text = "Size";
            this.sizeTab.UseVisualStyleBackColor = true;
            // 
            // size14_RBTN
            // 
            this.size14_RBTN.AutoSize = true;
            this.size14_RBTN.Location = new System.Drawing.Point(7, 36);
            this.size14_RBTN.Name = "size14_RBTN";
            this.size14_RBTN.Size = new System.Drawing.Size(58, 17);
            this.size14_RBTN.TabIndex = 1;
            this.size14_RBTN.TabStop = true;
            this.size14_RBTN.Text = "size 12";
            this.size14_RBTN.UseVisualStyleBackColor = true;
            this.size14_RBTN.CheckedChanged += new System.EventHandler(this.size14_RBTN_CheckedChanged);
            // 
            // sizenince_RBTN
            // 
            this.sizenince_RBTN.AutoSize = true;
            this.sizenince_RBTN.Location = new System.Drawing.Point(7, 13);
            this.sizenince_RBTN.Name = "sizenince_RBTN";
            this.sizenince_RBTN.Size = new System.Drawing.Size(52, 17);
            this.sizenince_RBTN.TabIndex = 0;
            this.sizenince_RBTN.TabStop = true;
            this.sizenince_RBTN.Text = "size 9";
            this.sizenince_RBTN.UseVisualStyleBackColor = true;
            this.sizenince_RBTN.CheckedChanged += new System.EventHandler(this.sizenince_RBTN_CheckedChanged);
            // 
            // changer
            // 
            this.changer.AutoSize = true;
            this.changer.Location = new System.Drawing.Point(357, 222);
            this.changer.Name = "changer";
            this.changer.Size = new System.Drawing.Size(96, 13);
            this.changer.TabIndex = 11;
            this.changer.Text = "Watch me Change";
            // 
            // CompoundInterest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 334);
            this.Controls.Add(this.changer);
            this.Controls.Add(this.tab_controller);
            this.Controls.Add(this.drawComboBox);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.years_updown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.display_tb);
            this.Controls.Add(this.interest_tb);
            this.Controls.Add(this.principle_tb);
            this.Name = "CompoundInterest";
            this.Text = "Compound Interest";
            ((System.ComponentModel.ISupportInitialize)(this.years_updown)).EndInit();
            this.tab_controller.ResumeLayout(false);
            this.colorTab.ResumeLayout(false);
            this.colorTab.PerformLayout();
            this.sizeTab.ResumeLayout(false);
            this.sizeTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox principle_tb;
        private System.Windows.Forms.TextBox interest_tb;
        private System.Windows.Forms.TextBox display_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown years_updown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.ComboBox drawComboBox;
        private System.Windows.Forms.ToolTip helpfultooltip;
        private System.Windows.Forms.TabControl tab_controller;
        private System.Windows.Forms.TabPage colorTab;
        private System.Windows.Forms.RadioButton blue_RBTN;
        private System.Windows.Forms.RadioButton red_RBTN;
        private System.Windows.Forms.TabPage sizeTab;
        private System.Windows.Forms.RadioButton size14_RBTN;
        private System.Windows.Forms.RadioButton sizenince_RBTN;
        private System.Windows.Forms.Label changer;
    }
}

