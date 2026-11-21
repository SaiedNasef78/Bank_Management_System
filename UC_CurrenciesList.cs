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
    public partial class UC_CurrenciesList : UserControl,ICloasableUserControl
    {

        public event Action CloseRequested;
        public UC_CurrenciesList()
        {
            InitializeComponent();
            DGV_CurrenciesList.AutoGenerateColumns = true;
            DGV_CurrenciesList.DataSource = clsCurrencies.GetAllCurrencies();

            uC_CloseButton1.CloseRequested += () =>
            {

                CloseRequested?.Invoke();
            };
        }

        private void UC_CurrenciesList_Load(object sender, EventArgs e)
        {

        }

        
    }
}
