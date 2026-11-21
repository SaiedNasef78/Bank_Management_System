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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Project_Bank_System_Level2
{
    public partial class UpdateUser_UC : UC_BaseUsers
    {
        public UpdateUser_UC()
        {
            InitializeComponent();
            textUserName.Focus();
         
            SetTextEnabled(false, textEnail, textFirstName, textLastName, textPassword, textPhone);
           
            btnsave.Enabled = false;
            btnClear.Enabled = false;
            CB_Country.Enabled = false;
            GB_Permissions.Enabled = false;
        }
        private void SetTextEnabled(bool IsEnable, params Guna2TextBox[] textboxes)
        {
            foreach (Guna2TextBox textBox in textboxes)
            {
                textBox.Enabled = IsEnable;

            }


        }
       
        private void UpdateUser_UC_Load(object sender, EventArgs e)
        {

        }
    

        private void btnSerch_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textUserName.Text))
            {
                MessageBox.Show("Please Enter UserName");
                textUserName.Clear();
                textUserName.Focus();
                return;
            }

            User = clsUsers.FindUserByUserName(textUserName.Text);
            if (User != null)
            {
                btnsave.Enabled = true;
                btnClear.Enabled = true;

                textFirstName.Text = User._FirstName;
                textLastName.Text = User._LastName;
                textEnail.Text = User._Email;
                textPassword.Text = User.Password;
                textPhone.Text = User._Phone;
                CB_Country.SelectedIndex = CB_Country.FindStringExact(User.Country);
            
                CB_Country.Enabled = true;

                SetPermissionsCheckBoxes();
                SetTextEnabled(true, textEnail, textFirstName, textLastName, textPassword, textPhone);
             
                GB_Permissions.Enabled = true;
              
            }
            else
            {
                MessageBox.Show("User not found");
                textUserName.Clear();
                textUserName.Focus();
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (SaveUserData())
            {

                MessageBox.Show("User Updated Successfully");
                ResetForm();
                CB_Country.Enabled = false;
                btnsave.Enabled = false;
                GB_Permissions.Enabled = false;
                SetTextEnabled(false, textEnail, textFirstName, textLastName, textPassword, textPhone);
                

            }
            else
            {
                MessageBox.Show("User Updated Failed");
            }

            

        }

        private void CB_All_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetForm();
            SetTextEnabled(false, textEnail, textFirstName, textLastName, textPassword, textPhone);
            CB_Country.Enabled = false;
            GB_Permissions.Enabled = false;
            btnsave.Enabled = false;

        }
    }
}
