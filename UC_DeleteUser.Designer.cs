namespace Project_Bank_System_Level2
{
    partial class UC_DeleteUser
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
            LblDeleteUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            textDelete = new Guna.UI2.WinForms.Guna2TextBox();
            LblUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnRemove = new Guna.UI2.WinForms.Guna2ImageButton();
            uC_CloseButton1 = new UC_CloseButton();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LblDeleteUser
            // 
            LblDeleteUser.BackColor = Color.Transparent;
            LblDeleteUser.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDeleteUser.ForeColor = Color.FromArgb(14, 93, 188);
            LblDeleteUser.Location = new Point(264, 53);
            LblDeleteUser.Name = "LblDeleteUser";
            LblDeleteUser.Size = new Size(161, 42);
            LblDeleteUser.TabIndex = 0;
            LblDeleteUser.Text = "Delete User";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = Properties.Resources.Delete;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(431, 43);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(71, 62);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 2;
            guna2PictureBox1.TabStop = false;
            // 
            // textDelete
            // 
            textDelete.BackColor = Color.Transparent;
            textDelete.BorderColor = Color.Silver;
            textDelete.BorderRadius = 10;
            textDelete.BorderThickness = 2;
            textDelete.CustomizableEdges = customizableEdges3;
            textDelete.DefaultText = "";
            textDelete.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textDelete.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textDelete.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textDelete.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textDelete.FillColor = Color.WhiteSmoke;
            textDelete.FocusedState.BorderColor = Color.FromArgb(192, 0, 0);
            textDelete.Font = new Font("Segoe UI", 9F);
            textDelete.ForeColor = Color.FromArgb(64, 64, 64);
            textDelete.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textDelete.Location = new Point(248, 186);
            textDelete.Name = "textDelete";
            textDelete.PlaceholderForeColor = Color.Gray;
            textDelete.PlaceholderText = "Enter UserName";
            textDelete.SelectedText = "";
            textDelete.ShadowDecoration.CustomizableEdges = customizableEdges4;
            textDelete.Size = new Size(270, 47);
            textDelete.TabIndex = 3;
            // 
            // LblUserName
            // 
            LblUserName.BackColor = Color.Transparent;
            LblUserName.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblUserName.Location = new Point(248, 155);
            LblUserName.Name = "LblUserName";
            LblUserName.Size = new Size(91, 25);
            LblUserName.TabIndex = 4;
            LblUserName.Text = "UserName";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Transparent;
            btnRemove.CheckedState.ImageSize = new Size(64, 64);
            btnRemove.HoverState.ImageSize = new Size(64, 64);
            btnRemove.Image = Properties.Resources.icons8_remove_96;
            btnRemove.ImageOffset = new Point(0, 0);
            btnRemove.ImageRotate = 0F;
            btnRemove.Location = new Point(524, 186);
            btnRemove.Name = "btnRemove";
            btnRemove.PressedState.ImageSize = new Size(64, 64);
            btnRemove.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnRemove.Size = new Size(51, 38);
            btnRemove.TabIndex = 5;
            btnRemove.Click += btnRemove_Click;
            // 
            // uC_CloseButton1
            // 
            uC_CloseButton1.AutoSize = true;
            uC_CloseButton1.Location = new Point(661, 3);
            uC_CloseButton1.MaximumSize = new Size(50, 45);
            uC_CloseButton1.MinimumSize = new Size(50, 50);
            uC_CloseButton1.Name = "uC_CloseButton1";
            uC_CloseButton1.Size = new Size(50, 50);
            uC_CloseButton1.TabIndex = 6;
            uC_CloseButton1.Load += uC_CloseButton1_Load;
            // 
            // UC_DeleteUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 197, 245);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(uC_CloseButton1);
            Controls.Add(btnRemove);
            Controls.Add(LblUserName);
            Controls.Add(textDelete);
            Controls.Add(guna2PictureBox1);
            Controls.Add(LblDeleteUser);
            Name = "UC_DeleteUser";
            Size = new Size(714, 510);
            Load += UC_DeleteUser_Load;
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel LblDeleteUser;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox textDelete;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblUserName;
        private Guna.UI2.WinForms.Guna2ImageButton btnRemove;
        private UC_CloseButton uC_CloseButton1;
    }
}
