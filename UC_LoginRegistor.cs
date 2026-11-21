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
    public partial class UC_LoginRegistor : UserControl,ICloasableUserControl
    {
        public event Action CloseRequested;
        public UC_LoginRegistor()
        {
            InitializeComponent();
            DGV_LoginRegistor.AutoGenerateColumns = true;
            DGV_LoginRegistor.DataSource = clsUsers.GetAllLoginRegistors();

            uC_CloseButton1.CloseRequested += () =>
            {

                CloseRequested?.Invoke();
            };
        }

        private void UC_LoginRegistor_Load(object sender, EventArgs e)
        {

        }
    }
}
