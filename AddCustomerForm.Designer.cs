namespace BOP1_Scheduling_Application
{
    partial class AddCustomerForm
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
            this.AddCustomerBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.CustomerIDTxtBox = new System.Windows.Forms.TextBox();
            this.CustomerNameTxtBox = new System.Windows.Forms.TextBox();
            this.AddressTxtBox = new System.Windows.Forms.TextBox();
            this.CustomerIdlbl = new System.Windows.Forms.Label();
            this.CustomerNameLbl = new System.Windows.Forms.Label();
            this.AddressIDLBL = new System.Windows.Forms.Label();
            this.activelbl = new System.Windows.Forms.Label();
            this.YesCheckBox = new System.Windows.Forms.CheckBox();
            this.NoCheckBox = new System.Windows.Forms.CheckBox();
            this.ZipCodeTxtBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddCustomerBtn
            // 
            this.AddCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomerBtn.Location = new System.Drawing.Point(233, 328);
            this.AddCustomerBtn.Name = "AddCustomerBtn";
            this.AddCustomerBtn.Size = new System.Drawing.Size(83, 33);
            this.AddCustomerBtn.TabIndex = 7;
            this.AddCustomerBtn.Text = "Add";
            this.AddCustomerBtn.UseVisualStyleBackColor = true;
            this.AddCustomerBtn.Click += new System.EventHandler(this.AddCustomerBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(322, 328);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(83, 33);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CustomerIDTxtBox
            // 
            this.CustomerIDTxtBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.CustomerIDTxtBox.Location = new System.Drawing.Point(129, 45);
            this.CustomerIDTxtBox.Name = "CustomerIDTxtBox";
            this.CustomerIDTxtBox.Size = new System.Drawing.Size(151, 20);
            this.CustomerIDTxtBox.TabIndex = 0;
            // 
            // CustomerNameTxtBox
            // 
            this.CustomerNameTxtBox.Location = new System.Drawing.Point(129, 89);
            this.CustomerNameTxtBox.Name = "CustomerNameTxtBox";
            this.CustomerNameTxtBox.Size = new System.Drawing.Size(151, 20);
            this.CustomerNameTxtBox.TabIndex = 1;
            this.CustomerNameTxtBox.TextChanged += new System.EventHandler(this.CustomerNameTxtBox_TextChanged);
            // 
            // AddressTxtBox
            // 
            this.AddressTxtBox.Location = new System.Drawing.Point(129, 133);
            this.AddressTxtBox.Name = "AddressTxtBox";
            this.AddressTxtBox.Size = new System.Drawing.Size(151, 20);
            this.AddressTxtBox.TabIndex = 2;
            this.AddressTxtBox.TextChanged += new System.EventHandler(this.AddressTxtBox_TextChanged);
            // 
            // CustomerIdlbl
            // 
            this.CustomerIdlbl.AutoSize = true;
            this.CustomerIdlbl.Location = new System.Drawing.Point(58, 48);
            this.CustomerIdlbl.Name = "CustomerIdlbl";
            this.CustomerIdlbl.Size = new System.Drawing.Size(65, 13);
            this.CustomerIdlbl.TabIndex = 3;
            this.CustomerIdlbl.Text = "Customer ID";
            // 
            // CustomerNameLbl
            // 
            this.CustomerNameLbl.AutoSize = true;
            this.CustomerNameLbl.Location = new System.Drawing.Point(41, 91);
            this.CustomerNameLbl.Name = "CustomerNameLbl";
            this.CustomerNameLbl.Size = new System.Drawing.Size(82, 13);
            this.CustomerNameLbl.TabIndex = 3;
            this.CustomerNameLbl.Text = "Customer Name";
            // 
            // AddressIDLBL
            // 
            this.AddressIDLBL.AutoSize = true;
            this.AddressIDLBL.Location = new System.Drawing.Point(78, 136);
            this.AddressIDLBL.Name = "AddressIDLBL";
            this.AddressIDLBL.Size = new System.Drawing.Size(45, 13);
            this.AddressIDLBL.TabIndex = 3;
            this.AddressIDLBL.Text = "Address";
            // 
            // activelbl
            // 
            this.activelbl.AutoSize = true;
            this.activelbl.Location = new System.Drawing.Point(86, 177);
            this.activelbl.Name = "activelbl";
            this.activelbl.Size = new System.Drawing.Size(37, 13);
            this.activelbl.TabIndex = 3;
            this.activelbl.Text = "Active";
            // 
            // YesCheckBox
            // 
            this.YesCheckBox.AutoSize = true;
            this.YesCheckBox.Location = new System.Drawing.Point(129, 177);
            this.YesCheckBox.Name = "YesCheckBox";
            this.YesCheckBox.Size = new System.Drawing.Size(44, 17);
            this.YesCheckBox.TabIndex = 3;
            this.YesCheckBox.Text = "Yes";
            this.YesCheckBox.UseVisualStyleBackColor = true;
            // 
            // NoCheckBox
            // 
            this.NoCheckBox.AutoSize = true;
            this.NoCheckBox.Location = new System.Drawing.Point(200, 177);
            this.NoCheckBox.Name = "NoCheckBox";
            this.NoCheckBox.Size = new System.Drawing.Size(40, 17);
            this.NoCheckBox.TabIndex = 4;
            this.NoCheckBox.Text = "No";
            this.NoCheckBox.UseVisualStyleBackColor = true;
            // 
            // ZipCodeTxtBox
            // 
            this.ZipCodeTxtBox.Location = new System.Drawing.Point(129, 218);
            this.ZipCodeTxtBox.Name = "ZipCodeTxtBox";
            this.ZipCodeTxtBox.Size = new System.Drawing.Size(85, 20);
            this.ZipCodeTxtBox.TabIndex = 5;
            this.ZipCodeTxtBox.Text = "_ _ _ _ _ ";
            this.ZipCodeTxtBox.Click += new System.EventHandler(this.ZipCodeTxtBox_Click);
            this.ZipCodeTxtBox.TextChanged += new System.EventHandler(this.ZipCodeTxtBox_TextChanged);
            // 
            // PhoneNumberTxtBox
            // 
            this.PhoneNumberTxtBox.Location = new System.Drawing.Point(129, 262);
            this.PhoneNumberTxtBox.Name = "PhoneNumberTxtBox";
            this.PhoneNumberTxtBox.Size = new System.Drawing.Size(151, 20);
            this.PhoneNumberTxtBox.TabIndex = 6;
            this.PhoneNumberTxtBox.Text = "_ _ _ - _ _ _ - _ _ _ _ ";
            this.PhoneNumberTxtBox.Click += new System.EventHandler(this.PhoneNumberTxtBox_Click);
            this.PhoneNumberTxtBox.TextChanged += new System.EventHandler(this.PhoneNumberTxtBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zipcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone Number";
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 369);
            this.Controls.Add(this.NoCheckBox);
            this.Controls.Add(this.YesCheckBox);
            this.Controls.Add(this.activelbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddressIDLBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerNameLbl);
            this.Controls.Add(this.CustomerIdlbl);
            this.Controls.Add(this.PhoneNumberTxtBox);
            this.Controls.Add(this.ZipCodeTxtBox);
            this.Controls.Add(this.AddressTxtBox);
            this.Controls.Add(this.CustomerNameTxtBox);
            this.Controls.Add(this.CustomerIDTxtBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.AddCustomerBtn);
            this.Name = "AddCustomerForm";
            this.Text = "AddCustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCustomerBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox CustomerIDTxtBox;
        private System.Windows.Forms.TextBox CustomerNameTxtBox;
        private System.Windows.Forms.TextBox AddressTxtBox;
        private System.Windows.Forms.Label CustomerIdlbl;
        private System.Windows.Forms.Label CustomerNameLbl;
        private System.Windows.Forms.Label AddressIDLBL;
        private System.Windows.Forms.Label activelbl;
        private System.Windows.Forms.CheckBox YesCheckBox;
        private System.Windows.Forms.CheckBox NoCheckBox;
        private System.Windows.Forms.TextBox ZipCodeTxtBox;
        private System.Windows.Forms.TextBox PhoneNumberTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}