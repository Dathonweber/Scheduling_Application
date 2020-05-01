namespace BOP1_Scheduling_Application
{
    partial class AddAppointmentForm
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
            this.CustomerIDTxtBox = new System.Windows.Forms.TextBox();
            this.TypeTxtBox = new System.Windows.Forms.TextBox();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddAppointmentButton = new System.Windows.Forms.Button();
            this.CustIDLbl = new System.Windows.Forms.Label();
            this.TypeLbl = new System.Windows.Forms.Label();
            this.strtdatelbl = new System.Windows.Forms.Label();
            this.AppointmentIDTxtBox = new System.Windows.Forms.TextBox();
            this.AppointmentIDLabel = new System.Windows.Forms.Label();
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerIDTxtBox
            // 
            this.CustomerIDTxtBox.Location = new System.Drawing.Point(123, 89);
            this.CustomerIDTxtBox.Name = "CustomerIDTxtBox";
            this.CustomerIDTxtBox.Size = new System.Drawing.Size(158, 20);
            this.CustomerIDTxtBox.TabIndex = 0;
            // 
            // TypeTxtBox
            // 
            this.TypeTxtBox.Location = new System.Drawing.Point(123, 132);
            this.TypeTxtBox.Name = "TypeTxtBox";
            this.TypeTxtBox.Size = new System.Drawing.Size(158, 20);
            this.TypeTxtBox.TabIndex = 1;
            // 
            // StartDate
            // 
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartDate.Location = new System.Drawing.Point(123, 172);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(158, 20);
            this.StartDate.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(289, 304);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(91, 34);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddAppointmentButton
            // 
            this.AddAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAppointmentButton.Location = new System.Drawing.Point(176, 304);
            this.AddAppointmentButton.Name = "AddAppointmentButton";
            this.AddAppointmentButton.Size = new System.Drawing.Size(91, 34);
            this.AddAppointmentButton.TabIndex = 4;
            this.AddAppointmentButton.Text = "Add";
            this.AddAppointmentButton.UseVisualStyleBackColor = true;
            this.AddAppointmentButton.Click += new System.EventHandler(this.AddAppointmentButton_Click);
            // 
            // CustIDLbl
            // 
            this.CustIDLbl.AutoSize = true;
            this.CustIDLbl.Location = new System.Drawing.Point(54, 92);
            this.CustIDLbl.Name = "CustIDLbl";
            this.CustIDLbl.Size = new System.Drawing.Size(62, 13);
            this.CustIDLbl.TabIndex = 4;
            this.CustIDLbl.Text = "CustomerID";
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Location = new System.Drawing.Point(23, 135);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(93, 13);
            this.TypeLbl.TabIndex = 6;
            this.TypeLbl.Text = "Appointment Type";
            // 
            // strtdatelbl
            // 
            this.strtdatelbl.AutoSize = true;
            this.strtdatelbl.Location = new System.Drawing.Point(11, 178);
            this.strtdatelbl.Name = "strtdatelbl";
            this.strtdatelbl.Size = new System.Drawing.Size(105, 13);
            this.strtdatelbl.TabIndex = 7;
            this.strtdatelbl.Text = "Appt. Time and Date";
            // 
            // AppointmentIDTxtBox
            // 
            this.AppointmentIDTxtBox.Enabled = false;
            this.AppointmentIDTxtBox.Location = new System.Drawing.Point(123, 46);
            this.AppointmentIDTxtBox.Name = "AppointmentIDTxtBox";
            this.AppointmentIDTxtBox.Size = new System.Drawing.Size(158, 20);
            this.AppointmentIDTxtBox.TabIndex = 0;
            // 
            // AppointmentIDLabel
            // 
            this.AppointmentIDLabel.AutoSize = true;
            this.AppointmentIDLabel.Location = new System.Drawing.Point(36, 49);
            this.AppointmentIDLabel.Name = "AppointmentIDLabel";
            this.AppointmentIDLabel.Size = new System.Drawing.Size(80, 13);
            this.AppointmentIDLabel.TabIndex = 4;
            this.AppointmentIDLabel.Text = "Appointment ID";
            // 
            // EndTime
            // 
            this.EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTime.Location = new System.Drawing.Point(123, 218);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(158, 20);
            this.EndTime.TabIndex = 3;
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Location = new System.Drawing.Point(64, 221);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(52, 13);
            this.EndTimeLabel.TabIndex = 8;
            this.EndTimeLabel.Text = "End Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Case Sensitive";
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndTimeLabel);
            this.Controls.Add(this.strtdatelbl);
            this.Controls.Add(this.TypeLbl);
            this.Controls.Add(this.AppointmentIDLabel);
            this.Controls.Add(this.CustIDLbl);
            this.Controls.Add(this.AddAppointmentButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.TypeTxtBox);
            this.Controls.Add(this.AppointmentIDTxtBox);
            this.Controls.Add(this.CustomerIDTxtBox);
            this.Name = "AddAppointmentForm";
            this.Text = "AddAppointmentForm";
            this.Load += new System.EventHandler(this.AddAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AddAppointmentButton;
        private System.Windows.Forms.Label CustIDLbl;
        private System.Windows.Forms.Label TypeLbl;
        private System.Windows.Forms.Label strtdatelbl;
        private System.Windows.Forms.Label AppointmentIDLabel;
        public System.Windows.Forms.TextBox CustomerIDTxtBox;
        public System.Windows.Forms.TextBox TypeTxtBox;
        public System.Windows.Forms.DateTimePicker StartDate;
        public System.Windows.Forms.TextBox AppointmentIDTxtBox;
        public System.Windows.Forms.DateTimePicker EndTime;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.Label label1;
    }
}