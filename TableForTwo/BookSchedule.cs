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

        public BookSchedule()
        {
            InitializeComponent();
        }

        private void BookSchedule_Load(object sender, EventArgs e)
        {
            SetAvailableTimeDefault();
        }

        private void SetAvailableTimeDefault()
        {
            for (int i = 1; i <= 24; i++)
            {
                availableStartTime.Add(i);
                availableEndTime.Add(i);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date < DateTime.Today.Date)
            {
                dateTimePicker1.Value = DateTime.Today;
                MessageBox.Show("Error", "The date selected is not available anymore.", MessageBoxButtons.OK);
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

        private void SetTableAvailable(Panel table)
        {
            if (table.Tag.Equals("2"))
            {
                table.BackgroundImage = Properties.Resources.TableAvailable;
            }
            else if (table.Tag.Equals("4"))
            {
                table.BackgroundImage = Properties.Resources.TableFor4Available;
            }

            table.Enabled = true;
        }

        private void SetTableSelected(Panel table)
        {
            if (table.Tag.Equals("2"))
            {
                table.BackgroundImage = Properties.Resources.TableSelected;
            }
            else if (table.Tag.Equals("4"))
            {
                table.BackgroundImage = Properties.Resources.TableFor4Selected;
            }
            
            selectedTable = table;
            table.Enabled = true;
        }

        private void SetTableUnavailable(Panel table)
        {
            if (table.Tag.Equals("2"))
            {
                table.BackgroundImage = Properties.Resources.TableUnavailable;
            }
            else if (table.Tag.Equals("4"))
            {
                table.BackgroundImage = Properties.Resources.TableFor4Unavailable;
            }

            table.Enabled = false;
        }

        private void TableFor2Click(object sender, EventArgs e)
        {
            if (!((Panel)sender).Enabled)
                return;

            if (selectedTable != null)
                SetTableAvailable(selectedTable);

            Panel table = (Panel)sender;
            SetTableSelected(table);
        }

        private void TableFor4Click(object sender, EventArgs e)
        {
            if (!((Panel)sender).Enabled)
                return;

            if (selectedTable != null)
                SetTableAvailable(selectedTable);

            Panel table = (Panel)sender;
            SetTableSelected(table);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            selectedTable = null;

            if (((NumericUpDown)sender).Value <= 2)
            {
                SetTableFor2Available();
                SetTableFor4Available();
            }
            else if (((NumericUpDown)sender).Value <= 4)
            {
                SetTableFor2Unavailable();
                SetTableFor4Available();
            }
            else
            {
                SetTableFor2Unavailable();
                SetTableFor4Unavailable();
            }
        }

        private void SetTableFor2Available()
        {
            foreach (Control table in tableContainer.Controls)
            {
                if (table is Panel && table.Tag.Equals("2"))
                {
                    SetTableAvailable((Panel)table);
                }
            }
        }
        private void SetTableFor2Unavailable()
        {
            foreach (Control table in tableContainer.Controls)
            {
                if (table is Panel && table.Tag.Equals("2"))
                {
                    SetTableUnavailable((Panel)table);
                }
            }
        }
        private void SetTableFor4Available()
        {
            foreach (Control table in tableContainer.Controls)
            {
                if (table is Panel && table.Tag.Equals("4"))
                {
                    SetTableAvailable((Panel)table);
                }
            }
        }
        private void SetTableFor4Unavailable()
        {
            foreach (Control table in tableContainer.Controls)
            {
                if (table is Panel && table.Tag.Equals("4"))
                {
                    SetTableUnavailable((Panel)table);
                }
            }
        }

        private void StartTimeCheckChanged(object sender, EventArgs e)
        {
            RadioButton source = (RadioButton)sender;
            string tag = (string)source.Tag;

            if (source.Checked)
            {
                DisableEndTimeRadioButtonByTag(tag); 
            }
            else
            {
                if (availableEndTime.Contains(int.Parse(tag)))
                {
                    EnableEndTimeRadioButtonByTag(tag);
                }
            }

            endTimeGroupBox.Enabled = true;
        }

        private void EndTimeCheckChanged(object sender, EventArgs e)
        {
            RadioButton source = (RadioButton)sender;
            string tag = (string)source.Tag;

            if (source.Checked)
            {
                DisableStartTimeRadioButtonByTag(tag);
            }
            else
            {
                if (availableEndTime.Contains(int.Parse(tag)))
                {
                    EnableStartTimeRadioButtonByTag(tag);
                }
            }
        }

        private void DisableStartTimeRadioButtonByTag(string tag)
        {
            foreach (Control timeCheckBox in startTimeGroupBox.Controls)
            {
                if (timeCheckBox is RadioButton && timeCheckBox.Tag.Equals(tag))
                {
                    ((RadioButton)timeCheckBox).Checked = false;
                    timeCheckBox.Enabled = false;
                }
            }
        }

        private void EnableStartTimeRadioButtonByTag(string tag)
        {
            foreach (Control timeCheckBox in startTimeGroupBox.Controls)
            {
                if (timeCheckBox is RadioButton && timeCheckBox.Tag.Equals(tag))
                {
                    timeCheckBox.Enabled = true;
                }
            }
        }

        private void DisableEndTimeRadioButtonByTag(string tag)
        {
            foreach (Control timeCheckBox in endTimeGroupBox.Controls)
            {
                if (timeCheckBox is RadioButton && timeCheckBox.Tag.Equals(tag))
                {
                    ((RadioButton)timeCheckBox).Checked = false;
                    timeCheckBox.Enabled = false;
                }
            }
        }

        private void EnableEndTimeRadioButtonByTag(string tag)
        {
            foreach (Control timeCheckBox in endTimeGroupBox.Controls)
            {
                if (timeCheckBox is RadioButton && timeCheckBox.Tag.Equals(tag))
                {
                    timeCheckBox.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tag = numericUpDown1.Value.ToString();

            DisableEndTimeRadioButtonByTag(tag);
        }
    }
}
