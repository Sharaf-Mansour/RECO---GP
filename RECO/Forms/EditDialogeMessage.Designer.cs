
namespace RECO.Forms
{
    partial class EditDialogeMessage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RenameRepoTxtBox = new System.Windows.Forms.TextBox();
            this.NewRepoLbl = new System.Windows.Forms.Label();
            this.EditBtn = new FontAwesome.Sharp.IconButton();
            this.CancelBtn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // RenameRepoTxtBox
            // 
            this.RenameRepoTxtBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.RenameRepoTxtBox.ForeColor = System.Drawing.Color.White;
            this.RenameRepoTxtBox.Location = new System.Drawing.Point(235, 34);
            this.RenameRepoTxtBox.MaxLength = 40;
            this.RenameRepoTxtBox.Name = "RenameRepoTxtBox";
            this.RenameRepoTxtBox.Size = new System.Drawing.Size(261, 23);
            this.RenameRepoTxtBox.TabIndex = 0;
            this.RenameRepoTxtBox.Click += new System.EventHandler(this.RenameRepoTxtBox_Click);
            // 
            // NewRepoLbl
            // 
            this.NewRepoLbl.AutoSize = true;
            this.NewRepoLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewRepoLbl.ForeColor = System.Drawing.Color.White;
            this.NewRepoLbl.Location = new System.Drawing.Point(22, 32);
            this.NewRepoLbl.Name = "NewRepoLbl";
            this.NewRepoLbl.Size = new System.Drawing.Size(182, 21);
            this.NewRepoLbl.TabIndex = 1;
            this.NewRepoLbl.Text = "New Repository Name";
            // 
            // EditBtn
            // 
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.EditBtn.IconColor = System.Drawing.Color.White;
            this.EditBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditBtn.IconSize = 30;
            this.EditBtn.Location = new System.Drawing.Point(310, 127);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(90, 37);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Edit";
            this.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.EditBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.CancelBtn.IconColor = System.Drawing.Color.White;
            this.CancelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelBtn.IconSize = 30;
            this.CancelBtn.Location = new System.Drawing.Point(91, 127);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(94, 37);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // EditDialogeMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(523, 191);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.NewRepoLbl);
            this.Controls.Add(this.RenameRepoTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditDialogeMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditDialogeMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NewRepoLbl;
        public System.Windows.Forms.TextBox RenameRepoTxtBox;
        public FontAwesome.Sharp.IconButton EditBtn;
        public FontAwesome.Sharp.IconButton CancelBtn;
    }
}