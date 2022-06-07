namespace TableForTwo
{
    partial class ScheduleControl
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
            this.TableNumberLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.MembersLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TableNumberLabel
            // 
            this.TableNumberLabel.AutoSize = true;
            this.TableNumberLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TableNumberLabel.Location = new System.Drawing.Point(3, 47);
            this.TableNumberLabel.Name = "TableNumberLabel";
            this.TableNumberLabel.Size = new System.Drawing.Size(145, 33);
            this.TableNumberLabel.TabIndex = 1;
            this.TableNumberLabel.Text = "Table Number: ";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DateLabel.Location = new System.Drawing.Point(3, 2);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(209, 45);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "January 1, 2020";
            // 
            // MembersLabel
            // 
            this.MembersLabel.AutoSize = true;
            this.MembersLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MembersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MembersLabel.Location = new System.Drawing.Point(343, 47);
            this.MembersLabel.Name = "MembersLabel";
            this.MembersLabel.Size = new System.Drawing.Size(103, 33);
            this.MembersLabel.TabIndex = 3;
            this.MembersLabel.Text = "Members:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(808, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 82);
            this.button1.TabIndex = 4;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TimeLabel.Location = new System.Drawing.Point(343, 12);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(118, 33);
            this.TimeLabel.TabIndex = 5;
            this.TimeLabel.Text = "From # to #";
            // 
            // ScheduleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MembersLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TableNumberLabel);
            this.Name = "ScheduleControl";
            this.Size = new System.Drawing.Size(925, 88);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label TableNumberLabel;
        private Label DateLabel;
        private Label MembersLabel;
        private Button button1;
        private Label TimeLabel;
    }
}
