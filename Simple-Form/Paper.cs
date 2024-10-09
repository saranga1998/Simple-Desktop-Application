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
    public partial class Paper : Form
    {
        public Paper()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Details details = new Details();
                //AddDetails(details);
                //Portal portal = new Portal(details);
                Portal portal = new Portal();
                portal.Show();
            }
            catch(Exception ex) {
                MessageBox.Show("Error !",ex.Message);
            }
        }

        private void AddDetails(Details details)
        {
            details.LectureName = NamecomboBox.SelectedItem?.ToString();
            details.CourseTitle = codetxt.Text;
            details.CourseCode = codetxt.Text;
            details.ReceivedDate = dateTimePicker1.Value;
            details.Status = details.Status?.ToString();
        }
    }
}
