using Bank_BuisnessLayer;
using Guna.UI2.WinForms;
using Project_Bank_System_Level2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Bank_System_Level2
{
    public partial class UC_UpdateClient : UC_BaseClient
    {
        public UC_UpdateClient()
        {
            InitializeComponent();
            LblClientTitle.Text = "Update Client";
            PB_Image.Image = Resources.icons8_user_update_96;
            SetTextBoxesEnable(false, textBalance, textEmail, textFirstName, textLastName, textPhone, textPinCode);
            GBGender.Enabled = false;
            SetbtnSvaAndResetEnable(false);
        }

        private void SetbtnSvaAndResetEnable(bool IsEnable)
        {
            btnSave.Enabled = IsEnable;
            btnReset.Enabled = IsEnable;
        }
        private void SetTextBoxesEnable(bool IsEnable, params Guna2TextBox[] textBoxes)
        {
            foreach (Guna2TextBox textBox in textBoxes)
            {

                textBox.Enabled = IsEnable;
            }

        }

        private clsClients Client;
        private void SerchForAccountNumber()
        {

            if (string.IsNullOrEmpty(textAccountNumber.Text))
            {
                MessageBox.Show("Please Enter Account Number");
                textAccountNumber.Focus();
                return;
            }
            Client = clsClients.FindClientByAccountNumber(textAccountNumber.Text.Trim());
            if (Client != null)
            {

                SetTextBoxesEnable(true, textBalance, textEmail, textFirstName, textLastName, textPhone, textPinCode);
                GBGender.Enabled = true;

                textBalance.Text = Convert.ToString(Client._AccountBalance);
                textEmail.Text = Client._Email;
                textFirstName.Text = Client._FirstName;
                textLastName.Text = Client._LastName;
                textPhone.Text = Client._Phone;
                textPinCode.Text = Client._PinCode;

                if (Client._Gender == "Female")
                    RB_Female.Checked = true;
                else
                    RB_Male.Checked = true;

                SetbtnSvaAndResetEnable(true);

                return;
            }

            else
            {
                MessageBox.Show("Client is not found ", "", MessageBoxButtons.OKCancel);
                return;
            }

        }





        private void btnSerch_Click(object sender, EventArgs e)
        {
            SerchForAccountNumber();
        }

        private void UC_UpdateClient_Load(object sender, EventArgs e)
        {

        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!SaveClient(Client, "Updated"))
                return;

                SetTextBoxesEnable(false, textBalance, textEmail, textFirstName, textLastName, textPhone, textPinCode);
                GBGender.Enabled = false;
           

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
            SetTextBoxesEnable(false, textBalance, textEmail, textFirstName, textLastName, textPhone, textPinCode);
            GBGender.Enabled = false;
            SetbtnSvaAndResetEnable(false);
        }

        private void textPinCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
