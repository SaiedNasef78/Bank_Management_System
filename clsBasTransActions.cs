using Bank_BuisnessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Bank_System_Level2
{
    public class clsBasTransActions : UserControl
    {




        protected clsClients client;


        protected bool CheckTextBoxIsNullOrEmpty(Guna2TextBox textBox)
        {

            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show($"Please Enter {textBox.Tag}");
                return false;
            }
            return true;

        }


        //SerchForClient
        protected bool SerchForClient(Guna2TextBox Base_TextAccountNumber)
        {
            client = null;
            if (!CheckTextBoxIsNullOrEmpty(Base_TextAccountNumber))
                return false;

            client = clsClients.FindClientByAccountNumber(Base_TextAccountNumber.Text);
            if (client == null)
            {
                MessageBox.Show("Client not found");

                Base_TextAccountNumber.Clear();
                Base_TextAccountNumber.Focus();
                return false;




            }


            return true;
        }

        protected void ShowClientBalance(Guna2TextBox Base_TextAccountBalance, Guna2HtmlLabel Base_lblBalance)
        {

            Base_TextAccountBalance.Text = client._AccountBalance.ToString();

            Base_TextAccountBalance.Visible = true;
            Base_lblBalance.Visible = true;


        }

        protected void ClearTextBoxes(params Guna2TextBox[] textBoxes)
        {

            foreach (Guna2TextBox text in textBoxes)
            {
                text.Clear();
            }

        }

        //change Visibilty 
        protected void SetControlsVisibilty(bool visible, params Control[] controls)

        {

            foreach (Control control in controls)
            {
                control.Visible = visible;
            }
        }

        protected void ResetClient()
        {

            client = null;
        }






    





    }
}
