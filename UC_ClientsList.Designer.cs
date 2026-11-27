namespace Project_Bank_System_Level2
{
    partial class UC_ClientsList
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
            dataGridViewAllClinet = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            PB_ClientsList = new Guna.UI2.WinForms.Guna2PictureBox();
            uC_CloseButton1 = new UC_CloseButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllClinet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_ClientsList).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAllClinet
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewAllClinet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAllClinet.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewAllClinet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAllClinet.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewAllClinet.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewAllClinet.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewAllClinet.Location = new Point(12, 120);
            dataGridViewAllClinet.Name = "dataGridViewAllClinet";
            dataGridViewAllClinet.ReadOnly = true;
            dataGridViewAllClinet.RowHeadersVisible = false;
            dataGridViewAllClinet.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewAllClinet.RowTemplate.Height = 30;
            dataGridViewAllClinet.Size = new Size(757, 300);
            dataGridViewAllClinet.TabIndex = 0;
            dataGridViewAllClinet.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridViewAllClinet.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewAllClinet.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewAllClinet.ThemeStyle.HeaderStyle.Height = 40;
            dataGridViewAllClinet.ThemeStyle.ReadOnly = true;
            dataGridViewAllClinet.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewAllClinet.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dataGridViewAllClinet.ThemeStyle.RowsStyle.Height = 30;
            dataGridViewAllClinet.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewAllClinet.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            dataGridViewAllClinet.CellContentClick += dataGridViewAllClinet_CellContentClick;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(14, 93, 188);
            guna2HtmlLabel1.Location = new Point(252, 62);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(158, 42);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Clients List";
            // 
            // PB_ClientsList
            // 
            PB_ClientsList.BackColor = Color.Transparent;
            PB_ClientsList.CustomizableEdges = customizableEdges1;
            PB_ClientsList.Image = Properties.Resources.UsersList;
            PB_ClientsList.ImageRotate = 0F;
            PB_ClientsList.Location = new Point(416, 32);
            PB_ClientsList.Name = "PB_ClientsList";
            PB_ClientsList.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PB_ClientsList.Size = new Size(109, 82);
            PB_ClientsList.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_ClientsList.TabIndex = 2;
            PB_ClientsList.TabStop = false;
            // 
            // uC_CloseButton1
            // 
            uC_CloseButton1.AutoSize = true;
            uC_CloseButton1.Location = new Point(665, 3);
            uC_CloseButton1.MaximumSize = new Size(50, 45);
            uC_CloseButton1.MinimumSize = new Size(50, 50);
            uC_CloseButton1.Name = "uC_CloseButton1";
            uC_CloseButton1.Size = new Size(50, 50);
            uC_CloseButton1.TabIndex = 3;
            // 
            // UC_ClientsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 197, 245);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(uC_CloseButton1);
            Controls.Add(PB_ClientsList);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(dataGridViewAllClinet);
            Name = "UC_ClientsList";
            Size = new Size(772, 483);
            Load += UC_ClientsList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllClinet).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_ClientsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewAllClinet;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox PB_ClientsList;
        private UC_CloseButton uC_CloseButton1;
    }
}
