using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Form
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            passwordtxt.PasswordChar = '*';
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = usertxt.Text;
            string password = passwordtxt.Text;

            
            if (username == "lecturer" && password == "password123")
            {
                
                Paper packetForm = new Paper();
                packetForm.Show();
                this.Close(); 
            }
            else if (username == "hod" && password == "password123")
            {
                
                Portal portalForm = new Portal();
                portalForm.Show();
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }
    }
}
