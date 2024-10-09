using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Simple_Form
{
    public partial class Portal : Form
    {
        public Details details;
        public Portal()
        {
            InitializeComponent();

        }

        public Portal(Details details)
        {
            this.details = details;
            PopulateDataGrid();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<PacketDetails> packetList = GetPacketDetails();
            //dataGridView1.DataSource = packetList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //private List<PacketDetails> GetPacketDetails()
        //{

        //    List<PacketDetails> packets = new List<PacketDetails>
        //    {
        //        new PacketDetails { Code = "P001", Title = "Packet 1", Status = "Completed" },
        //        new PacketDetails { Code = "P002", Title = "Packet 2", Status = "Pending" }
        //    };

        //    return packets;
        //}
        private void PopulateDataGrid()
        {
            
            List<Details> detailsList = new List<Details>();

            
            //detailsList.Add(details);

            //dataGridView1.DataSource = detailsList;

            
            dataGridView1.Columns["LectureName"].HeaderText = "Lecture Name";
            dataGridView1.Columns["CourseTitle"].HeaderText = "Course Title";
            dataGridView1.Columns["CourseCode"].HeaderText = "Course Code";
            dataGridView1.Columns["ReceivedDate"].HeaderText = "Received Date";
            dataGridView1.Columns["Status"].HeaderText = "Status";
        }
    }
}
