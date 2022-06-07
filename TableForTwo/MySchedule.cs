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
    public partial class MySchedule : UserControl
    {
        public MySchedule()
        {
            InitializeComponent();
        }

        private void MySchedule_Load(object sender, EventArgs e)
        {

        }

        public void Reload()
        {
            flowLayoutPanel1.Controls.Clear();

            string username = UserInformation.GetLoggedInUser().Username;

            List<ReservationInformation> reservations = Sequel.getReservationByUsername(username);

            reservations.ForEach(delegate (ReservationInformation reservation)
            {
                ScheduleControl scheduleControl = new ScheduleControl();
                scheduleControl.Init(
                                    reservation.ID,
                                    reservation.UserName,
                                    reservation.Date,
                                    reservation.TableNumber,
                                    reservation.Members,
                                    reservation.StartTime,
                                    reservation.EndTime);
                scheduleControl.Render();

                flowLayoutPanel1.Controls.Add(scheduleControl);
            });
        }
    }
}
