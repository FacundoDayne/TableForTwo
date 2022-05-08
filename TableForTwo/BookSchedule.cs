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
    public partial class BookSchedule : UserControl
    {
        public BookSchedule()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date < DateTime.Today.Date)
            {
                dateTimePicker1.Value = DateTime.Today;
                MessageBox.Show("Invalid Date", "Invalid Date", MessageBoxButtons.OK);
            }
            else if (dateTimePicker1.Value.Date == DateTime.Today.Date)
            {
                decrementDateButton.Enabled = false;
            }
            else
            {
                decrementDateButton.Enabled = true;
            }
        }

        private void decrementDateButton_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-1);
        }

        private void incrementDateButton_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
        }
    }
}
