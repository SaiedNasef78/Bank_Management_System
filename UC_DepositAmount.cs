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
    public partial class UC_DepositAmount : clsBasTransActions, ICloasableUserControl
    {

        public event Action CloseRequested;





        public UC_DepositAmount()
        {
            InitializeComponent();
            
            uC_CloseButton1.CloseRequested += () =>
            {

                CloseRequested?.Invoke();
            };
        }

        private void UC_DepositAmount_Load(object sender, EventArgs e)
        {
            // textAccountNumber.Focus();
            ResetDepositForm();

        }
        protected void ResetDepositForm()
        {
            //Hide dependent controls
            SetControlsVisibilty(false, textAccountBalance, textAmount, LblYourBalance, LblAmount, btnDepositAmount, btnClear);

            //Clear Input
            ClearTextBoxes(textAccountNumber, textAmount, textAccountBalance);

            //Reset Client Refrence
            ResetClient();

            textAccountNumber.Focus();
        }

        private void SerchForDepositClient()
        {
            SetControlsVisibilty(false, textAccountBalance, textAmount, LblYourBalance, LblAmount, btnDepositAmount, btnClear);

            ClearTextBoxes(textAmount, textAccountBalance);

            ResetClient();

            if (!SerchForClient(textAccountNumber))
                return;


            //Show Account Information
            ShowClientBalance(textAccountBalance, LblYourBalance);

            //Show Deposit Controls
            SetControlsVisibilty(true, textAmount, LblAmount, btnDepositAmount, btnClear);
            textAmount.Focus();





        }
        private void Deposit()
        {

            if (!CheckTextBoxIsNullOrEmpty(textAmount))
                return;





            if (double.TryParse(textAmount.Text, out double Amount))
            {

                if (Amount <= 0)
                {

                    MessageBox.Show("Amount must be greater than zero");
                    textAmount.Clear();
                    textAmount.Focus();
                    return;
                }


                string Message = "Deposit Completed Successfully!\n"
              + $"Account Number: {textAccountNumber.Text}\n"
             + $"Deposited Amount: {textAmount.Text}\n"
              + $"New Balance : ";

                client.Deposit(Amount);
                MessageBox.Show(Message + client._AccountBalance);
                ResetDepositForm();

                return;
            }

            MessageBox.Show("Invalid AccountBalance", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textAmount.Clear();
            textAmount.Focus();

        }

        private void btnDepositAmount_Click(object sender, EventArgs e)
        {
            Deposit();
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            // SerchForClient();
            SerchForDepositClient();
        }

        private void Account_Balance_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDisplayAccountBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //ResetForm();
            ResetDepositForm();
        }

      

        private void uC_CloseButton1_Load(object sender, EventArgs e)
        {

        }
    }
}
