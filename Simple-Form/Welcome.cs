using System.Diagnostics.Eventing.Reader;

namespace Simple_Form
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void WelcomeBtn_Click(object sender, EventArgs e)
        {
            Login login = (Login)Application.OpenForms["Login"];
            if (login != null) 
            {
                login.Show();
                this.Close();
            }
            else
            {
                login = new Login();
                login.Show();
            }  
        }
    }
}
