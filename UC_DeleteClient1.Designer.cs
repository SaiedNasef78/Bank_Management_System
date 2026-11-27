namespace Project_Bank_System_Level2
{
    partial class UC_DeleteClient1
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
            textAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            LblAccountNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            PB_iamgeDelete = new Guna.UI2.WinForms.Guna2PictureBox();
            uC_CloseButton1 = new UC_CloseButton();
            ((System.ComponentModel.ISupportInitialize)PB_iamgeDelete).BeginInit();
            SuspendLayout();
            // 
            // textAccountNumber
            // 
            textAccountNumber.BackColor = Color.Transparent;
            textAccountNumber.BorderColor = Color.Gray;
            textAccountNumber.BorderRadius = 15;
            textAccountNumber.BorderThickness = 2;
            textAccountNumber.CustomizableEdges = customizableEdges1;
            textAccountNumber.DefaultText = "";
            textAccountNumber.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textAccountNumber.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textAccountNumber.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textAccountNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textAccountNumber.FillColor = SystemColors.ButtonFace;
            textAccountNumber.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textAccountNumber.Font = new Font("Segoe UI", 9F);
            textAccountNumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textAccountNumber.Location = new Point(265, 212);
            textAccountNumber.Name = "textAccountNumber";
            textAccountNumber.PlaceholderText = "";
            textAccountNumber.SelectedText = "";
            textAccountNumber.ShadowDecoration.CustomizableEdges = customizableEdges2;
            textAccountNumber.Size = new Size(394, 51);
            textAccountNumber.TabIndex = 0;
            textAccountNumber.TextChanged += textAccountNumber_TextChanged;
            // 
            // LblAccountNumber
            // 
            LblAccountNumber.BackColor = Color.Transparent;
            LblAccountNumber.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAccountNumber.Location = new Point(265, 183);
            LblAccountNumber.Name = "LblAccountNumber";
            LblAccountNumber.Size = new Size(126, 23);
            LblAccountNumber.TabIndex = 1;
            LblAccountNumber.Text = "Account Nmber";
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.BackColor = Color.Transparent;
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton1.Image = Properties.Resources.icons8_remove_100;
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.Location = new Point(665, 209);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2ImageButton1.Size = new Size(46, 54);
            guna2ImageButton1.TabIndex = 3;
            guna2ImageButton1.Click += guna2ImageButton1_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(14, 93, 188);
            guna2HtmlLabel1.Location = new Point(296, 46);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(171, 39);
            guna2HtmlLabel1.TabIndex = 4;
            guna2HtmlLabel1.Text = "Delete Client";
            // 
            // PB_iamgeDelete
            // 
            PB_iamgeDelete.BackColor = Color.Transparent;
            PB_iamgeDelete.CustomizableEdges = customizableEdges4;
            PB_iamgeDelete.Image = Properties.Resources.Delete;
            PB_iamgeDelete.ImageRotate = 0F;
            PB_iamgeDelete.Location = new Point(473, 21);
            PB_iamgeDelete.Name = "PB_iamgeDelete";
            PB_iamgeDelete.ShadowDecoration.CustomizableEdges = customizableEdges5;
            PB_iamgeDelete.Size = new Size(90, 64);
            PB_iamgeDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_iamgeDelete.TabIndex = 5;
            PB_iamgeDelete.TabStop = false;
            // 
            // uC_CloseButton1
            // 
            uC_CloseButton1.AutoSize = true;
            uC_CloseButton1.Location = new Point(650, 0);
            uC_CloseButton1.MaximumSize = new Size(50, 45);
            uC_CloseButton1.MinimumSize = new Size(50, 50);
            uC_CloseButton1.Name = "uC_CloseButton1";
            uC_CloseButton1.Size = new Size(50, 50);
            uC_CloseButton1.TabIndex = 6;
            // 
            // UC_DeleteClient1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 197, 245);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(uC_CloseButton1);
            Controls.Add(PB_iamgeDelete);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2ImageButton1);
            Controls.Add(LblAccountNumber);
            Controls.Add(textAccountNumber);
            Name = "UC_DeleteClient1";
            Size = new Size(798, 528);
            Load += UC_DeleteClient1_Load;
            ((System.ComponentModel.ISupportInitialize)PB_iamgeDelete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textAccountNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblAccountNumber;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox PB_iamgeDelete;
        private UC_CloseButton uC_CloseButton1;
    }
}
