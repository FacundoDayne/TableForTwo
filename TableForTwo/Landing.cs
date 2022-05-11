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

            if (email != "tite")
            {
                UserInformation CurrentUser = new UserInformation(email, pass);
                UserInformation.SetLoggedInUser(CurrentUser);
                this.Hide();
                Main m = new Main();
                m.Show();
            }

            else
            {
                label4.Show();textBox1.Clear(); textBox2.Clear();
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

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(button1_Click);
            }
        }

        private void Landing_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }
    }
}