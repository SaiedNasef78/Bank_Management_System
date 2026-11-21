namespace Project_Bank_System_Level2
{
    partial class UC_CloseButton
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
            btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.CheckedState.ImageSize = new Size(64, 64);
            btnClose.HoverState.ImageSize = new Size(64, 64);
            btnClose.Image = Properties.Resources.icons8_close_window_94;
            btnClose.ImageOffset = new Point(0, 0);
            btnClose.ImageRotate = 0F;
            btnClose.Location = new Point(5, 5);
            btnClose.Name = "btnClose";
            btnClose.PressedState.ImageSize = new Size(64, 64);
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 0;
            btnClose.Click += btnClose_Click;
            // 
            // UC_CloseButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(btnClose);
            MaximumSize = new Size(50, 45);
            MinimumSize = new Size(50, 50);
            Name = "UC_CloseButton";
            Size = new Size(50, 50);
            Load += UC_CloseButton_Load;
            Click += btnClose_Click;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
    }
}
