using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Tests : Form
    {
        Functions con;
        public Tests()
        {
            InitializeComponent();
            con = new Functions();
            ShowTests();
        }
        public void ShowTests()
        {
            string query = "SELECT * FROM Tests";
            testlist.DataSource = con.getData(query);
        }
        private void clear()
        {
            testname.Text = "";
            testcost.Text = "";
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            string name = testname.Text;
            if (name == "" || testcost.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                int cost = Convert.ToInt32(testcost.Text);
                string query = "INSERT INTO Tests Values( '{0}' , {1} )";
                query = string.Format(query, name, cost);
                con.setData(query);
                ShowTests();
                MessageBox.Show("Test Added Sucessfully!!");
                clear();
            }
        }
        int key = 0;
        private void testlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string name = testname.Text;
            if (name == "" || testcost.Text == "" || key == 0)
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                int cost = Convert.ToInt32(testcost.Text);
                string query = "UPDATE Tests SET testname= '{0}', testcost = {1} WHERE testid = {2}";
                query = string.Format(query, name, cost, key);
                con.setData(query);
                ShowTests();
                MessageBox.Show("Test Updated Successfully!!");
                clear();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select A Row");
            }
            else
            {
                string query = "DELETE FROM Tests WHERE testid=" + key;
                con.setData(query);
                ShowTests();
                clear();
                MessageBox.Show("Deleted Successfully!!");
            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void patbtn_Click(object sender, EventArgs e)
        {
            Patients obj = new Patients();
            obj.Show();
            this.Hide();
        }

        private void diagbtn_Click(object sender, EventArgs e)
        {
            Diagnosis obj = new Diagnosis();
            obj.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Working yet 😢");
        }
    }
}
