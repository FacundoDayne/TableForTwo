namespace TableForTwo
{
    public partial class Landing : Form
    {

        infos i = null;
        public Landing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            i = new infos();

            String email = textBox1.Text, pass = textBox2.Text;
            i.UserEmail = email; i.UserPassword = pass;

            //**************************  HAVE TO ADD A FUNCTION TO SEE WHETHER OR NOT THE EMAIL AND PASS ARE CORRECT ************************

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