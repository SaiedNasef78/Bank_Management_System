using Bank_BuisnessLayer;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Bank_System_Level2
{
    public partial class UC_AddNewUser : UC_BaseUsers
    {
        public UC_AddNewUser()
        {
            InitializeComponent();
            textUserName.Focus();
        }

        private void UC_AddNewUser_Load(object sender, EventArgs e)
        {

        }


        private void textSave_Click(object sender, EventArgs e)
        {
            if (SerchForUser(textUserName))
                return;

            User = new clsUsers();
          if ( SaveUserData())
            {
                MessageBox.Show("User Added Successfully");
                ResetForm();
               
            }
            else
            {
                MessageBox.Show("User Added Failed");
              
               
            }




        }

        private void CB_All_CheckedChanged(object sender, EventArgs e)
        {
         
        }
      
        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetForm();

        }

        protected void LblAddNewUser_Click(object sender, EventArgs e)
        {

        }

    

        private void CB_All_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
