namespace AirlineReservation
{
    partial class ReservationDisplay
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
            this.flightComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.seat1 = new System.Windows.Forms.PictureBox();
            this.seat2 = new System.Windows.Forms.PictureBox();
            this.seat3 = new System.Windows.Forms.PictureBox();
            this.seat4 = new System.Windows.Forms.PictureBox();
            this.seat5 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.seat6 = new System.Windows.Forms.PictureBox();
            this.seat7 = new System.Windows.Forms.PictureBox();
            this.seat10 = new System.Windows.Forms.PictureBox();
            this.seat8 = new System.Windows.Forms.PictureBox();
            this.seat9 = new System.Windows.Forms.PictureBox();
            this.displayTextBox = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.firstRadioButton = new System.Windows.Forms.RadioButton();
            this.economyRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seat3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seat4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seat5)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seat6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seat7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seat10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seat8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seat9)).BeginInit();
            this.SuspendLayout();
            // 
            // flightComboBox
            // 
            this.flightComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flightComboBox.FormattingEnabled = true;
            this.flightComboBox.Items.AddRange(new object[] {
            "E123",
            "E234",
            "E567"});
            this.flightComboBox.Location = new System.Drawing.Point(15, 25);
            this.flightComboBox.Name = "flightComboBox";
            this.flightComboBox.Size = new System.Drawing.Size(159, 21);
            this.flightComboBox.TabIndex = 0;
            this.flightComboBox.SelectedIndexChanged += new System.EventHandler(this.flightComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Flight Number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.seat1);
            this.groupBox1.Controls.Add(this.seat2);
            this.groupBox1.Controls.Add(this.seat3);
            this.groupBox1.Controls.Add(this.seat4);
            this.groupBox1.Controls.Add(this.seat5);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 82);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "First Class";
            // 
            // seat1
            // 
            this.seat1.Image = global::AirlineReservation.Properties.Resources.seat;
            this.seat1.Location = new System.Drawing.Point(6, 19);
            this.seat1.Name = "seat1";
            this.seat1.Size = new System.Drawing.Size(29, 25);
            this.seat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seat1.TabIndex = 2;
            this.seat1.TabStop = false;
            // 
            // seat2
            // 
            this.seat2.Image = global::AirlineReservation.Properties.Resources.seat;
            this.seat2.Location = new System.Drawing.Point(6, 50);
            this.seat2.Name = "seat2";
            this.seat2.Size = new System.Drawing.Size(29, 25);
            this.seat2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seat2.TabIndex = 3;
            this.seat2.TabStop = false;
            // 
            // seat3
            // 
            this.seat3.Image = global::AirlineReservation.Properties.Resources.seat;
            this.seat3.Location = new System.Drawing.Point(41, 19);
            this.seat3.Name = "seat3";
            this.seat3.Size = new System.Drawing.Size(29, 25);
            this.seat3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seat3.TabIndex = 4;
            this.seat3.TabStop = false;
            // 
            // seat4
            // 
            this.seat4.Image = global::AirlineReservation.Properties.Resources.seat;
            this.seat4.Location = new System.Drawing.Point(41, 50);
            this.seat4.Name = "seat4";
            this.seat4.Size = new System.Drawing.Size(29, 25);
            this.seat4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seat4.TabIndex = 5;
            this.seat4.TabStop = false;
            // 
            // seat5
            // 
            this.seat5.Image = global::AirlineReservation.Properties.Resources.seat;
            this.seat5.Location = new System.Drawing.Point(76, 19);
            this.seat5.Name = "seat5";
            this.seat5.Size = new System.Drawing.Size(29, 25);
            this.seat5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seat5.TabIndex = 6;
            this.seat5.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.seat6);
            this.groupBox2.Controls.Add(this.seat7);
            this.groupBox2.Controls.Add(this.seat10);
            this.groupBox2.Controls.Add(this.seat8);
            this.groupBox2.Controls.Add(this.seat9);
            this.groupBox2.Location = new System.Drawing.Point(142, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 82);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Economy";
            // 
            // seat6
            // 
            this.seat6.Image = global::AirlineReservation.Properties.Resources.seat;
            this.seat6.Location = new System.Drawing.Point(6, 19);
            this.seat6.Name = "seat6";
            this.seat6.Size = new System.Drawing.Size(29, 25);
            this.seat6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seat6.TabIndex = 7;
            this.seat6.TabStop = false;
            // 
            // seat7
            // 
            this.seat7.Image = global::AirlineReservation.Properties.Resources.seat;
            this.seat7.Location = new System.Drawing.Point(6, 50);
            this.seat7.Name = "seat7";
            this.seat7.Size = new System.Drawing.Size(29, 25);
            this.seat7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seat7.TabIndex = 8;
            this.seat7.TabStop = false;
            // 
            // seat10
            // 
            this.seat10.Image = global::AirlineReservation.Properties.Resources.seat;
            this.seat10.Location = new System.Drawing.Point(76, 19);
            this.seat10.Name = "seat10";
            this.seat10.Size = new System.Drawing.Size(29, 25);
            this.seat10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seat10.TabIndex = 10;
            this.seat10.TabStop = false;
            // 
            // seat8
            // 
            this.seat8.Image = global::AirlineReservation.Properties.Resources.seat;
            this.seat8.Location = new System.Drawing.Point(41, 19);
            this.seat8.Name = "seat8";
            this.seat8.Size = new System.Drawing.Size(29, 25);
            this.seat8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seat8.TabIndex = 11;
            this.seat8.TabStop = false;
            // 
            // seat9
            // 
            this.seat9.Image = global::AirlineReservation.Properties.Resources.seat;
            this.seat9.Location = new System.Drawing.Point(41, 51);
            this.seat9.Name = "seat9";
            this.seat9.Size = new System.Drawing.Size(29, 25);
            this.seat9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seat9.TabIndex = 9;
            this.seat9.TabStop = false;
            // 
            // displayTextBox
            // 
            this.displayTextBox.AutoSize = true;
            this.displayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTextBox.Location = new System.Drawing.Point(61, 166);
            this.displayTextBox.MinimumSize = new System.Drawing.Size(200, 2);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(200, 15);
            this.displayTextBox.TabIndex = 14;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(42, 199);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 15;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(148, 199);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Message:";
            // 
            // firstRadioButton
            // 
            this.firstRadioButton.AutoSize = true;
            this.firstRadioButton.Checked = true;
            this.firstRadioButton.Location = new System.Drawing.Point(198, 17);
            this.firstRadioButton.Name = "firstRadioButton";
            this.firstRadioButton.Size = new System.Drawing.Size(72, 17);
            this.firstRadioButton.TabIndex = 18;
            this.firstRadioButton.TabStop = true;
            this.firstRadioButton.Text = "First Class";
            this.firstRadioButton.UseVisualStyleBackColor = true;
            this.firstRadioButton.CheckedChanged += new System.EventHandler(this.firstRadioButton_CheckedChanged);
            // 
            // economyRadioButton
            // 
            this.economyRadioButton.AutoSize = true;
            this.economyRadioButton.Location = new System.Drawing.Point(198, 40);
            this.economyRadioButton.Name = "economyRadioButton";
            this.economyRadioButton.Size = new System.Drawing.Size(69, 17);
            this.economyRadioButton.TabIndex = 19;
            this.economyRadioButton.Text = "Economy";
            this.economyRadioButton.UseVisualStyleBackColor = true;
            this.economyRadioButton.CheckedChanged += new System.EventHandler(this.economyRadioButton_CheckedChanged);
            // 
            // ReservationDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 234);
            this.Controls.Add(this.economyRadioButton);
            this.Controls.Add(this.firstRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flightComboBox);
            this.Name = "ReservationDisplay";
            this.Text = "Reservation Display";
            this.Load += new System.EventHandler(this.ReservationDisplay_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seat3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seat4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seat5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seat6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seat7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seat10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seat8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seat9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox flightComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox seat1;
        private System.Windows.Forms.PictureBox seat2;
        private System.Windows.Forms.PictureBox seat3;
        private System.Windows.Forms.PictureBox seat4;
        private System.Windows.Forms.PictureBox seat5;
        private System.Windows.Forms.PictureBox seat6;
        private System.Windows.Forms.PictureBox seat7;
        private System.Windows.Forms.PictureBox seat9;
        private System.Windows.Forms.PictureBox seat10;
        private System.Windows.Forms.PictureBox seat8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label displayTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton firstRadioButton;
        private System.Windows.Forms.RadioButton economyRadioButton;
    }
}

