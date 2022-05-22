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
            label4.Hide();
            Sequel Sequel = new Sequel();
            String user = textBox1.Text, pass = textBox2.Text;

            //**************************  HAVE TO ADD A FUNCTION TO SEE WHETHER OR NOT THE EMAIL AND PASS ARE CORRECT ************************

            Boolean placeholder = true;

            if (user != "" || user != " ")
            {

                bool UserIsGood = Sequel.checkUsername(user);
                if (UserIsGood)
                {
                    bool PassIsGood = Sequel.checkPassword(pass);
                    if(PassIsGood)
                    {
                        UserInformation CurrentUser = new UserInformation(user, pass);
                        UserInformation.SetLoggedInUser(CurrentUser);
                        this.Hide();
                        Main m = new Main();
                        m.Show();
                    }
                }
                else
                {
                    label4.Show(); textBox2.Clear();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            signup1.Show();
            label4.Hide();
        }

        private void Landing_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            Keys keys = e.KeyCode;
            if (keys == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void Landing_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }
    }
}