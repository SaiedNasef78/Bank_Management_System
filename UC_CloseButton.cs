using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Bank_System_Level2
{
    public partial class UC_CloseButton : UserControl
    {
        public event Action CloseRequested;
        public UC_CloseButton()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
         
            CloseRequested?.Invoke();
        }

        private void UC_CloseButton_Load(object sender, EventArgs e)
        {

        }
    }
}
