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

        private void homeButton_Click(object sender, EventArgs e)
        {
            // Set Style
            homeButton.ForeColor = Color.Black;
            homeButton.BackgroundImage = Properties.Resources.Selected;

            bookAScheduleButton.ForeColor = Color.White;
            bookAScheduleButton.BackgroundImage = Properties.Resources.Unselected;

            mySchedulesButton.ForeColor = Color.White;
            mySchedulesButton.BackgroundImage = Properties.Resources.Unselected;

            homeTab.Show();
            scheduleTab.Hide();
            mySchedulesTab.Hide();
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            // Set Style
            homeButton.ForeColor = Color.White;
            homeButton.BackgroundImage = Properties.Resources.Unselected;

            bookAScheduleButton.ForeColor = Color.Black;
            bookAScheduleButton.BackgroundImage = Properties.Resources.Selected;

            mySchedulesButton.ForeColor = Color.White;
            mySchedulesButton.BackgroundImage = Properties.Resources.Unselected;

            homeTab.Hide();
            scheduleTab.Show();
            mySchedulesTab.Hide();
        }

        private void mySchedulesButton_Click(object sender, EventArgs e)
        {
            // Set Style
            homeButton.ForeColor = Color.White;
            homeButton.BackgroundImage = Properties.Resources.Unselected;

            bookAScheduleButton.ForeColor = Color.White;
            bookAScheduleButton.BackgroundImage = Properties.Resources.Unselected;

            mySchedulesButton.ForeColor = Color.Black;
            mySchedulesButton.BackgroundImage = Properties.Resources.Selected;

            homeTab.Hide();
            scheduleTab.Hide();
            mySchedulesTab.Show();

            mySchedulesTab.Reload();
        }

        private void mySchedulesTab_Load(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            UserInformation.ClearLoggedInUser();
            new Landing().Show();

            this.Hide();
        }
    }
}
