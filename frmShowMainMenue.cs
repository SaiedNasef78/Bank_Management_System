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
    public partial class frmShowMainMenue : Form
    {
        public frmShowMainMenue(clsUsers User1)
        {
            InitializeComponent();
            CurrentUser = User1;
            ShowHome();
           
        }


    
        private clsUsers CurrentUser;



        private bool CheckAccessRight(clsUsers.enPermissions permissions)
        {

            if (!CurrentUser.CheeckAccessPermissions(permissions))

            {
                MessageBox.Show("AccessDenide! Contact your Admin", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }
        private enum enMainMinue
        {
            ShowClient = 1, AddNewClient = 2, DelelteClient = 3
              , UpdateClient = 4, FindClient = 5, TransAction = 6,
            ManageUsers = 7, LoginRegistr = 8, CurrecyExhange = 9, Exist = 10
        };
        private enum enTransaction
        {
            Deposit = 1,
            WithDrow,
            TransferMoney,
            TransferLog
                ,
            None
        }

        private enum enManageUsers
        {
            AddUser = 1,
            UpdateUser,
            DeleteUser,
            FindUser,
            ShowUser,
            None


        }

      
        private void NavigationButton(params Guna2Button[] Buttons)
        {
          foreach(Guna2Button button in Buttons)
            {

                if (button.Checked)
                {
                   
                    button.BackColor = Color.Transparent;
                    button.Checked = false;
                    return;

                }
              

            }

        }
        

           private void ShowHome()
        {
            NavigationButton(btnAddNewClient, btnUpdateClient, btnDeleteClient, 
                btnClientsList,btnSerchForClient,btnDeposit,btnWithDraw,btnTransfer,
                btnCurrencies,btnCurrencyCalculator,btnAddUser,btnUpdateUser,btnDeleteUser
                ,btnFindUser,btnTransferLog,btnLoginRegistor,btnLogout);

            LoadUserControl(new UC_Home(CurrentUser));

        }
        private void _ShowClientList()
        {
            if (!CheckAccessRight(clsUsers.enPermissions.pShowClientList))
                return;

            LoadUserControl(new UC_ClientsList());

        }
        private void _AddNewClient()
        {
            if (!CheckAccessRight(clsUsers.enPermissions.pAddNewClient))
                return;

            LoadUserControl(new UC_AddClient());

        }

        private void _DeleteClient()
        {
            if (!CheckAccessRight(clsUsers.enPermissions.pDeleteClient))
                return;

            LoadUserControl(new UC_DeleteClient1());

        }

        private void _UpdateClient()
        {
            if (!CheckAccessRight(clsUsers.enPermissions.pUpdateClient))
                return;

            LoadUserControl(new UC_UpdateClient());
        }

        private void _FindClient()
        {
            if (!CheckAccessRight(clsUsers.enPermissions.pFindClient))
                return;
            LoadUserControl(new UC_FindClient());

        }

        private void _Transaction(enTransaction TransactionType)
        {
            if (!CheckAccessRight(clsUsers.enPermissions.pTransActions))
                return;

            switch (TransactionType)
            {
                case enTransaction.Deposit:
                    LoadUserControl(new UC_DepositAmount());
                    break;

                case enTransaction.WithDrow:
                    LoadUserControl(new UC_WithdrawlAmountcs());
                    break;

                case enTransaction.TransferLog:
                    LoadUserControl(new UC_TransferLog());
                    break;

                case enTransaction.TransferMoney:
                    LoadUserControl(new UC_TransferMony(CurrentUser.UserName));
                    break; ;

                case enTransaction.None:
                    return;
                    break;

            }



        }

        private void _ManageUsers(enManageUsers ManageUsersType)
        {
            if (!CheckAccessRight(clsUsers.enPermissions.pManageUsers))
                return;

            switch (ManageUsersType)
            {
                case enManageUsers.AddUser:
                    LoadUserControl(new UC_AddNewUser());
                    break;

                case enManageUsers.FindUser:
                    LoadUserControl(new UC_FindUser());
                    break;

                case enManageUsers.DeleteUser:
                    LoadUserControl(new UC_DeleteUser());
                    break;

                case enManageUsers.ShowUser:
                    LoadUserControl(new UC_UsersList());
                    break;

                case enManageUsers.UpdateUser:
                    LoadUserControl(new UpdateUser_UC());
                    break;


                case enManageUsers.None:
                    return;
                    break;


            }
        }

        private void _ShowLoginScreen()
        {
            if (!CheckAccessRight(clsUsers.enPermissions.pLoginRegistos))
                return;

            LoadUserControl(new UC_LoginRegistor());

        }

        private void _ShowCurrencyExhangeScreen()
        {
            if (!CheckAccessRight(clsUsers.enPermissions.pCurrencyExhange))
                return;

            LoadUserControl(new UC_CurrenciesList());
        }
        private void _PerformMainMenueOption(enMainMinue OperationMainMenue, enTransaction
            transactionType = enTransaction.None, enManageUsers ManageUserType = enManageUsers.None)

        {

            switch (OperationMainMenue)
            {


                case enMainMinue.ShowClient:
                    {

                        _ShowClientList();
                        break;
                    }
                case enMainMinue.AddNewClient:
                    {

                        _AddNewClient();

                        break;
                    }

                case enMainMinue.DelelteClient:
                    {

                        _DeleteClient();

                        break;
                    }

                case enMainMinue.UpdateClient:
                    {

                        _UpdateClient();


                        break;
                    }
                case enMainMinue.FindClient:
                    {

                        _FindClient();

                        break;
                    }
                case enMainMinue.TransAction:
                    {


                        _Transaction(transactionType);

                        break;
                    }
                case enMainMinue.ManageUsers:
                    {

                        _ManageUsers(ManageUserType);
                        break;
                    }
                case enMainMinue.LoginRegistr:
                    {

                        _ShowLoginScreen();

                        break;

                    }

                case enMainMinue.CurrecyExhange:
                    {

                        _ShowCurrencyExhangeScreen();

                        break;

                    }

                case enMainMinue.Exist:
                    {

                        return;


                        break;
                    }



            }






        }
        private void frmShowMainMenue_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            _PerformMainMenueOption(enMainMinue.AddNewClient);


        }

        private void guna2Button17_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void LayoutPanal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            _PerformMainMenueOption(enMainMinue.UpdateClient);

        }
        private void LoadUserControl(UserControl UC)
        {

            //Dispose previous screen
            while (PanelContainer.Controls.Count > 0)
            {

                PanelContainer.Controls[0].Dispose();

            }

            // Handle close request
            if(UC is ICloasableUserControl cloasable)
            {
                cloasable.CloseRequested += ShowHome;

            }

            //Display Screen
            PanelContainer.Controls.Clear();
            UC.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(UC);

        }
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            _PerformMainMenueOption(enMainMinue.DelelteClient);
        }

        private void btnClientsList_Click(object sender, EventArgs e)
        {
            _PerformMainMenueOption(enMainMinue.ShowClient);
        }

        private void btnSerchForClient_Click(object sender, EventArgs e)
        {
            _PerformMainMenueOption(enMainMinue.FindClient);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            _Transaction(enTransaction.Deposit);
        }

        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            _PerformMainMenueOption(enMainMinue.TransAction, enTransaction.WithDrow);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            _PerformMainMenueOption(enMainMinue.TransAction, enTransaction.TransferMoney);
        }

        private void btnTransferLog_Click_2(object sender, EventArgs e)
        {
            _PerformMainMenueOption(enMainMinue.TransAction, enTransaction.TransferLog);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            _PerformMainMenueOption(enMainMinue.ManageUsers, enTransaction.None, enManageUsers.AddUser);


        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            _PerformMainMenueOption(enMainMinue.ManageUsers, enTransaction.None, enManageUsers.UpdateUser);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            _PerformMainMenueOption(enMainMinue.ManageUsers, enTransaction.None, enManageUsers.DeleteUser);
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            _PerformMainMenueOption(enMainMinue.ManageUsers, enTransaction.None, enManageUsers.FindUser);
        }

        private void btnUsersList_Click(object sender, EventArgs e)
        {
            _PerformMainMenueOption(enMainMinue.ManageUsers, enTransaction.None, enManageUsers.ShowUser);
        }

        private void btnCurrencies_Click(object sender, EventArgs e)
        {
            _PerformMainMenueOption(enMainMinue.CurrecyExhange);
        }

        private void btnCurrencyCalculator_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_CurrrencyCalculator());
        }

        private void GB_Permissons_Enter(object sender, EventArgs e)
        {

        }

      

        private void CB_All_CheckedChanged(object sender, EventArgs e)
        {
          

        }

        private void btnLoginRegistor_Click(object sender, EventArgs e)
        {
            _PerformMainMenueOption(enMainMinue.LoginRegistr);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Close();
        }
    }
}
