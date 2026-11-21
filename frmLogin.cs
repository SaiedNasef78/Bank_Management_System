using Bank_BuisnessLayer;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
namespace Project_Bank_System_Level2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            textUserName.Focus();
        }
        
        static clsUsers users1 = null;
        private short Trails = 3;
        private bool _PasswordVisable = false;

       private bool CheckUserNameAndPassword(params Guna2TextBox[] textBoxes)
        {
           foreach(Guna2TextBox textbox in textBoxes)
           {
               if (string.IsNullOrEmpty(textbox.Text))
               {
                  MessageBox.Show($"Please Enter {textbox.Tag}");
                    return false;
               }
           }
           return true;
        }
        private bool _Login()
        {
           if (!CheckUserNameAndPassword(textUserName, textPassword))
            
                return false;


            users1 = clsUsers.FindUserByUserNameAndPassword(textUserName.Text, textPassword.Text);
            if (users1 != null)
            {

                users1.LoginRegistor(DateTime.Now);

                return true;
            }

            if (Trails == 1)
            {
                Trails = 3;
                MessageBox.Show($"You are locked after {Trails} faild trials", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                this.Close();

                btnLogin.Enabled = false;
                return false;
            }

            if (MessageBox.Show($"Invalid UserName,Invalid Password \nYou have" +
                $" {--Trails} Trials to login. ", "Error", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return false;
            }


            textUserName.Clear();
            textPassword.Clear();
            return false;









        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textUserName.Focus();
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmShowMainMenue frm = new frmShowMainMenue(users1);
            frm.Show();
        }

        private void textUserName_TextChanged(object sender, EventArgs e)
       {


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (_Login())
            {
                frmShowMainMenue frm = new frmShowMainMenue(users1);
                frm.Show();

            }



        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

           
            if (!_PasswordVisable)
            {
                textPassword.UseSystemPasswordChar = true;
                imageButton.Image = Properties.Resources.Eye_Close;
                _PasswordVisable = true;
            }
            else
            {
                textPassword.UseSystemPasswordChar = false;
                imageButton.Image = Properties.Resources.Eye_Open__2_;
                _PasswordVisable = false;
            }
          
        }
    }
}
