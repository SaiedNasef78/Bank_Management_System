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
    public partial class UC_DeleteUser : UserControl, ICloasableUserControl
    {
        public event Action CloseRequested;
        public UC_DeleteUser()
        {
            InitializeComponent();
            uC_CloseButton1.CloseRequested += () =>
            {

                CloseRequested?.Invoke();
            };
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDelete.Text))
            {
                MessageBox.Show("Please Enter an UserName", "", MessageBoxButtons.OK);
                return;

            }
            clsUsers User = clsUsers.FindUserByUserName(textDelete.Text);
            if (User != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this User", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (clsUsers.DeleteUser(User.UserID))

                    {
                        MessageBox.Show("Deleted User Successfully");
                        textDelete.Clear();
                        textDelete.Focus();
                        return;
                    }

                }
                return;
            }
            else
            {
                MessageBox.Show("No User was found with the provided UserName");
                return;
            }

        }

        private void UC_DeleteUser_Load(object sender, EventArgs e)
        {
            textDelete.Focus();
        }


        private void uC_CloseButton1_Load(object sender, EventArgs e)
        {

        }
    }
}
