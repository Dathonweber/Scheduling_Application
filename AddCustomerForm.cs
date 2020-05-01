using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BOP1_Scheduling_Application
{
    public partial class AddCustomerForm : Form
    {

        public AddCustomerForm()
        {
            InitializeComponent();
            CustomerIDTxtBox.Text = Convert.ToString(SQL.CustomerIDList.Count + 1);
            CustomerNameTxtBox.BackColor = Color.Salmon;
            AddressTxtBox.BackColor = Color.Salmon;
            ZipCodeTxtBox.BackColor = Color.Salmon;
            PhoneNumberTxtBox.BackColor = Color.Salmon;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
               
        }
        private Boolean CustomerCorrectInfo()
        {
            string ZipcodeFormat = @"^\d{5}(?:[-\s]\d{4})?$";
            Regex ZipCode = new Regex(ZipcodeFormat);
            string phoneFormat = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
            Regex phone = new Regex(phoneFormat);
            if (string.IsNullOrWhiteSpace(CustomerNameTxtBox.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(CustomerIDTxtBox.Text))
            {
                return false;
            }
            else if (string.IsNullOrWhiteSpace(AddressTxtBox.Text))
            {
                return false;
            }
            else if (YesCheckBox.Checked == false && NoCheckBox.Checked == false)
            {
                return false;
            }
            else if (ZipCode.IsMatch(ZipCodeTxtBox.Text) == false)
            {
                return false;
            }
            else if (phone.IsMatch(PhoneNumberTxtBox.Text) == false)
            {
                return false;
            }
            return true;
        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            if (CustomerCorrectInfo() == false)
            {
                MessageBox.Show("There was a problem trying to Add this customer into the system please try again","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CustomerID = Convert.ToInt32(CustomerIDTxtBox.Text);
                    string CustomerName = CustomerNameTxtBox.Text;
                    int AddressID = SQL.AddressIDList.Count + 1;
                    bool Active;
                    DateTime CreateDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Local);
                    string Test = "test";
                    string CreatedBy = Test;
                    DateTime LastUpdate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Local);
                    string LastUpdatedBy = Test;
                    string Address = AddressTxtBox.Text;
                    string ZipCode = ZipCodeTxtBox.Text;
                    string PhoneNumber = PhoneNumberTxtBox.Text;
                    if (YesCheckBox.Checked == true)
                    {
                        Active = true;
                    }
                    else
                    {
                        Active = false;
                    }
                    SQL sql = new SQL();
                    sql.AddCustomer(new Customer(CustomerID, CustomerName, AddressID, Active, CreateDate, CreatedBy, LastUpdate, LastUpdatedBy, Address, ZipCode, PhoneNumber));
                    MainForm mf = new MainForm();
                    mf.Show();
                    this.Hide();
                }
                catch (FormatException f)
                {
                    MessageBox.Show(f.Message);
                }
            }

        }

        private void CustomerNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CustomerNameTxtBox.Text))
            {
                CustomerNameTxtBox.BackColor = Color.Salmon;
             
            }
            else
            {
                
                CustomerNameTxtBox.BackColor = Color.White;
            }
        }

        private void AddressTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddressTxtBox.Text))
            {
                AddressTxtBox.BackColor = Color.Salmon;
               
            }
            else
            {
                
                AddressTxtBox.BackColor = Color.White;
            }
        }

        private void ZipCodeTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ZipCodeTxtBox.Text))
            {
                ZipCodeTxtBox.BackColor = Color.Salmon;
              
            }
            else
            {
                
                ZipCodeTxtBox.BackColor = Color.White;
            }
        }

        private void PhoneNumberTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PhoneNumberTxtBox.Text))
            {
                PhoneNumberTxtBox.BackColor = Color.Salmon;
                
            }
            else
            {
                PhoneNumberTxtBox.BackColor = Color.White;
            }
        }

        private void ZipCodeTxtBox_Click(object sender, EventArgs e)
        {
            ZipCodeTxtBox.Text = "";
        }

        private void PhoneNumberTxtBox_Click(object sender, EventArgs e)
        {
            PhoneNumberTxtBox.Text = "";
        }
    }
}
