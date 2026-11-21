namespace Project_Bank_System_Level2
{
    partial class UC_Home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            PB_ImageUser = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            LBLUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            GB_Permissons = new GroupBox();
            CB_CurrecyExhange = new Guna.UI2.WinForms.Guna2CheckBox();
            CB_LoginRegistor = new Guna.UI2.WinForms.Guna2CheckBox();
            CB_UsersManagement = new Guna.UI2.WinForms.Guna2CheckBox();
            CB_Transactions = new Guna.UI2.WinForms.Guna2CheckBox();
            CB_FindClient = new Guna.UI2.WinForms.Guna2CheckBox();
            CB_UpdateClient = new Guna.UI2.WinForms.Guna2CheckBox();
            CB_DeleteClient = new Guna.UI2.WinForms.Guna2CheckBox();
            CB_AddClient = new Guna.UI2.WinForms.Guna2CheckBox();
            CB_ClientLst = new Guna.UI2.WinForms.Guna2CheckBox();
            CB_All = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)PB_ImageUser).BeginInit();
            GB_Permissons.SuspendLayout();
            SuspendLayout();
            // 
            // PB_ImageUser
            // 
            PB_ImageUser.BackColor = Color.Transparent;
            PB_ImageUser.CustomizableEdges = customizableEdges7;
            PB_ImageUser.Image = Properties.Resources.User;
            PB_ImageUser.ImageRotate = 0F;
            PB_ImageUser.Location = new Point(605, 12);
            PB_ImageUser.Name = "PB_ImageUser";
            PB_ImageUser.ShadowDecoration.CustomizableEdges = customizableEdges8;
            PB_ImageUser.Size = new Size(81, 62);
            PB_ImageUser.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_ImageUser.TabIndex = 8;
            PB_ImageUser.TabStop = false;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.AutoSize = false;
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.Black;
            guna2HtmlLabel2.Location = new Point(409, 21);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(99, 39);
            guna2HtmlLabel2.TabIndex = 7;
            guna2HtmlLabel2.Text = "UserName: ";
            // 
            // LBLUserName
            // 
            LBLUserName.AutoSize = false;
            LBLUserName.BackColor = Color.Transparent;
            LBLUserName.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLUserName.ForeColor = Color.FromArgb(14, 93, 188);
            LBLUserName.Location = new Point(514, 21);
            LBLUserName.Name = "LBLUserName";
            LBLUserName.Size = new Size(85, 39);
            LBLUserName.TabIndex = 6;
            LBLUserName.Text = null;
            // 
            // GB_Permissons
            // 
            GB_Permissons.BackColor = Color.Transparent;
            GB_Permissons.Controls.Add(CB_CurrecyExhange);
            GB_Permissons.Controls.Add(CB_LoginRegistor);
            GB_Permissons.Controls.Add(CB_UsersManagement);
            GB_Permissons.Controls.Add(CB_Transactions);
            GB_Permissons.Controls.Add(CB_FindClient);
            GB_Permissons.Controls.Add(CB_UpdateClient);
            GB_Permissons.Controls.Add(CB_DeleteClient);
            GB_Permissons.Controls.Add(CB_AddClient);
            GB_Permissons.Controls.Add(CB_ClientLst);
            GB_Permissons.Controls.Add(CB_All);
            GB_Permissons.Enabled = false;
            GB_Permissons.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GB_Permissons.Location = new Point(97, 67);
            GB_Permissons.Name = "GB_Permissons";
            GB_Permissons.Size = new Size(515, 159);
            GB_Permissons.TabIndex = 5;
            GB_Permissons.TabStop = false;
            GB_Permissons.Text = "Permissions";
            GB_Permissons.Enter += GB_Permissons_Enter;
            // 
            // CB_CurrecyExhange
            // 
            CB_CurrecyExhange.CheckedState.BorderColor = Color.Green;
            CB_CurrecyExhange.CheckedState.BorderRadius = 0;
            CB_CurrecyExhange.CheckedState.BorderThickness = 0;
            CB_CurrecyExhange.CheckedState.FillColor = Color.Green;
            CB_CurrecyExhange.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CB_CurrecyExhange.Location = new Point(351, 111);
            CB_CurrecyExhange.Name = "CB_CurrecyExhange";
            CB_CurrecyExhange.Size = new Size(151, 24);
            CB_CurrecyExhange.TabIndex = 11;
            CB_CurrecyExhange.Text = "CurrecyExhange";
            CB_CurrecyExhange.UncheckedState.BorderColor = Color.Gray;
            CB_CurrecyExhange.UncheckedState.BorderRadius = 2;
            CB_CurrecyExhange.UncheckedState.BorderThickness = 1;
            CB_CurrecyExhange.UncheckedState.FillColor = Color.LightGray;
            // 
            // CB_LoginRegistor
            // 
            CB_LoginRegistor.CheckedState.BorderColor = Color.Green;
            CB_LoginRegistor.CheckedState.BorderRadius = 0;
            CB_LoginRegistor.CheckedState.BorderThickness = 0;
            CB_LoginRegistor.CheckedState.FillColor = Color.Green;
            CB_LoginRegistor.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CB_LoginRegistor.Location = new Point(201, 107);
            CB_LoginRegistor.Name = "CB_LoginRegistor";
            CB_LoginRegistor.Size = new Size(125, 24);
            CB_LoginRegistor.TabIndex = 10;
            CB_LoginRegistor.Text = "LoginRegistor";
            CB_LoginRegistor.UncheckedState.BorderColor = Color.Gray;
            CB_LoginRegistor.UncheckedState.BorderRadius = 2;
            CB_LoginRegistor.UncheckedState.BorderThickness = 1;
            CB_LoginRegistor.UncheckedState.FillColor = Color.LightGray;
            // 
            // CB_UsersManagement
            // 
            CB_UsersManagement.CheckedState.BorderColor = Color.Green;
            CB_UsersManagement.CheckedState.BorderRadius = 0;
            CB_UsersManagement.CheckedState.BorderThickness = 0;
            CB_UsersManagement.CheckedState.FillColor = Color.Green;
            CB_UsersManagement.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CB_UsersManagement.Location = new Point(17, 107);
            CB_UsersManagement.Name = "CB_UsersManagement";
            CB_UsersManagement.Size = new Size(178, 24);
            CB_UsersManagement.TabIndex = 9;
            CB_UsersManagement.Text = "Manage Users";
            CB_UsersManagement.UncheckedState.BorderColor = Color.Gray;
            CB_UsersManagement.UncheckedState.BorderRadius = 2;
            CB_UsersManagement.UncheckedState.BorderThickness = 1;
            CB_UsersManagement.UncheckedState.FillColor = Color.LightGray;
            // 
            // CB_Transactions
            // 
            CB_Transactions.CheckedState.BorderColor = Color.Green;
            CB_Transactions.CheckedState.BorderRadius = 0;
            CB_Transactions.CheckedState.BorderThickness = 0;
            CB_Transactions.CheckedState.FillColor = Color.Green;
            CB_Transactions.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CB_Transactions.Location = new Point(351, 77);
            CB_Transactions.Name = "CB_Transactions";
            CB_Transactions.Size = new Size(151, 24);
            CB_Transactions.TabIndex = 8;
            CB_Transactions.Text = "Transactions";
            CB_Transactions.UncheckedState.BorderColor = Color.Gray;
            CB_Transactions.UncheckedState.BorderRadius = 2;
            CB_Transactions.UncheckedState.BorderThickness = 1;
            CB_Transactions.UncheckedState.FillColor = Color.LightGray;
            // 
            // CB_FindClient
            // 
            CB_FindClient.CheckedState.BorderColor = Color.Green;
            CB_FindClient.CheckedState.BorderRadius = 0;
            CB_FindClient.CheckedState.BorderThickness = 0;
            CB_FindClient.CheckedState.FillColor = Color.Green;
            CB_FindClient.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CB_FindClient.Location = new Point(201, 77);
            CB_FindClient.Name = "CB_FindClient";
            CB_FindClient.Size = new Size(134, 24);
            CB_FindClient.TabIndex = 7;
            CB_FindClient.Text = "Find Client";
            CB_FindClient.UncheckedState.BorderColor = Color.Gray;
            CB_FindClient.UncheckedState.BorderRadius = 2;
            CB_FindClient.UncheckedState.BorderThickness = 1;
            CB_FindClient.UncheckedState.FillColor = Color.LightGray;
            // 
            // CB_UpdateClient
            // 
            CB_UpdateClient.CheckedState.BorderColor = Color.Green;
            CB_UpdateClient.CheckedState.BorderRadius = 0;
            CB_UpdateClient.CheckedState.BorderThickness = 0;
            CB_UpdateClient.CheckedState.FillColor = Color.Green;
            CB_UpdateClient.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CB_UpdateClient.Location = new Point(17, 77);
            CB_UpdateClient.Name = "CB_UpdateClient";
            CB_UpdateClient.Size = new Size(124, 24);
            CB_UpdateClient.TabIndex = 6;
            CB_UpdateClient.Text = "Update Client";
            CB_UpdateClient.UncheckedState.BorderColor = Color.Gray;
            CB_UpdateClient.UncheckedState.BorderRadius = 2;
            CB_UpdateClient.UncheckedState.BorderThickness = 1;
            CB_UpdateClient.UncheckedState.FillColor = Color.LightGray;
            // 
            // CB_DeleteClient
            // 
            CB_DeleteClient.CheckedState.BorderColor = Color.Green;
            CB_DeleteClient.CheckedState.BorderRadius = 0;
            CB_DeleteClient.CheckedState.BorderThickness = 0;
            CB_DeleteClient.CheckedState.FillColor = Color.Green;
            CB_DeleteClient.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CB_DeleteClient.Location = new Point(351, 47);
            CB_DeleteClient.Name = "CB_DeleteClient";
            CB_DeleteClient.Size = new Size(151, 24);
            CB_DeleteClient.TabIndex = 5;
            CB_DeleteClient.Text = "Delete Client";
            CB_DeleteClient.UncheckedState.BorderColor = Color.Gray;
            CB_DeleteClient.UncheckedState.BorderRadius = 2;
            CB_DeleteClient.UncheckedState.BorderThickness = 1;
            CB_DeleteClient.UncheckedState.FillColor = Color.LightGray;
            // 
            // CB_AddClient
            // 
            CB_AddClient.CheckedState.BorderColor = Color.Green;
            CB_AddClient.CheckedState.BorderRadius = 0;
            CB_AddClient.CheckedState.BorderThickness = 0;
            CB_AddClient.CheckedState.FillColor = Color.Green;
            CB_AddClient.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CB_AddClient.Location = new Point(201, 47);
            CB_AddClient.Name = "CB_AddClient";
            CB_AddClient.Size = new Size(134, 24);
            CB_AddClient.TabIndex = 4;
            CB_AddClient.Text = "Add Client";
            CB_AddClient.UncheckedState.BorderColor = Color.Gray;
            CB_AddClient.UncheckedState.BorderRadius = 2;
            CB_AddClient.UncheckedState.BorderThickness = 1;
            CB_AddClient.UncheckedState.FillColor = Color.LightGray;
            // 
            // CB_ClientLst
            // 
            CB_ClientLst.CheckedState.BorderColor = Color.Green;
            CB_ClientLst.CheckedState.BorderRadius = 0;
            CB_ClientLst.CheckedState.BorderThickness = 0;
            CB_ClientLst.CheckedState.FillColor = Color.Green;
            CB_ClientLst.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CB_ClientLst.Location = new Point(17, 47);
            CB_ClientLst.Name = "CB_ClientLst";
            CB_ClientLst.Size = new Size(124, 24);
            CB_ClientLst.TabIndex = 3;
            CB_ClientLst.Text = "Clients List";
            CB_ClientLst.UncheckedState.BorderColor = Color.Gray;
            CB_ClientLst.UncheckedState.BorderRadius = 2;
            CB_ClientLst.UncheckedState.BorderThickness = 1;
            CB_ClientLst.UncheckedState.FillColor = Color.LightGray;
            // 
            // CB_All
            // 
            CB_All.AutoSize = true;
            CB_All.CheckedState.BorderColor = Color.Green;
            CB_All.CheckedState.BorderRadius = 0;
            CB_All.CheckedState.BorderThickness = 0;
            CB_All.CheckedState.FillColor = Color.Green;
            CB_All.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CB_All.Location = new Point(17, 22);
            CB_All.Name = "CB_All";
            CB_All.Size = new Size(46, 24);
            CB_All.TabIndex = 0;
            CB_All.Text = "All";
            CB_All.UncheckedState.BorderColor = Color.Gray;
            CB_All.UncheckedState.BorderRadius = 2;
            CB_All.UncheckedState.BorderThickness = 1;
            CB_All.UncheckedState.FillColor = Color.LightGray;
            CB_All.CheckedChanged += CB_All_CheckedChanged_1;
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 197, 245);
            Controls.Add(PB_ImageUser);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(LBLUserName);
            Controls.Add(GB_Permissons);
            Name = "UC_Home";
            Size = new Size(774, 539);
            Load += UC_Home_Load;
            ((System.ComponentModel.ISupportInitialize)PB_ImageUser).EndInit();
            GB_Permissons.ResumeLayout(false);
            GB_Permissons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox PB_ImageUser;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel LBLUserName;
        private GroupBox GB_Permissons;
        private Guna.UI2.WinForms.Guna2CheckBox CB_CurrecyExhange;
        private Guna.UI2.WinForms.Guna2CheckBox CB_LoginRegistor;
        private Guna.UI2.WinForms.Guna2CheckBox CB_UsersManagement;
        private Guna.UI2.WinForms.Guna2CheckBox CB_Transactions;
        private Guna.UI2.WinForms.Guna2CheckBox CB_FindClient;
        private Guna.UI2.WinForms.Guna2CheckBox CB_UpdateClient;
        private Guna.UI2.WinForms.Guna2CheckBox CB_DeleteClient;
        private Guna.UI2.WinForms.Guna2CheckBox CB_AddClient;
        private Guna.UI2.WinForms.Guna2CheckBox CB_ClientLst;
        private Guna.UI2.WinForms.Guna2CheckBox CB_All;
    }
}
