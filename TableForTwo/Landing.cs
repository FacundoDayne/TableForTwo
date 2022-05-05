namespace TableForTwo
{
    public partial class Landing : Form
    {

        
        public Landing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            signup1.Show();
        }

        private void Landing_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}