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
    public partial class UC_Home : UserControl
    {
        public UC_Home(clsUsers _CurrentUser)
        {
            InitializeComponent();

            CurrentUser = _CurrentUser;
            LBLUserName.Text = CurrentUser.UserName;
            SetPermissionsCheckBoxes();
        }
        clsUsers CurrentUser;

        protected void SetPermissionsCheckBoxes()
        {

            if (CurrentUser.Permissions == -1)
            {
                CB_All.Checked = true;
                return;
            }

            if ((CurrentUser.Permissions & (int)clsUsers.enPermissions.pAddNewClient) != 0)
            {
                CB_AddClient.Checked = true;

            }
            if ((CurrentUser.Permissions & (int)clsUsers.enPermissions.pCurrencyExhange) != 0)

            {
                CB_CurrecyExhange.Checked = true;
            }
            if ((CurrentUser.Permissions & (int)clsUsers.enPermissions.pDeleteClient) != 0)
            {
                CB_DeleteClient.Checked = true;
            }
            if ((CurrentUser.Permissions & (int)clsUsers.enPermissions.pFindClient) != 0)
            {
                CB_FindClient.Checked = true;
            }
            if ((CurrentUser.Permissions & (int)clsUsers.enPermissions.pManageUsers) != 0)
            {
                CB_UsersManagement.Checked = true;


            }
            if ((CurrentUser.Permissions & (int)clsUsers.enPermissions.pLoginRegistos) != 0)
            {

                CB_LoginRegistor.Checked = true;
            }

            if ((CurrentUser.Permissions & (int)clsUsers.enPermissions.pShowClientList) != 0)
            {
                CB_ClientLst.Checked = true;
            }

            if ((CurrentUser.Permissions & (int)clsUsers.enPermissions.pUpdateClient) != 0)
            {
                CB_UpdateClient.Checked = true;
            }
            if ((CurrentUser.Permissions & (int)clsUsers.enPermissions.pTransActions) != 0)
            {
                CB_Transactions.Checked = true;
            }


        }


        private void CheckedComboBoxes(bool Check, params Guna2CheckBox[] checkBoxes)
        {

            foreach (Guna2CheckBox checkBox in checkBoxes)
            {
                checkBox.Checked = Check;

            }


        }
        private void UC_Home_Load(object sender, EventArgs e)
        {

        }

        private void CB_All_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CB_All.Checked)
            {

                CheckedComboBoxes(true, CB_ClientLst, CB_DeleteClient, CB_FindClient, CB_LoginRegistor, CB_CurrecyExhange,
                    CB_UsersManagement, CB_Transactions, CB_UpdateClient, CB_AddClient);
            }
        }

        private void GB_Permissons_Enter(object sender, EventArgs e)
        {

        }
    }
}
