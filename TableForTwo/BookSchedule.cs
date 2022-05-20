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
        private Panel? selectedTable;

        List<int> availableStartTime = new List<int>();
        List<int> availableEndTime = new List<int>();

        RadioButton? selectedStartTime;
        RadioButton? selectedEndTime;

        public BookSchedule()
        {
            InitializeComponent();

        }

        private void BookSchedule_Load(object sender, EventArgs e)
        {
            FormReset();
        }

        private void FetchAndRenderTime()
        {
            SetAvailableTimeDefault();

            List<ReservationInformation> reservations = Sequel.getReservationByDate(DatePicker.Value.Date);

            List<ReservationInformation> reservationsFromTable = new List<ReservationInformation>();

            if (selectedTable is null)
            {
                return;
            }
            

            foreach (ReservationInformation reservation in reservations)
            {

                if (GetTableNumber(selectedTable) != reservation.TableNumber)
                {
                    continue;
                }

                reservationsFromTable.Add(reservation);
            }

            reservationsFromTable.ForEach(delegate (ReservationInformation reservation)
            {
                for (int i = reservation.StartTime; i < reservation.EndTime; i++)
                {
                    availableStartTime.Remove(i);
                }

                for (int i = reservation.StartTime; i <= reservation.EndTime; i++)
                {
                    availableEndTime.Remove(i);
                }
            });

            RenderTime();
        }
        private void FormReset()
        {
            FetchAndRenderTime();

            if (selectedTable != null)
                SetTableAvailable(selectedTable);
            selectedTable = null;

            DatePicker.Value = DateTime.Today;

            MembersCapacity.Value = 1;

            startTimeGroupBox.Enabled = false;

            endTimeGroupBox.Enabled = false;

            DeselectSelectedTimes();
        }

        private void SetAvailableTimeDefault()
        {
            availableStartTime = new List<int>();
            availableEndTime = new List<int>();

            for (int i = 1; i <= 24; i++)
            {
                availableStartTime.Add(i);
                availableEndTime.Add(i);
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FetchAndRenderTime();

            if (DatePicker.Value.Date < DateTime.Today.Date)
            {
                DatePicker.Value = DateTime.Today;
                MessageBox.Show("Error", "The date selected is not available anymore.", MessageBoxButtons.OK);
            }
            else if (DatePicker.Value.Date == DateTime.Today.Date)
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
            DatePicker.Value = DatePicker.Value.AddDays(-1);
        }

        private void incrementDateButton_Click(object sender, EventArgs e)
        {
            DatePicker.Value = DatePicker.Value.AddDays(1);
        }

        private void TableClick(object sender, EventArgs e)
        {
            startTimeGroupBox.Enabled = true;
            endTimeGroupBox.Enabled = true;

            Panel clickedTable = (Panel)sender;

            if (clickedTable == selectedTable)
                return;


            if (selectedTable != null)
            {
                SetTableAvailable(selectedTable);
            }

            SetTableSelected(clickedTable);
            selectedTable = clickedTable;


            FetchAndRenderTime();

            RenderTime();
            DeselectSelectedTimes();
        }

        private void SetTableAvailable(Panel table)
        {
            table.Enabled = true;
            switch (GetTableCapacity(table))
            {
                case 2:
                    table.BackgroundImage = Properties.Resources.TableAvailable;
                    break;
                case 4:
                    table.BackgroundImage = Properties.Resources.TableFor4Available;
                    break;
            }
        }

        private void SetTableUnavailable(Panel table)
        {
            table.Enabled = false;
            switch (GetTableCapacity(table))
            {
                case 2:
                    table.BackgroundImage = Properties.Resources.TableUnavailable;
                    break;
                case 4:
                    table.BackgroundImage = Properties.Resources.TableFor4Unavailable;
                    break;
            }
        }

        private void SetTableSelected(Panel table)
        {
            table.Enabled = true;
            switch (GetTableCapacity(table))
            {
                case 2:
                    table.BackgroundImage = Properties.Resources.TableSelected;
                    break;
                case 4:
                    table.BackgroundImage = Properties.Resources.TableFor4Selected;
                    break;
            }
        }

        private Panel? GetTableByID(int ID)
        {
            TabPage selectedTab = tabControl1.SelectedTab;

            foreach(Control control in selectedTab.Controls)
            {
                if (control is Panel && GetTableNumber((Panel)control) == ID)
                {
                    return (Panel)control;
                }
            }

            return null;
        }

        private int GetTableCapacity(Panel table)
        {
            string tag = (string)table.Tag;
            return int.Parse(GetWordByIndex(tag, 0));
        }

        private int GetTableNumber(Panel table)
        {
            string tag = (string)table.Tag;

            return int.Parse(GetWordByIndex(tag, 1));
        }

        private string GetWordByIndex(string s, int index)
        {
            return s.Split(' ')[index];
        }

        private void ToggleTablesWithNCapacity(int capacity)
        {
            selectedTable = null;
            startTimeGroupBox.Enabled = false;
            endTimeGroupBox.Enabled = false;

            DeselectSelectedTimes();

            foreach (Control tabPage in tabControl1.Controls)
            {
                if (tabPage is not TabPage)
                    continue;
                
                foreach (Control panel in tabPage.Controls)
                {
                    if (panel is not Panel)
                        continue;

                    foreach (Control table in panel.Controls)
                    {
                        if (table is not Panel)
                            continue;

                        Panel table_ = (Panel)table;
                        if (GetTableCapacity(table_) <= capacity)
                            SetTableUnavailable(table_);
                        else
                            SetTableAvailable(table_);
                    }
                }
            }
        }

        private void MembersCapacityChanged(object sender, EventArgs e)
        {
            int newCapacity = ((int)((NumericUpDown)sender).Value);

            ToggleTablesWithNCapacity(newCapacity - 1);
        }

        private void RenderTime()
        {
            RenderStartTime();
            RenderEndTime();
        }

        private void RenderEndTime()
        {
            for (int i=1; i<=24; i++)
            {
                if (availableEndTime.Contains(i))
                {
                    ToggleEndTimeByTag(i, true);
                }
                else
                {
                    ToggleEndTimeByTag(i, false);
                }
            }
        }

        private void RenderStartTime()
        {
            for (int i = 1; i <= 24; i++)
            {
                if (availableStartTime.Contains(i))
                {
                    ToggleStartTimeByTag(i, true);
                }
                else
                {
                    ToggleStartTimeByTag(i, false);
                }
            }
        }

        private void StartTimeCheckChanged(object sender, EventArgs e)
        {
            RadioButton source = (RadioButton)sender;
            int time = int.Parse((string)source.Tag);

            RenderEndTime();

            if (!source.Checked)
                return;

            for (int i=1; i<=time; i++)
            {
                ToggleEndTimeByTag(i, false);
            }

            if (source.Checked)
                selectedStartTime = source;
        }

        private void EndTimeCheckChanged(object sender, EventArgs e)
        {
            RadioButton source = (RadioButton)sender;

            RenderStartTime();

            if (source.Checked)
                selectedEndTime = source;
            // ToggleStartTimeByTag(int.Parse((string)source.Tag), false);
        }

        private void DeselectSelectedTimes()
        {
            if (selectedStartTime is not null)
                selectedStartTime.Checked = false;

            if (selectedEndTime is not null)
                selectedEndTime.Checked = false;

            selectedStartTime = selectedEndTime = null;
        }

        private void AddReservatoinButton_Click(object sender, EventArgs e)
        {
            string username = UserInformation.GetLoggedInUser().Username;
            DateTime date = DatePicker.Value.Date;

            if (selectedTable is null)
            {
                MessageBox.Show("Please select a table.", "Unable to add reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int tableNumber = GetTableNumber(selectedTable);
            int members = (int)MembersCapacity.Value;

            if (selectedStartTime is null || selectedEndTime is null)
            {
                MessageBox.Show("Please select a time.", "Unable to add reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int startTime = int.Parse((string)selectedStartTime.Tag);
            int endTime = int.Parse((string)selectedEndTime.Tag);

            Sequel.addReservation(username, date, tableNumber, members, startTime, endTime);

            MessageBox.Show("Reservation Added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormReset();
        }


        private void ToggleStartTimeByTag(int tag, bool value)
        {
            foreach (Control radioButton in startTimeGroupBox.Controls)
            {
                if (radioButton is RadioButton && int.Parse((string)radioButton.Tag) == tag)
                { 
                    radioButton.Enabled = value;
                    if (!value)
                    {
                        ((RadioButton)radioButton).Checked = false;
                    }
                }
            }
        }

        private void ToggleEndTimeByTag(int tag, bool value)
        {
            foreach (Control radioButton in endTimeGroupBox.Controls)
            {
                if (radioButton is RadioButton && int.Parse((string)radioButton.Tag) == tag)
                {
                    radioButton.Enabled = value;

                    if (!value)
                    {
                        ((RadioButton)radioButton).Checked = false;
                    }
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            FormReset();
        }
    }
}
