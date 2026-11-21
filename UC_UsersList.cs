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
    public partial class UC_UsersList : UserControl,ICloasableUserControl
    {
        public event Action CloseRequested;
        public UC_UsersList()

        {
            InitializeComponent();
            DGV_UsersList.AutoGenerateColumns = true;
            DGV_UsersList.DataSource = clsUsers.GetAllUsers();

            uC_CloseButton1.CloseRequested += () =>
            {

                CloseRequested?.Invoke();
            };
        }

        private void UC_UsersList_Load(object sender, EventArgs e)
        {

        }

        private void uC_CloseButton1_Load(object sender, EventArgs e)
        {

        }
    }
}
