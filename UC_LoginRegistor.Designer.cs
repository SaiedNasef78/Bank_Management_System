namespace Project_Bank_System_Level2
{
    partial class UC_LoginRegistor
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
            DGV_LoginRegistor = new Guna.UI2.WinForms.Guna2DataGridView();
            LblLoginRegistor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            uC_CloseButton1 = new UC_CloseButton();
            ((System.ComponentModel.ISupportInitialize)DGV_LoginRegistor).BeginInit();
            SuspendLayout();
            // 
            // DGV_LoginRegistor
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DGV_LoginRegistor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGV_LoginRegistor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGV_LoginRegistor.ColumnHeadersHeight = 40;
            DGV_LoginRegistor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGV_LoginRegistor.DefaultCellStyle = dataGridViewCellStyle3;
            DGV_LoginRegistor.GridColor = Color.FromArgb(231, 229, 255);
            DGV_LoginRegistor.Location = new Point(17, 108);
            DGV_LoginRegistor.Name = "DGV_LoginRegistor";
            DGV_LoginRegistor.ReadOnly = true;
            DGV_LoginRegistor.RowHeadersVisible = false;
            DGV_LoginRegistor.Size = new Size(684, 336);
            DGV_LoginRegistor.TabIndex = 0;
            DGV_LoginRegistor.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DGV_LoginRegistor.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            DGV_LoginRegistor.ThemeStyle.HeaderStyle.Height = 40;
            DGV_LoginRegistor.ThemeStyle.ReadOnly = true;
            DGV_LoginRegistor.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DGV_LoginRegistor.ThemeStyle.RowsStyle.Height = 25;
            // 
            // LblLoginRegistor
            // 
            LblLoginRegistor.BackColor = Color.Transparent;
            LblLoginRegistor.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLoginRegistor.ForeColor = Color.FromArgb(14, 93, 188);
            LblLoginRegistor.Location = new Point(261, 48);
            LblLoginRegistor.Name = "LblLoginRegistor";
            LblLoginRegistor.Size = new Size(185, 34);
            LblLoginRegistor.TabIndex = 1;
            LblLoginRegistor.Text = "Login Registors";
            // 
            // uC_CloseButton1
            // 
            uC_CloseButton1.AutoSize = true;
            uC_CloseButton1.Location = new Point(668, 0);
            uC_CloseButton1.MaximumSize = new Size(50, 45);
            uC_CloseButton1.MinimumSize = new Size(50, 50);
            uC_CloseButton1.Name = "uC_CloseButton1";
            uC_CloseButton1.Size = new Size(50, 50);
            uC_CloseButton1.TabIndex = 2;
            // 
            // UC_LoginRegistor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 197, 245);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(uC_CloseButton1);
            Controls.Add(LblLoginRegistor);
            Controls.Add(DGV_LoginRegistor);
            Name = "UC_LoginRegistor";
            Size = new Size(718, 463);
            Load += UC_LoginRegistor_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_LoginRegistor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DGV_LoginRegistor;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblLoginRegistor;
        private UC_CloseButton uC_CloseButton1;
    }
}
