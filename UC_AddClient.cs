using Bank_BuisnessLayer;
using Guna.UI2.WinForms;
using Project_Bank_System_Level2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Bank_System_Level2
{
    public partial class UC_AddClient : UC_BaseClient
    {
        public UC_AddClient()
        {
            InitializeComponent();
            LblClientTitle.Text = "Add New Client";
            PB_Image.Image = Resources._IconAdd;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void UC_AddClient_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void LblAccountNumber_Click(object sender, EventArgs e)
        {

        }
        //private void ClearTextBoxes()
        //{
        //    textAccountNumber.Clear();
        //    textBalance.Clear();
        //    textEmail.Clear();
        //    textFirstName.Clear();
        //    textLastName.Clear();
        //    textPinCode.Clear();
        //    textPhone.Clear();

        //}



        private void AddNewClient()
        {
            clsClients Client = clsClients.FindClientByAccountNumber(textAccountNumber.Text);
            if (Client != null)
            {
                MessageBox.Show("Client Already Exists", "", MessageBoxButtons.OKCancel);
                return;
            }
            else
            {

                SaveClient(Client, "Added");

            }


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            AddNewClient();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
