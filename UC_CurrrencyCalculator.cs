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
    public partial class UC_CurrrencyCalculator : UserControl, ICloasableUserControl
    {
        public event Action CloseRequested;
        public UC_CurrrencyCalculator()
        {
            InitializeComponent();
            uC_CloseButton1.CloseRequested += () =>
            {

                CloseRequested?.Invoke();
            };
        }

        private bool CheckComboBox(params Guna2ComboBox[] comboboxes)
        {

            foreach (Guna2ComboBox comboBox in comboboxes)
            {
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Pleas select a Country" + comboBox.Tag.ToString());
                    return false;
                }
            }
            return true;

        }

        clsCurrencies CurrencyFrom = new clsCurrencies();

        clsCurrencies CurrencyTo = new clsCurrencies();

        private void Convert()
        {

            if (!CheckComboBox(CB_CurrencyFrom, CB_CurrencyTo))
                return;



            CurrencyFrom = clsCurrencies.FindCurrencyByCountryName(CB_CurrencyFrom.SelectedItem.ToString());
            CurrencyTo = clsCurrencies.FindCurrencyByCountryName(CB_CurrencyTo.SelectedItem.ToString());

            if (decimal.TryParse(textCurrrencyFrom.Text, out decimal Amount))
            {

                textCurrencyTo.Text = CurrencyFrom.ConvertToOther(Amount, CurrencyTo).ToString("0.####");
            }
            else
            {
                MessageBox.Show("Invalid");
            }

        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            Convert();

        }
        private void SwapCurrency()
        {
            clsCurrencies CurrecyeTemp = new clsCurrencies();

            CurrecyeTemp = CurrencyFrom;
            CurrencyFrom = CurrencyTo;
            CurrencyTo = CurrecyeTemp;

            CB_CurrencyFrom.SelectedItem = CurrencyFrom.CountryName;
            CB_CurrencyTo.SelectedItem = CurrencyTo.CountryName;

            Guna2TextBox TextTemp = new Guna2TextBox();
            TextTemp.Text = textCurrrencyFrom.Text;
            textCurrrencyFrom.Text = textCurrencyTo.Text;
            textCurrencyTo.Text = TextTemp.Text;


        }
        private void btnSwap_Click(object sender, EventArgs e)
        {
            SwapCurrency();
            Convert();

        }

        private void UC_CurrrencyCalculator_Load(object sender, EventArgs e)
        {

        }

      
        private void uC_CloseButton1_Load(object sender, EventArgs e)
        {

        }
    }
}
