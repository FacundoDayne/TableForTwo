using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableForTwo
{
    public partial class Signup : UserControl
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sequel Sequel = new Sequel();
            if (Username.Text == ""|| Password.Text == "" || Confirm.Text == "" || 
                Username.Text == " " || Password.Text == " " || Confirm.Text == " ")
            {
                label4.Show(); label13.Hide(); label14.Hide();
            }
            else if(Password.Text != Confirm.Text){
                label4.Hide();  label13.Show(); label14.Hide();
            }
            else
            {
                if (!Sequel.checkUsername(Username.Text.Trim()))
                {
                    Sequel.addUser(FirstName.Text, LastName.Text, Contact.Text, Email.Text, Username.Text, Password.Text);
                    this.Hide();
                }
                else
                {
                    label4.Hide(); label13.Hide(); label14.Show();
                }
            }
        }



        private void FirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
                //this.FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(button1_Click);
            }
        }

        private void LastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
                //this.FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(button1_Click);
            }
        }

       
        private void Contact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
                //this.FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(button1_Click);
            }
        }

        private void Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
                //this.FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(button1_Click);
            }
        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
                //this.FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(button1_Click);
            }
        }
        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
                //this.FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(button1_Click);
            }
        }
        private void Confirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
                //this.FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(button1_Click);
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            FirstName.Select();
        }
    }
}
