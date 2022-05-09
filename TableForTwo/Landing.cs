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
            
            String email = textBox1.Text, pass = textBox2.Text;

            //**************************  HAVE TO ADD A FUNCTION TO SEE WHETHER OR NOT THE EMAIL AND PASS ARE CORRECT ************************

            Boolean placeholder = true;

            if (placeholder)
            {
                UserInformation CurrentUser = new UserInformation(email, pass);
                UserInformation.SetLoggedInUser(CurrentUser);
                this.Hide();
                Main m = new Main();
                m.Show();
            }

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