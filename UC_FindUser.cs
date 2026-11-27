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
    public partial class UC_FindUser : UC_BaseUsers
    {
        public UC_FindUser()
        {
            InitializeComponent();
        }

        private void UC_FindUser_Load(object sender, EventArgs e)
        {
            textUserName.Focus();
        }
        private void SetLabelVisiblity(bool IsVisible, params Guna2HtmlLabel[] Labels)
        {
            foreach (Guna2HtmlLabel Label in Labels)
            {
                Label.Visible = IsVisible;

            }


        }

        private void SetTextVisiblity(bool IsVisible, params Guna2TextBox[] textboxes)
        {
            foreach (Guna2TextBox textBox in textboxes)
            {
                textBox.Visible = IsVisible;

            }


        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textUserName.Text))
            {
                MessageBox.Show("Please Enter UserName");
                textUserName.Clear();
                textUserName.Focus();
                return;
            }

            User = clsUsers.FindUserByUserName(textUserName.Text);
            if (User != null)
            {


                textFirstName.Text = User._FirstName;
                textLastName.Text = User._LastName;
                textEnail.Text = User._Email;
                textPassword.Text = User.Password;
                textPhone.Text = User._Phone;
                CB_Country.SelectedIndex = CB_Country.FindStringExact(User.Country);

              

                SetPermissionsCheckBoxes();

                CB_Country.Visible = true;
                GB_Permissions.Visible = true;
                SetLabelVisiblity(true, LblFirstName, LblLastName, LblEmail, LblPhone, LblPassword, LblCountry);
                SetTextVisiblity(true, textEnail, textFirstName, textLastName, textPassword, textPhone);

              

            }
            else
            {
                MessageBox.Show("User not found");
                textUserName.Clear();
                textUserName.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
