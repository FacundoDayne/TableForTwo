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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.SetBounds(4, 258, 10, 40);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.SetBounds(4, 304, 10, 40);
        }


        private void return1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Landing l = new Landing();
            l.Show();
        }

        private void return1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.IndianRed;
        }

        private void return1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Firebrick;
        }

    }
}
