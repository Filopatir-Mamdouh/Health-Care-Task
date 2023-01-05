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
    public partial class Diagnosis : Form
    {
        Functions con;
        public Diagnosis()
        {
            InitializeComponent();
            con = new Functions();
            ShowDiagnosis();
            getPatients();
            getTests();
        }
        public void ShowDiagnosis()
        {
            string query = "SELECT * FROM Diagnosis";
            dlist.DataSource = con.getData(query);
        }
        public void getPatients()
        {
            string query = "SELECT * FROM Patients";
            patient.DisplayMember = con.getData(query).Columns["patname"].ToString();
            patient.ValueMember = con.getData(query).Columns["patid"].ToString();
            patient.DataSource = con.getData(query) ;
        }
        public void getTests()
        {
            string query = "SELECT * FROM Tests";
            Test.DisplayMember = con.getData(query).Columns["testname"].ToString();
            Test.ValueMember = con.getData(query).Columns["testid"].ToString();
            Test.DataSource = con.getData(query);
        }
        public void getCost()
        {
            if (Test.SelectedIndex != -1)
            {
                string query = "SELECT * FROM Tests WHERE testid = " + Test.SelectedValue.ToString();
                foreach (DataRow dr in con.getData(query).Rows)
                {
                    dcost.Text = dr["testcost"].ToString();
                }
            }
        }
        private void clear()
        {
            patient.Text = "";
            Test.SelectedIndex = -1;
            dcost.Text = "";
            result.Text = "";
            key = 0;
        }
        private void savebtn_Click(object sender, EventArgs e)
        {

            if (patient.SelectedIndex == -1 || Test.SelectedIndex == -1 || result.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                int name = Convert.ToInt32(patient.SelectedValue.ToString()); ;
                string date = dDate.Value.ToString();
                string r = result.Text;
                int test = Convert.ToInt32(Test.SelectedValue.ToString());
                int cost = Convert.ToInt32(dcost.Text);
                string query = "INSERT INTO Diagnosis Values( '{0}' , {1} , {2} , {3} , '{4}' )";
                query = string.Format(query, date, name, test, cost, r);
                con.setData(query);
                ShowDiagnosis();
                MessageBox.Show("Diagnosis Added Sucessfully!!");
                clear();
            }
        }
        int key = 0;
        private void dlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dDate.Text = dlist.SelectedRows[0].Cells[1].Value.ToString();
            patient.SelectedItem = dlist.SelectedRows[0].Cells[2].Value.ToString();
            Test.SelectedItem = dlist.SelectedRows[0].Cells[3].Value.ToString();
            dcost.Text = dlist.SelectedRows[0].Cells[4].Value.ToString();
            result.Text = dlist.SelectedRows[0].Cells[5].Value.ToString();
            if (patient.Text == "")
            {
                key = 0;
            }
            else
                key = Convert.ToInt32(dlist.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (patient.SelectedIndex == -1 || Test.SelectedIndex == -1 || result.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                int name = Convert.ToInt32(patient.SelectedValue.ToString()); ;
                string date = dDate.Value.ToString();
                string r = result.Text;
                int test = Convert.ToInt32(Test.SelectedValue.ToString());
                int cost = Convert.ToInt32(dcost.Text);
                string query = "UPDATE Diagnosis SET diagdate = '{0}' , patient = {1} , test = {2} , cost = {3} , result = '{4}' WHERE diagid = {5})";
                query = string.Format(query, date, name, test, cost, result,key);
                con.setData(query);
                ShowDiagnosis();
                MessageBox.Show("Diagnosis Updated Sucessfully!!");
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
                string query = "DELETE FROM Diagnosis WHERE diagid=" + key;
                con.setData(query);
                ShowDiagnosis();
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

        private void Testbtn_Click(object sender, EventArgs e)
        {
            Tests obj = new Tests();
            obj.Show();
            this.Hide();
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Working yet 😢");
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Testname_SelectedIndexChanged(object sender, EventArgs e)
        {
            getCost();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Patients obj = new Patients();
            obj.Show();
            this.Hide();
        }
    }
}
