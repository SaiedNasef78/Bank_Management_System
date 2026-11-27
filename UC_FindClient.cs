using Bank_BuisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Bank_System_Level2
{
    public partial class UC_FindClient : UserControl,ICloasableUserControl
    {
        public event Action CloseRequested;
        public UC_FindClient()
        {
            InitializeComponent();
          uC_CloseButton1.  CloseRequested += () =>
            {
               
                CloseRequested?.Invoke();
            };
        }
       
        private void ShowClientInfo()
        {
            LblBalance.Visible = true;
            LblEmail.Visible = true;
            LblPhone.Visible = true;
            LblFirstName.Visible = true;
            LblLastName.Visible = true;
            LblPinCode.Visible = true;

            GBGender.Visible = true;
            textBalance.Visible = true;
            textEmail.Visible = true;
            textFirstName.Visible = true;
            textLastName.Visible = true;
            textPhone.Visible = true;
            textPinCode.Visible = true;
        }
        private void SerchForClient()
        {
            if (string.IsNullOrEmpty(textAccountNumer.Text))
            {
                MessageBox.Show("Please Enter Account Number");
                return;
            }
            clsClients Client = clsClients.FindClientByAccountNumber(textAccountNumer.Text);
            if (Client != null)
            {
                ShowClientInfo();
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
                return;


            }
            else
            {
                if (MessageBox.Show("Client is not found", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    textAccountNumer.Clear();
                    return;
                }
            }

        }
        private void btnSerch_Click(object sender, EventArgs e)
        {
            SerchForClient();
        }

        private void UC_FindClient_Load(object sender, EventArgs e)
        {

        }

        private void uC_CloseButton1_Load(object sender, EventArgs e)
        {

        }
    }
}
