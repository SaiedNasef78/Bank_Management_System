using Bank_BuisnessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Bank_System_Level2
{
    public partial class UC_TransferMony : clsBasTransActions,ICloasableUserControl
    {
        public event Action CloseRequested;
        public UC_TransferMony(string UserName)
        {
            InitializeComponent();
            _UserName = UserName;


            uC_CloseButton1.CloseRequested += () =>
            {

                CloseRequested?.Invoke();
            };
        }

        private clsClients ClientFrom;
        private clsClients ClientTo;
        private string _UserName = "";
        private void RestFromAccount()
        {
            ClientFrom = null;
            ClientTo = null;
            ResetClient();

            ClearTextBoxes(textAccountBalance, textAccontNumberTo, textAmount, textBalance, textNameTo, textFullNameFrom);


            SetControlsVisibilty(
                false, textAccountBalance,
                LblBalance,
                textFullNameFrom,
                LbFullNameFrom,
                textBalance,
                LblAccountBalanceTo,
                textNameTo,
                LblNameTo,
                textAmount,
                btnTransfer,
                LblAmount

                );

            Serchbtn.Enabled = false;
            textAccontNumberTo.Enabled = false;
            btnClear.Enabled = false;
            btnClearTo.Enabled = false;
            textAccountNumberFrom.Focus();

        }


        private void RestToAccount()
        {

            ClientTo = null;
            ResetClient();

            ClearTextBoxes(textAmount, textBalance, textNameTo);


            SetControlsVisibilty(
                false,
                textBalance,
                LblAccountBalanceTo,
                textNameTo,
                LblNameTo,
                textAmount,
                btnTransfer,
                LblAmount

                );


        }
        private void ResetTransferForm()
        {

            RestFromAccount();
        }


        private void SerchForFromAccount()
        {

            RestFromAccount();

            if (!SerchForClient(textAccountNumberFrom))
                return;

            ClientFrom = client;

            ShowClientBalance(textAccountBalance, LblBalance);

            textFullNameFrom.Text = client._FirstName + " " + client._LastName;
            textFullNameFrom.Visible = true;
            Serchbtn.Enabled = true;
            textAccontNumberTo.Enabled = true;
            btnClear.Enabled = true;
            btnClear.Visible = true;
            textAccontNumberTo.Focus();

        }
        private void SerchToAccount()
        {
            //Clear Previous Next
            RestToAccount();


            if (ClientFrom == null)
            {
                MessageBox.Show("Please serch for from Account first.");
                return;

            }


            if (!SerchForClient(textAccontNumberTo))
                return;

            //Precevnt Transferring to the same account
            if (client._AccountNumber == ClientFrom._AccountNumber)
            {
                MessageBox.Show("From Account And to Account cannot be the same.");
                RestToAccount();
                textAccontNumberTo.Clear();
                textAccontNumberTo.Focus();
                return;

            }

            ClientTo = client;


            //Display to Account Information
            ShowClientBalance(textBalance, LblAccountBalanceTo);

            textNameTo.Text = client._FirstName + " " + client._LastName;
            btnClearTo.Enabled = true;
            SetControlsVisibilty(true,
            textNameTo,
            LblAmount,
            textAmount,
            LblNameTo,
            btnTransfer
            , btnClearTo
              );

            textAmount.Focus();


        }



        private void Transfer()
        {
            if (ClientFrom == null || ClientTo == null)
            {
                MessageBox.Show("Please Search for both Accounts first.");
                return;
            }


            if (!CheckTextBoxIsNullOrEmpty(textAmount))
                return;

            if (!double.TryParse(textAmount.Text, out double Amount))
            {
                MessageBox.Show("Invalid Amount", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textAmount.Clear();
                textAmount.Focus();
                return;
            }



            if (Amount <= 0)
            {
                MessageBox.Show("Amount must be greater than zero", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textAmount.Clear();
                textAmount.Focus();
                return;

            }

            if (ClientFrom.Transfer(DateTime.Now, _UserName, Amount, ClientTo))

            {
                string Message = $"Transfer Completed Successfully!\n"
                    + $"From Account:{ClientFrom._AccountNumber}\n"
                     + $"To Account:{ClientTo._AccountNumber}\n"
                      + $"Transferred Amount:{Amount}\n";
                MessageBox.Show(Message);
                ResetTransferForm();

            }
            else
            {
                if (Amount == ClientTo._AccountBalance)
                {
                    MessageBox.Show("Amount is equal to Destination Balance", "Invalid Transfer", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                else if (Amount > ClientFrom._AccountBalance)
                {
                    MessageBox.Show("Insufficient Balance", "Insufficient Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning);



                }
                else
                {
                    MessageBox.Show("Transfer Failed");

                }
                textAmount.Clear();
                textAmount.Focus();



            }


        }



        private void btnSerch_Click(object sender, EventArgs e)
        {

            SerchForFromAccount();
        }

        private void UC_TransferMony_Load(object sender, EventArgs e)
        {
            ResetTransferForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            ResetTransferForm();

        }



        private void Serchbtn_Click(object sender, EventArgs e)
        {

            SerchToAccount();
        }

        private void textAccountNumberFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClearTo_Click(object sender, EventArgs e)
        {

            ResetTransferForm();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {

            Transfer();




        }

        private void LblClientFrom_Click(object sender, EventArgs e)
        {

        }

        private void uC_CloseButton1_Load(object sender, EventArgs e)
        {

        }
    }
}
