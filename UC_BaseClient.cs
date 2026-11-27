using Bank_BuisnessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Bank_System_Level2
{
    public partial class UC_BaseClient : UserControl, ICloasableUserControl
    {

        public event Action CloseRequested;
        public UC_BaseClient()
        {
            InitializeComponent();
            uC_CloseButton1.CloseRequested += () =>
            {

                CloseRequested?.Invoke();
            };
        }

        private void UC_BaseClient_Load(object sender, EventArgs e)
        {

        }
        protected void ClearTextBoxes(params Guna2TextBox[] textBoxes)
        {
            foreach (Guna2TextBox textBox in textBoxes)
            {

                textBox.Clear();
            }

        }

        protected bool CheckEmptyTextBoxes(params Guna2TextBox[] textBoxes)
        {
            foreach (Guna2TextBox text in textBoxes)
            {
                if (string.IsNullOrEmpty(text.Text))
                {
                    MessageBox.Show($"Please Enter{text.Tag}", "", MessageBoxButtons.OKCancel);
                    text.Focus();
                    return false;
                }




            }

            return true;
        }

        private bool GetSelectedGender(clsClients Client)
        {

            if (!RB_Female.Checked && !RB_Male.Checked)
            {
                MessageBox.Show("Please Choose the Gender ");

                return false;
            }
            if (RB_Female.Checked)
            {
                Client._Gender = "Female";
            }
            else
            {
                Client._Gender = "Male";
            }

            return true;

        }

        protected bool SaveClient(clsClients Client, string Message)
        {

            if (!CheckEmptyTextBoxes(textFirstName, textLastName, textAccountNumber, textBalance, textEmail, textPhone, textPinCode))
            {
                return false;
            }
            Client = new clsClients();
            Client._FirstName = textFirstName.Text;
            Client._LastName = textLastName.Text;
            Client._Email = textEmail.Text;
            Client._PinCode = textPinCode.Text;
            Client._Phone = textPhone.Text;
            Client._AccountNumber = textAccountNumber.Text;

            if (!GetSelectedGender(Client))
            {
                return false;
            }

            if (!double.TryParse(textBalance.Text.Trim(), out double Balance))
            {
                MessageBox.Show("Invalid Balance!", "", MessageBoxButtons.OKCancel);
                textBalance.Focus();
                return false;
            }

            Client._AccountBalance = Balance;






            if (Client.Save())
            {
                if (MessageBox.Show($"Client {Message} Successfully", "Success", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ResetForm();
                    return true;
                }
            }
            else
            {
                MessageBox.Show($"Failed to {Message} Client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;

        }

        protected void ResetForm()
        {
            ClearTextBoxes(textAccountNumber, textBalance, textEmail, textFirstName, textLastName, textPinCode, textPhone);
            if (RB_Female.Checked)
            {
                RB_Female.Checked = false;
            }
            else
            {
                RB_Male.Checked = false;
            }

        }
        private void UC_BaseClient_Load_1(object sender, EventArgs e)
        {

        }

       

        private void UC_BaseClient_Load_2(object sender, EventArgs e)
        {

        }

        private void uC_CloseButton1_Load(object sender, EventArgs e)
        {

        }
    }
}
