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
            tables1.Hide(); home1.Show(); book1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.SetBounds(4, 304, 10, 40);
            tables1.Show(); home1.Hide(); book1.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel2.SetBounds(4, 350, 10, 40);
            tables1.Hide(); home1.Hide(); book1.Show();
        }

        
    }
}
