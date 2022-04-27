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
            this.signup1 = new TableForTwo.Signup();
            this.tables1 = new TableForTwo.Tables();
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
            // signup1
            // 
            this.signup1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signup1.Location = new System.Drawing.Point(-3, 1);
            this.signup1.Name = "signup1";
            this.signup1.Size = new System.Drawing.Size(1290, 751);
            this.signup1.TabIndex = 1;
            this.signup1.Visible = false;
            // 
            // tables1
            // 
            this.tables1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tables1.Location = new System.Drawing.Point(0, 0);
            this.tables1.Name = "tables1";
            this.tables1.Size = new System.Drawing.Size(1290, 751);
            this.tables1.TabIndex = 2;
            this.tables1.Visible = false;
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1274, 745);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.signup1);
            this.Controls.Add(this.tables1);
            this.MaximumSize = new System.Drawing.Size(1290, 784);
            this.MinimumSize = new System.Drawing.Size(1290, 784);
            this.Name = "Landing";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Login login1;
        private Signup signup1;
        private Tables tables1;
    }
}