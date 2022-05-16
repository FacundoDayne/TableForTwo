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
    public partial class Home : UserControl
    {
        UserInformation loggedInUser = UserInformation.GetLoggedInUser();
        
        
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            string email = loggedInUser.Username;
            welcome.Text = welcome.Text + email;
        }
    }
}
