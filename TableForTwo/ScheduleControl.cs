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
    public partial class ScheduleControl : UserControl
    {

        ReservationInformation information;

        public ScheduleControl()
        {
            InitializeComponent();
        }

        public void Init(int ID, string username, DateTime date, int tableNumber, int members, int startTime, int endTime)
        {
            this.information = new ReservationInformation(username, date, tableNumber, members, startTime, endTime);
            this.information.ID = ID;
        }

        public void Render()
        {
            DateLabel.Text = information.Date.ToString("MMMM dd, yyyy");

            int from = information.StartTime;
            int to = information.EndTime;

            string _from, _to;

            if (from > 11 && from < 24)
            {
                if (from == 12)
                {

                    _from = from.ToString() + " PM";
                }
                else
                {
                    _from = (from - 12).ToString() + " PM";
                }
            }
            else
            {
                if (from == 24)
                {
                    _from = (from - 12).ToString() + " AM";
                }
                else
                {
                    _from = from.ToString() + " AM";
                }
            }

            if (to > 11 && to < 24)
            {
                if (to == 12)
                {
                    _to = to.ToString() + " PM";
                }
                else
                {
                    _to = (to - 12).ToString() + " PM";
                }
            }
            else
            {
                if (to == 24)
                {
                    _to = (to - 12).ToString() + " AM";
                }
                else
                {
                    _to = to.ToString() + " AM";
                }
            }


            TimeLabel.Text = $"From {_from} to {_to}";

            TableNumberLabel.Text = $"Table Number: {information.TableNumber}";

            MembersLabel.Text = $"Members: {information.Members}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Delete this entry?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (response == DialogResult.No)
                return;

            this.Parent.Controls.Remove(this);
            Sequel.removeRegistration(this.information.ID);
        }
    }
}
