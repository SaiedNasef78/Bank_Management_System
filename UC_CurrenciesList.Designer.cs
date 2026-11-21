namespace Project_Bank_System_Level2
{
    partial class UC_CurrenciesList
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
            DGV_CurrenciesList = new Guna.UI2.WinForms.Guna2DataGridView();
            LblCurrencies = new Guna.UI2.WinForms.Guna2HtmlLabel();
            PB_imageList = new Guna.UI2.WinForms.Guna2PictureBox();
            uC_CloseButton1 = new UC_CloseButton();
            ((System.ComponentModel.ISupportInitialize)DGV_CurrenciesList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_imageList).BeginInit();
            SuspendLayout();
            // 
            // DGV_CurrenciesList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DGV_CurrenciesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGV_CurrenciesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGV_CurrenciesList.ColumnHeadersHeight = 40;
            DGV_CurrenciesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGV_CurrenciesList.DefaultCellStyle = dataGridViewCellStyle3;
            DGV_CurrenciesList.GridColor = Color.FromArgb(231, 229, 255);
            DGV_CurrenciesList.Location = new Point(16, 97);
            DGV_CurrenciesList.Name = "DGV_CurrenciesList";
            DGV_CurrenciesList.ReadOnly = true;
            DGV_CurrenciesList.RowHeadersVisible = false;
            DGV_CurrenciesList.Size = new Size(699, 428);
            DGV_CurrenciesList.TabIndex = 0;
            DGV_CurrenciesList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DGV_CurrenciesList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            DGV_CurrenciesList.ThemeStyle.HeaderStyle.Height = 40;
            DGV_CurrenciesList.ThemeStyle.ReadOnly = true;
            DGV_CurrenciesList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DGV_CurrenciesList.ThemeStyle.RowsStyle.Height = 25;
            // 
            // LblCurrencies
            // 
            LblCurrencies.BackColor = Color.Transparent;
            LblCurrencies.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCurrencies.ForeColor = Color.FromArgb(14, 93, 188);
            LblCurrencies.Location = new Point(270, 36);
            LblCurrencies.Name = "LblCurrencies";
            LblCurrencies.Size = new Size(197, 39);
            LblCurrencies.TabIndex = 1;
            LblCurrencies.Text = "Currencies List";
            // 
            // PB_imageList
            // 
            PB_imageList.BackColor = Color.Transparent;
            PB_imageList.CustomizableEdges = customizableEdges1;
            PB_imageList.Image = Properties.Resources.icons8_bulleted_list_100;
            PB_imageList.ImageRotate = 0F;
            PB_imageList.Location = new Point(473, 16);
            PB_imageList.Name = "PB_imageList";
            PB_imageList.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PB_imageList.Size = new Size(79, 75);
            PB_imageList.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_imageList.TabIndex = 2;
            PB_imageList.TabStop = false;
            // 
            // uC_CloseButton1
            // 
            uC_CloseButton1.AutoSize = true;
            uC_CloseButton1.Location = new Point(655, 3);
            uC_CloseButton1.MaximumSize = new Size(50, 45);
            uC_CloseButton1.MinimumSize = new Size(50, 50);
            uC_CloseButton1.Name = "uC_CloseButton1";
            uC_CloseButton1.Size = new Size(50, 50);
            uC_CloseButton1.TabIndex = 3;
            // 
            // UC_CurrenciesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 197, 245);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(uC_CloseButton1);
            Controls.Add(PB_imageList);
            Controls.Add(LblCurrencies);
            Controls.Add(DGV_CurrenciesList);
            Name = "UC_CurrenciesList";
            Size = new Size(728, 548);
            Load += UC_CurrenciesList_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_CurrenciesList).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_imageList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DGV_CurrenciesList;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblCurrencies;
        private Guna.UI2.WinForms.Guna2PictureBox PB_imageList;
        private UC_CloseButton uC_CloseButton1;
    }
}
