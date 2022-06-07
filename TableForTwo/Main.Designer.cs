namespace TableForTwo
{
    partial class Main
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
            this.mySchedulesButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logo1 = new TableForTwo.Logo();
            this.bookAScheduleButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.homeTab = new TableForTwo.Home();
            this.scheduleTab = new TableForTwo.BookSchedule();
            this.mySchedulesTab = new TableForTwo.MySchedule();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.mySchedulesButton);
            this.panel1.Controls.Add(this.logoPanel);
            this.panel1.Controls.Add(this.logo1);
            this.panel1.Controls.Add(this.bookAScheduleButton);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 715);
            this.panel1.TabIndex = 0;
            // 
            // mySchedulesButton
            // 
            this.mySchedulesButton.BackColor = System.Drawing.Color.Maroon;
            this.mySchedulesButton.BackgroundImage = global::TableForTwo.Properties.Resources.Unselected;
            this.mySchedulesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mySchedulesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mySchedulesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.mySchedulesButton.FlatAppearance.BorderSize = 0;
            this.mySchedulesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mySchedulesButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mySchedulesButton.ForeColor = System.Drawing.Color.White;
            this.mySchedulesButton.Location = new System.Drawing.Point(7, 289);
            this.mySchedulesButton.Name = "mySchedulesButton";
            this.mySchedulesButton.Size = new System.Drawing.Size(292, 40);
            this.mySchedulesButton.TabIndex = 7;
            this.mySchedulesButton.Text = "MY SCHEDULES";
            this.mySchedulesButton.UseVisualStyleBackColor = false;
            this.mySchedulesButton.Click += new System.EventHandler(this.mySchedulesButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackgroundImage = global::TableForTwo.Properties.Resources.Logo;
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPanel.Location = new System.Drawing.Point(12, 12);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(275, 160);
            this.logoPanel.TabIndex = 6;
            // 
            // logo1
            // 
            this.logo1.Location = new System.Drawing.Point(55, 449);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(200, 200);
            this.logo1.TabIndex = 4;
            // 
            // bookAScheduleButton
            // 
            this.bookAScheduleButton.BackColor = System.Drawing.Color.Maroon;
            this.bookAScheduleButton.BackgroundImage = global::TableForTwo.Properties.Resources.Unselected;
            this.bookAScheduleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bookAScheduleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookAScheduleButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bookAScheduleButton.FlatAppearance.BorderSize = 0;
            this.bookAScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookAScheduleButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookAScheduleButton.ForeColor = System.Drawing.Color.White;
            this.bookAScheduleButton.Location = new System.Drawing.Point(7, 243);
            this.bookAScheduleButton.Name = "bookAScheduleButton";
            this.bookAScheduleButton.Size = new System.Drawing.Size(292, 40);
            this.bookAScheduleButton.TabIndex = 2;
            this.bookAScheduleButton.Text = "BOOK A SCHEDULE";
            this.bookAScheduleButton.UseVisualStyleBackColor = false;
            this.bookAScheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Maroon;
            this.homeButton.BackgroundImage = global::TableForTwo.Properties.Resources.Selected;
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeButton.ForeColor = System.Drawing.Color.Black;
            this.homeButton.Location = new System.Drawing.Point(7, 197);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(292, 40);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "HOME";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // homeTab
            // 
            this.homeTab.BackColor = System.Drawing.Color.White;
            this.homeTab.Location = new System.Drawing.Point(300, 0);
            this.homeTab.Name = "homeTab";
            this.homeTab.Size = new System.Drawing.Size(958, 711);
            this.homeTab.TabIndex = 1;
            // 
            // scheduleTab
            // 
            this.scheduleTab.BackColor = System.Drawing.Color.White;
            this.scheduleTab.Location = new System.Drawing.Point(300, 0);
            this.scheduleTab.Name = "scheduleTab";
            this.scheduleTab.Size = new System.Drawing.Size(958, 711);
            this.scheduleTab.TabIndex = 2;
            this.scheduleTab.Visible = false;
            // 
            // mySchedulesTab
            // 
            this.mySchedulesTab.BackColor = System.Drawing.Color.White;
            this.mySchedulesTab.Location = new System.Drawing.Point(300, 0);
            this.mySchedulesTab.Name = "mySchedulesTab";
            this.mySchedulesTab.Size = new System.Drawing.Size(958, 711);
            this.mySchedulesTab.TabIndex = 3;
            this.mySchedulesTab.Visible = false;
            this.mySchedulesTab.Load += new System.EventHandler(this.mySchedulesTab_Load);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1256, 712);
            this.Controls.Add(this.mySchedulesTab);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.homeTab);
            this.Controls.Add(this.scheduleTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button homeButton;
        private Button bookAScheduleButton;
        private Home homeTab;
        private BookSchedule scheduleTab;
        private Logo logo1;
        private Panel logoPanel;
        private Button mySchedulesButton;
        private MySchedule mySchedulesTab;
    }
}