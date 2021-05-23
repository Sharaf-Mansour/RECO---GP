
namespace RECO.Forms
{
    partial class KeyWords
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 414);
            this.panel1.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(286, 469);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(126, 42);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add Keyword +";
            this.Add.UseVisualStyleBackColor = true;
           // this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // KeyWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 518);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.panel1);
            this.Name = "KeyWords";
            this.Text = "KeyWords";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Add;
        //private System.Windows.Forms.Button button1;
    }
}