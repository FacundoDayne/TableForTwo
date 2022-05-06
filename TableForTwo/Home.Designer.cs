namespace TableForTwo
{
    partial class Home
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
            this.logo1 = new TableForTwo.Logo();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logo1
            // 
            this.logo1.Location = new System.Drawing.Point(328, 112);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(300, 300);
            this.logo1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(239, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 112);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table For Two?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(420, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Let\'s get you a seat";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcome.ForeColor = System.Drawing.Color.Maroon;
            this.welcome.Location = new System.Drawing.Point(75, 38);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(122, 20);
            this.welcome.TabIndex = 3;
            this.welcome.Text = "Welcome Mr/Ms ";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(977, 715);
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Logo logo1;
        private Label label1;
        private Label label2;
        private Label welcome;
    }
}
