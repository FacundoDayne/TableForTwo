namespace TableForTwo
{
    partial class Landing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login1 = new TableForTwo.Login();
            this.SuspendLayout();
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.login1.Location = new System.Drawing.Point(-3, 0);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(1286, 752);
            this.login1.TabIndex = 0;
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1274, 745);
            this.Controls.Add(this.login1);
            this.MaximumSize = new System.Drawing.Size(1290, 784);
            this.MinimumSize = new System.Drawing.Size(1290, 784);
            this.Name = "Landing";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Login login1;
    }
}