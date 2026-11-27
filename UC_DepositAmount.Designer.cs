namespace Project_Bank_System_Level2
{
    partial class UC_DepositAmount
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            textAccountBalance = new Guna.UI2.WinForms.Guna2TextBox();
            LblYourBalance = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnDepositAmount = new Guna.UI2.WinForms.Guna2Button();
            btnSerch = new Guna.UI2.WinForms.Guna2Button();
            LblAccountNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            textAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            textAmount = new Guna.UI2.WinForms.Guna2TextBox();
            btnClear = new Guna.UI2.WinForms.Guna2Button();
            LblAmount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            LblDeposit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            PB_DepositAmount = new Guna.UI2.WinForms.Guna2PictureBox();
            uC_CloseButton1 = new UC_CloseButton();
            ((System.ComponentModel.ISupportInitialize)PB_DepositAmount).BeginInit();
            SuspendLayout();
            // 
            // textAccountBalance
            // 
            textAccountBalance.BackColor = Color.Transparent;
            textAccountBalance.BorderColor = Color.Gray;
            textAccountBalance.BorderRadius = 15;
            textAccountBalance.CustomizableEdges = customizableEdges1;
            textAccountBalance.DefaultText = "";
            textAccountBalance.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textAccountBalance.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textAccountBalance.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textAccountBalance.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textAccountBalance.FillColor = SystemColors.ButtonFace;
            textAccountBalance.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textAccountBalance.Font = new Font("Segoe UI", 9F);
            textAccountBalance.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textAccountBalance.Location = new Point(16, 292);
            textAccountBalance.Name = "textAccountBalance";
            textAccountBalance.PlaceholderText = "";
            textAccountBalance.ReadOnly = true;
            textAccountBalance.SelectedText = "";
            textAccountBalance.ShadowDecoration.CustomizableEdges = customizableEdges2;
            textAccountBalance.Size = new Size(263, 45);
            textAccountBalance.TabIndex = 0;
            textAccountBalance.Tag = "Account Balance";
            textAccountBalance.Visible = false;
            textAccountBalance.TextChanged += textDisplayAccountBalance_TextChanged;
            // 
            // LblYourBalance
            // 
            LblYourBalance.BackColor = Color.Transparent;
            LblYourBalance.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblYourBalance.Location = new Point(16, 250);
            LblYourBalance.Name = "LblYourBalance";
            LblYourBalance.Size = new Size(125, 27);
            LblYourBalance.TabIndex = 1;
            LblYourBalance.Text = "Your Balance";
            LblYourBalance.Visible = false;
            // 
            // btnDepositAmount
            // 
            btnDepositAmount.BackColor = Color.Transparent;
            btnDepositAmount.BorderRadius = 10;
            btnDepositAmount.CustomizableEdges = customizableEdges3;
            btnDepositAmount.DisabledState.BorderColor = Color.DarkGray;
            btnDepositAmount.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDepositAmount.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDepositAmount.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDepositAmount.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDepositAmount.ForeColor = Color.White;
            btnDepositAmount.Location = new Point(299, 395);
            btnDepositAmount.Name = "btnDepositAmount";
            btnDepositAmount.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDepositAmount.Size = new Size(95, 38);
            btnDepositAmount.TabIndex = 2;
            btnDepositAmount.Text = "Deposit";
            btnDepositAmount.Visible = false;
            btnDepositAmount.Click += btnDepositAmount_Click;
            // 
            // btnSerch
            // 
            btnSerch.BackColor = Color.Transparent;
            btnSerch.BorderRadius = 10;
            btnSerch.CustomizableEdges = customizableEdges5;
            btnSerch.DisabledState.BorderColor = Color.DarkGray;
            btnSerch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSerch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSerch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSerch.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSerch.ForeColor = Color.White;
            btnSerch.Location = new Point(285, 174);
            btnSerch.Name = "btnSerch";
            btnSerch.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSerch.Size = new Size(95, 38);
            btnSerch.TabIndex = 5;
            btnSerch.Text = "Serch";
            btnSerch.Click += btnSerch_Click;
            // 
            // LblAccountNumber
            // 
            LblAccountNumber.BackColor = Color.Transparent;
            LblAccountNumber.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAccountNumber.Location = new Point(16, 132);
            LblAccountNumber.Name = "LblAccountNumber";
            LblAccountNumber.Size = new Size(160, 27);
            LblAccountNumber.TabIndex = 4;
            LblAccountNumber.Text = "Account Number";
            // 
            // textAccountNumber
            // 
            textAccountNumber.BackColor = Color.Transparent;
            textAccountNumber.BorderColor = Color.Gray;
            textAccountNumber.BorderRadius = 15;
            textAccountNumber.CustomizableEdges = customizableEdges7;
            textAccountNumber.DefaultText = "";
            textAccountNumber.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textAccountNumber.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textAccountNumber.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textAccountNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textAccountNumber.FillColor = SystemColors.ButtonFace;
            textAccountNumber.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textAccountNumber.Font = new Font("Segoe UI", 9F);
            textAccountNumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textAccountNumber.Location = new Point(16, 174);
            textAccountNumber.Name = "textAccountNumber";
            textAccountNumber.PlaceholderText = "";
            textAccountNumber.SelectedText = "";
            textAccountNumber.ShadowDecoration.CustomizableEdges = customizableEdges8;
            textAccountNumber.Size = new Size(263, 45);
            textAccountNumber.TabIndex = 3;
            textAccountNumber.Tag = "Account Number";
            // 
            // textAmount
            // 
            textAmount.BackColor = Color.Transparent;
            textAmount.BorderColor = Color.Gray;
            textAmount.BorderRadius = 15;
            textAmount.CustomizableEdges = customizableEdges9;
            textAmount.DefaultText = "";
            textAmount.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textAmount.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textAmount.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textAmount.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textAmount.FillColor = SystemColors.ButtonFace;
            textAmount.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textAmount.Font = new Font("Segoe UI", 9F);
            textAmount.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textAmount.Location = new Point(16, 395);
            textAmount.Name = "textAmount";
            textAmount.PlaceholderText = "";
            textAmount.SelectedText = "";
            textAmount.ShadowDecoration.CustomizableEdges = customizableEdges10;
            textAmount.Size = new Size(263, 45);
            textAmount.TabIndex = 6;
            textAmount.Tag = "Account Balance";
            textAmount.Visible = false;
            textAmount.WordWrap = false;
            textAmount.TextChanged += Account_Balance_TextChanged;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Transparent;
            btnClear.BorderRadius = 10;
            btnClear.CustomizableEdges = customizableEdges11;
            btnClear.DisabledState.BorderColor = Color.DarkGray;
            btnClear.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClear.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClear.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClear.FillColor = Color.Gray;
            btnClear.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(429, 395);
            btnClear.Name = "btnClear";
            btnClear.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnClear.Size = new Size(95, 38);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.Visible = false;
            btnClear.Click += btnClear_Click;
            // 
            // LblAmount
            // 
            LblAmount.BackColor = Color.Transparent;
            LblAmount.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAmount.Location = new Point(28, 362);
            LblAmount.Name = "LblAmount";
            LblAmount.Size = new Size(79, 27);
            LblAmount.TabIndex = 8;
            LblAmount.Text = "Amount";
            LblAmount.Visible = false;
            // 
            // LblDeposit
            // 
            LblDeposit.BackColor = Color.Transparent;
            LblDeposit.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDeposit.ForeColor = Color.FromArgb(14, 93, 188);
            LblDeposit.Location = new Point(194, 46);
            LblDeposit.Name = "LblDeposit";
            LblDeposit.Size = new Size(220, 39);
            LblDeposit.TabIndex = 9;
            LblDeposit.Text = "Deposit Amount";
            // 
            // PB_DepositAmount
            // 
            PB_DepositAmount.BackColor = Color.Transparent;
            PB_DepositAmount.CustomizableEdges = customizableEdges13;
            PB_DepositAmount.Image = Properties.Resources.depositAmount;
            PB_DepositAmount.ImageRotate = 0F;
            PB_DepositAmount.Location = new Point(429, 26);
            PB_DepositAmount.Name = "PB_DepositAmount";
            PB_DepositAmount.ShadowDecoration.CustomizableEdges = customizableEdges14;
            PB_DepositAmount.Size = new Size(95, 83);
            PB_DepositAmount.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_DepositAmount.TabIndex = 10;
            PB_DepositAmount.TabStop = false;
            // 
            // uC_CloseButton1
            // 
            uC_CloseButton1.AutoSize = true;
            uC_CloseButton1.Location = new Point(663, 0);
            uC_CloseButton1.MaximumSize = new Size(50, 45);
            uC_CloseButton1.MinimumSize = new Size(50, 50);
            uC_CloseButton1.Name = "uC_CloseButton1";
            uC_CloseButton1.Size = new Size(50, 50);
            uC_CloseButton1.TabIndex = 11;
            uC_CloseButton1.Load += uC_CloseButton1_Load;
            // 
            // UC_DepositAmount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 197, 245);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(uC_CloseButton1);
            Controls.Add(PB_DepositAmount);
            Controls.Add(LblDeposit);
            Controls.Add(LblAmount);
            Controls.Add(btnClear);
            Controls.Add(textAmount);
            Controls.Add(btnSerch);
            Controls.Add(LblAccountNumber);
            Controls.Add(textAccountNumber);
            Controls.Add(btnDepositAmount);
            Controls.Add(LblYourBalance);
            Controls.Add(textAccountBalance);
            Name = "UC_DepositAmount";
            Size = new Size(775, 483);
            Load += UC_DepositAmount_Load;
            ((System.ComponentModel.ISupportInitialize)PB_DepositAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textAccountBalance;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblYourBalance;
        private Guna.UI2.WinForms.Guna2Button btnDepositAmount;
        private Guna.UI2.WinForms.Guna2Button btnSerch;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblAccountNumber;
        private Guna.UI2.WinForms.Guna2TextBox textAccountNumber;
        private Guna.UI2.WinForms.Guna2TextBox textAmount;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblAmount;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblDeposit;
        private Guna.UI2.WinForms.Guna2PictureBox PB_DepositAmount;
        private UC_CloseButton uC_CloseButton1;
    }
}
