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
    public partial class UC_WithdrawlAmountcs : clsBasTransActions,ICloasableUserControl
    {

        public event Action CloseRequested; 
        public UC_WithdrawlAmountcs()
        {
            InitializeComponent();

            uC_CloseButton1.CloseRequested += () =>
            {

                CloseRequested?.Invoke();
            };

        }



        protected void ResetWithDrawForm()
        {
            //Hide dependent controls
            SetControlsVisibilty(false, textAccountBalance, textAmount, LblYourBalance, lblAmount, btnWithDraw, btnClear);

            //Clear Input
            ClearTextBoxes(textAccountNumber, textAmount, textAccountBalance);

            //Reset Client Refrence
            ResetClient();

            textAccountNumber.Focus();
        }


        private void SerchForWithdrawClient()
        {
            SetControlsVisibilty(false, textAccountBalance, textAmount, LblYourBalance, lblAmount, btnWithDraw, btnClear);

            ClearTextBoxes(textAmount, textAccountBalance);

            ResetClient();

            if (!SerchForClient(textAccountNumber))
                return;


            //Show Account Information
            ShowClientBalance(textAccountBalance, LblYourBalance);

            //Show Deposit Controls
            SetControlsVisibilty(true, textAmount, lblAmount, btnWithDraw, btnClear);
            textAmount.Focus();





        }




        private void WithDrawlAmount()
        {

            if (client == null)
            {
                MessageBox.Show("Please Serch for a client first.");
                return;

            }

            if (!CheckTextBoxIsNullOrEmpty(textAmount))
                return;

            if (double.TryParse(textAmount.Text, out double Amount))
            {

                if (Amount <= 0)
                {

                    MessageBox.Show("Amount must be greater than zero", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textAmount.Clear();
                    textAmount.Focus();
                    return;
                }


                //Excute withdraw operation
                if (client.WithDrow(Amount))
                {

                    string Message = "WithDraw Completed Successfully!\n"
                + $"Account Number: {textAccountNumber.Text}\n"
               + $"Withdrawen Amount: {textAmount.Text}\n"
                + $"New Balance : {client._AccountBalance}";

                    MessageBox.Show(Message);

                    ResetWithDrawForm();
                    return;
                }
                else
                {
                    MessageBox.Show("Insufficient balance.The Withdrawl amount exceed your available balance.",
                        "Insufficient Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    textAmount.Clear();
                    textAmount.Focus();
                    return;
                }

            }

            MessageBox.Show("Invalid Amount", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textAmount.Clear();



        }
        private void UC_WithdrawlAmountcs_Load(object sender, EventArgs e)
        {


            ResetWithDrawForm();
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            SerchForWithdrawClient();

        }

        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            WithDrawlAmount();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetWithDrawForm();

        }

        private void uC_CloseButton1_Load(object sender, EventArgs e)
        {

        }
    }
}
