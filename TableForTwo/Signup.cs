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
                label4.Show(); label13.Hide();
            }
            else if(Password.Text != Confirm.Text){
                label4.Hide();  label13.Show(); 
            }
            else
            {
                Sequel.addUser(FirstName.Text, LastName.Text, Contact.Text, Email.Text, Username.Text, Password.Text);                
                this.Hide();
            }
        }



        private void FirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(button1_Click);
            }
        }

        private void LastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(button1_Click);
            }
        }

       
        private void Contact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(button1_Click);
            }
        }

        private void Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(button1_Click);
            }
        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(button1_Click);
            }
        }
        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(button1_Click);
            }
        }
        private void Confirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Confirm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(button1_Click);
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            FirstName.Select();
        }
    }
}
