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
    public partial class UC_BaseUsers : UserControl,ICloasableUserControl
    {
        
        public UC_BaseUsers()
        {
            InitializeComponent();

            uC_CloseButton1.CloseRequested += () =>
            {

                CloseRequested?.Invoke();
            };
        }


        
        public event Action CloseRequested;
        protected void ClearTextBoxes(params Guna2TextBox[] textBoxes)
        {


            foreach (Guna2TextBox textBox in textBoxes)
            {
                textBox.Clear();
            }
        }

        protected clsUsers User;
        protected bool SerchForUser(Guna2TextBox text)
        {

            if (clsUsers.ISUserNameExist(text.Text))
            {
                MessageBox.Show("User is found");
                text.Clear();
                text.Focus();

                return true;
            }
            else
            {
                return false;
            }



        }
        protected clsUsers.enPermissions SetPermissions(params Guna2CheckBox[] CheckBoxes)
        {
            clsUsers.enPermissions Permission = 0;
            foreach (Guna2CheckBox checkBox in CheckBoxes)
            {
                if (checkBox.Checked)
                {
                    if (int.TryParse(checkBox.Tag.ToString(), out int TagValue))
                    {
                        Permission |= (clsUsers.enPermissions)TagValue;
                    }

                }
            }


            return Permission;
        }
        protected void CheckedComboBoxes(bool Check, params Guna2CheckBox[] checkBoxes)
        {

            foreach (Guna2CheckBox checkBox in checkBoxes)
            {
                checkBox.Checked = Check;

            }

        }
        protected bool IsComboBoxChecked(params Guna2CheckBox[] checkBoxes)
        {
            foreach (Guna2CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                    return true;

            }
            MessageBox.Show("Please Select a Perrmissions", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;


        }
        protected bool ChecktextBoxNullOrEmpty(params Guna2TextBox[] textBoxes)
        {
            foreach (Guna2TextBox textBox in textBoxes)
            {

                if (string.IsNullOrEmpty(textBox.Text))
                {
                    MessageBox.Show($"Please Enter {textBox.Tag}");
                    return false;
                }



            }
            return true;
        }

        protected void ResetForm()
        {
            User = null;

            ClearTextBoxes(textUserName, textFirstName, textLastName, textPassword, textEnail, textPhone);
            textUserName.Focus();
            CheckedComboBoxes(false, CB_All, CB_ClientList, CB_DeleteClient, CB_FindClient, CB_LoginRegistor, CB_CurrencyExhange,
                     CB_ManageUsers, CB_TransactiosClient, CB_UpdateClient, CB_TransactiosClient, CB_AddClient);

            CB_Country.SelectedIndex = -1;


        }
        private void UC_BaseUsers_Load(object sender, EventArgs e)
        {

        }

        protected bool SaveUserData()
        {

            if (!ChecktextBoxNullOrEmpty(textUserName, textEnail, textFirstName, textLastName, textPassword, textPhone))
                return false;

          

            if (!IsComboBoxChecked(CB_All, CB_AddClient, CB_ClientList, CB_CurrencyExhange,
                CB_DeleteClient, CB_FindClient, CB_LoginRegistor, CB_ManageUsers, CB_TransactiosClient, CB_UpdateClient))
                return false;


          
            User.UserName = textUserName.Text;
            User._FirstName = textFirstName.Text;
            User._LastName = textLastName.Text;

            if (CB_Country.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a country", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }

            User.Country = CB_Country.SelectedItem.ToString();


            User.Password = textPassword.Text;
            User._Email = textEnail.Text;
            User._Phone = textPhone.Text;

            if (CB_All.Checked)
            {
                User.Permissions = (int)clsUsers.enPermissions.pAll;
            }
            else
            {
                User.Permissions = (int)SetPermissions(CB_AddClient, CB_ClientList, CB_CurrencyExhange, CB_DeleteClient, CB_FindClient, CB_LoginRegistor, CB_ManageUsers, CB_TransactiosClient, CB_UpdateClient);
            }
            return User.Save();
          




        }
        protected void SetPermissionsCheckBoxes()
        {

            if (User.Permissions == -1)
            {
                CB_All.Checked = true;
                return;
            }

            if ((User.Permissions & (int)clsUsers.enPermissions.pAddNewClient) != 0)
            {
                CB_AddClient.Checked = true;

            }
            if ((User.Permissions & (int)clsUsers.enPermissions.pCurrencyExhange) != 0)

            {
                CB_CurrencyExhange.Checked = true;
            }
            if ((User.Permissions & (int)clsUsers.enPermissions.pDeleteClient) != 0)
            {
                CB_DeleteClient.Checked = true;
            }
            if ((User.Permissions & (int)clsUsers.enPermissions.pFindClient) != 0)
            {
                CB_FindClient.Checked = true;
            }
            if ((User.Permissions & (int)clsUsers.enPermissions.pManageUsers) != 0)
            {
                CB_ManageUsers.Checked = true;


            }
            if ((User.Permissions & (int)clsUsers.enPermissions.pLoginRegistos) != 0)
            {

                CB_LoginRegistor.Checked = true;
            }

            if ((User.Permissions & (int)clsUsers.enPermissions.pShowClientList) != 0)
            {
                CB_ClientList.Checked = true;
            }

            if ((User.Permissions & (int)clsUsers.enPermissions.pUpdateClient) != 0)
            {
                CB_UpdateClient.Checked = true;
            }
            if ((User.Permissions & (int)clsUsers.enPermissions.pTransActions) != 0)
            {
                CB_TransactiosClient.Checked = true;
            }


        }
        private void CB_All_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_All.Checked)
            {

                CheckedComboBoxes(true, CB_ClientList, CB_DeleteClient, CB_FindClient, CB_LoginRegistor, CB_CurrencyExhange,
                    CB_ManageUsers, CB_TransactiosClient, CB_UpdateClient, CB_TransactiosClient, CB_AddClient);
            }
            else
            {
                CheckedComboBoxes(false, CB_ClientList, CB_DeleteClient, CB_FindClient, CB_LoginRegistor, CB_CurrencyExhange,
                   CB_ManageUsers, CB_TransactiosClient, CB_UpdateClient, CB_TransactiosClient, CB_AddClient);
            }
        }

        private void GB_Permissions_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
