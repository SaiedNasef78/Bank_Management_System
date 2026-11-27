namespace Project_Bank_System_Level2
{
    partial class UC_UsersList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DGV_UsersList = new Guna.UI2.WinForms.Guna2DataGridView();
            LblUsersList = new Guna.UI2.WinForms.Guna2HtmlLabel();
            PB_ImageUsersList = new Guna.UI2.WinForms.Guna2PictureBox();
            uC_CloseButton1 = new UC_CloseButton();
            ((System.ComponentModel.ISupportInitialize)DGV_UsersList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_ImageUsersList).BeginInit();
            SuspendLayout();
            // 
            // DGV_UsersList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DGV_UsersList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGV_UsersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGV_UsersList.ColumnHeadersHeight = 40;
            DGV_UsersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGV_UsersList.DefaultCellStyle = dataGridViewCellStyle3;
            DGV_UsersList.GridColor = Color.FromArgb(231, 229, 255);
            DGV_UsersList.Location = new Point(16, 113);
            DGV_UsersList.Name = "DGV_UsersList";
            DGV_UsersList.ReadOnly = true;
            DGV_UsersList.RowHeadersVisible = false;
            DGV_UsersList.Size = new Size(680, 330);
            DGV_UsersList.TabIndex = 0;
            DGV_UsersList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DGV_UsersList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            DGV_UsersList.ThemeStyle.HeaderStyle.Height = 40;
            DGV_UsersList.ThemeStyle.ReadOnly = true;
            DGV_UsersList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DGV_UsersList.ThemeStyle.RowsStyle.Height = 25;
            // 
            // LblUsersList
            // 
            LblUsersList.BackColor = Color.Transparent;
            LblUsersList.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblUsersList.ForeColor = Color.FromArgb(14, 93, 188);
            LblUsersList.Location = new Point(270, 36);
            LblUsersList.Name = "LblUsersList";
            LblUsersList.Size = new Size(131, 39);
            LblUsersList.TabIndex = 1;
            LblUsersList.Text = "Users List";
            // 
            // PB_ImageUsersList
            // 
            PB_ImageUsersList.BackColor = Color.Transparent;
            PB_ImageUsersList.CustomizableEdges = customizableEdges1;
            PB_ImageUsersList.Image = Properties.Resources.UsersList;
            PB_ImageUsersList.ImageRotate = 0F;
            PB_ImageUsersList.Location = new Point(407, 22);
            PB_ImageUsersList.Name = "PB_ImageUsersList";
            PB_ImageUsersList.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PB_ImageUsersList.Size = new Size(96, 71);
            PB_ImageUsersList.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_ImageUsersList.TabIndex = 2;
            PB_ImageUsersList.TabStop = false;
            // 
            // uC_CloseButton1
            // 
            uC_CloseButton1.AutoSize = true;
            uC_CloseButton1.Location = new Point(666, 0);
            uC_CloseButton1.MaximumSize = new Size(50, 45);
            uC_CloseButton1.MinimumSize = new Size(50, 50);
            uC_CloseButton1.Name = "uC_CloseButton1";
            uC_CloseButton1.Size = new Size(50, 50);
            uC_CloseButton1.TabIndex = 3;
            uC_CloseButton1.Load += uC_CloseButton1_Load;
            // 
            // UC_UsersList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 197, 245);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(uC_CloseButton1);
            Controls.Add(PB_ImageUsersList);
            Controls.Add(LblUsersList);
            Controls.Add(DGV_UsersList);
            Name = "UC_UsersList";
            Size = new Size(719, 472);
            Load += UC_UsersList_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_UsersList).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_ImageUsersList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DGV_UsersList;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblUsersList;
        private Guna.UI2.WinForms.Guna2PictureBox PB_ImageUsersList;
        private UC_CloseButton uC_CloseButton1;
    }
}
