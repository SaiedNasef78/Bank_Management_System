using Bank_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Bank_System_Level2
{
    public partial class UC_TransferLog : UserControl,ICloasableUserControl
    {
        public event Action CloseRequested;
        public UC_TransferLog()
        {
            InitializeComponent();

            uC_CloseButton1.CloseRequested += () =>
            {

                CloseRequested?.Invoke();
            };
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DGVTransferLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_TransferLog_Load(object sender, EventArgs e)
        {

            DGVTransferLog.AutoGenerateColumns = true;
            DGVTransferLog.DataSource = clsTransferLogData.GetAllTransfers();


        }

        private void uC_CloseButton1_Load(object sender, EventArgs e)
        {

        }
    }
}
