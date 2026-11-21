namespace Project_Bank_System_Level2
{
    partial class UC_TransferLog
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
            DGVTransferLog = new Guna.UI2.WinForms.Guna2DataGridView();
            LblTransferLog = new Guna.UI2.WinForms.Guna2HtmlLabel();
            PB_ImageTransferLog = new Guna.UI2.WinForms.Guna2PictureBox();
            uC_CloseButton1 = new UC_CloseButton();
            ((System.ComponentModel.ISupportInitialize)DGVTransferLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_ImageTransferLog).BeginInit();
            SuspendLayout();
            // 
            // DGVTransferLog
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DGVTransferLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVTransferLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVTransferLog.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGVTransferLog.DefaultCellStyle = dataGridViewCellStyle3;
            DGVTransferLog.GridColor = Color.FromArgb(231, 229, 255);
            DGVTransferLog.Location = new Point(17, 143);
            DGVTransferLog.Name = "DGVTransferLog";
            DGVTransferLog.RowHeadersVisible = false;
            DGVTransferLog.Size = new Size(735, 336);
            DGVTransferLog.TabIndex = 1;
            DGVTransferLog.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DGVTransferLog.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            DGVTransferLog.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGVTransferLog.ThemeStyle.HeaderStyle.Height = 40;
            DGVTransferLog.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DGVTransferLog.ThemeStyle.RowsStyle.Height = 25;
            DGVTransferLog.CellContentClick += DGVTransferLog_CellContentClick;
            // 
            // LblTransferLog
            // 
            LblTransferLog.BackColor = Color.Transparent;
            LblTransferLog.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTransferLog.ForeColor = Color.FromArgb(14, 93, 188);
            LblTransferLog.Location = new Point(298, 52);
            LblTransferLog.Name = "LblTransferLog";
            LblTransferLog.Size = new Size(173, 39);
            LblTransferLog.TabIndex = 2;
            LblTransferLog.Text = "Transfer Log";
            // 
            // PB_ImageTransferLog
            // 
            PB_ImageTransferLog.BackColor = Color.Transparent;
            PB_ImageTransferLog.CustomizableEdges = customizableEdges1;
            PB_ImageTransferLog.Image = Properties.Resources.Transfer;
            PB_ImageTransferLog.ImageRotate = 0F;
            PB_ImageTransferLog.Location = new Point(466, 42);
            PB_ImageTransferLog.Name = "PB_ImageTransferLog";
            PB_ImageTransferLog.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PB_ImageTransferLog.Size = new Size(86, 72);
            PB_ImageTransferLog.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_ImageTransferLog.TabIndex = 3;
            PB_ImageTransferLog.TabStop = false;
            // 
            // uC_CloseButton1
            // 
            uC_CloseButton1.AutoSize = true;
            uC_CloseButton1.Location = new Point(672, 3);
            uC_CloseButton1.MaximumSize = new Size(50, 45);
            uC_CloseButton1.MinimumSize = new Size(50, 50);
            uC_CloseButton1.Name = "uC_CloseButton1";
            uC_CloseButton1.Size = new Size(50, 50);
            uC_CloseButton1.TabIndex = 4;
            uC_CloseButton1.Load += uC_CloseButton1_Load;
            // 
            // UC_TransferLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 197, 245);
            Controls.Add(uC_CloseButton1);
            Controls.Add(PB_ImageTransferLog);
            Controls.Add(LblTransferLog);
            Controls.Add(DGVTransferLog);
            Name = "UC_TransferLog";
            Size = new Size(785, 518);
            Load += UC_TransferLog_Load;
            ((System.ComponentModel.ISupportInitialize)DGVTransferLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_ImageTransferLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView DGVTransferLog;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblTransferLog;
        private Guna.UI2.WinForms.Guna2PictureBox PB_ImageTransferLog;
        private UC_CloseButton uC_CloseButton1;
    }
}
