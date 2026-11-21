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
    public partial class UC_ClientsList : UserControl, ICloasableUserControl
    {

        public event Action CloseRequested;
        public UC_ClientsList()
        {
            InitializeComponent();
            uC_CloseButton1.CloseRequested += () =>
            {

                CloseRequested?.Invoke();
            };
        }

        private void UC_ClientsList_Load(object sender, EventArgs e)
        {
            dataGridViewAllClinet.AutoGenerateColumns = true;
            dataGridViewAllClinet.DataSource = clsClients.GetAllClients();
        }

        private void dataGridViewAllClinet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
