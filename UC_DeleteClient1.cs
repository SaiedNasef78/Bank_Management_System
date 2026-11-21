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
    public partial class UC_DeleteClient1 : UserControl,ICloasableUserControl
    {

        public event Action CloseRequested;
        public UC_DeleteClient1()
        {
            InitializeComponent();
            uC_CloseButton1.CloseRequested += () =>
            {

                CloseRequested?.Invoke();
            };

        }


        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textAccountNumber.Text))
            {
                MessageBox.Show("Please Enter an Account Number", "", MessageBoxButtons.OK);
                return;

            }
            clsClients Client = clsClients.FindClientByAccountNumber(textAccountNumber.Text);
            if (Client != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this client", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (clsClients.DeleteClient(Client._ClientID))

                    {
                        MessageBox.Show("Deleted Client Successfully");
                        return;
                    }

                }
                return;
            }
            else
            {
                MessageBox.Show("No Client was found with the provided account number");
                return;
            }



        }

        private void UC_DeleteClient1_Load(object sender, EventArgs e)
        {

        }

        private void textAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
