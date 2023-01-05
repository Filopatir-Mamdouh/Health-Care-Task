using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Patients : Form
    {
        Functions con;
        public Patients()
        {
            InitializeComponent();
            con = new Functions();
            ShowPatients();
        }
        public void ShowPatients()
        {
            string query = "SELECT * FROM Patients";
            patlist.DataSource= con.getData(query);
        }
        private void clear()
        {
            patname.Text = "";
            patgen.Text = "";
            patphone.Text = "";
            patadd.Text = "";
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            string name = patname.Text;
            string date = DOB.Value.ToString();
            string gen= patgen.SelectedItem.ToString();
            string phone = patphone.Text;
            string add = patadd.Text;
            if (name== "" || gen=="" || phone == "" || add == "")
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                string query = "INSERT INTO Patients Values('{0}','{1}','{2}','{3},'{4}')";
                query= string.Format(query, name, gen, date, phone, add);
                con.setData(query);
                ShowPatients();
                MessageBox.Show("Patient Added Sucessfully!!");
                clear();
            }
        }
        int key = 0;
        private void patlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            patname.Text= patlist.SelectedRows[0].Cells[1].Value.ToString();
            patgen.Text = patlist.SelectedRows[0].Cells[2].Value.ToString();
            DOB.Text = patlist.SelectedRows[0].Cells[3].Value.ToString();
            patphone.Text = patlist.SelectedRows[0].Cells[4].Value.ToString();
            patadd.Text = patlist.SelectedRows[0].Cells[5].Value.ToString();
            if (patname.Text == "")
            {
                key = 0;
            }
            else
                key= Convert.ToInt32(patlist.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string name = patname.Text;
            string date = DOB.Value.ToString();
            string gen = patgen.SelectedItem.ToString();
            string phone = patphone.Text;
            string add = patadd.Text;
            if (name == "" || gen == "" || phone == "" || add == "" || key == 0)
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                string query = "UPDATE INTO Patients SET patname= '{0}', patgen = '{1}', patdob= '{2}', patphone= '{3}, pataddress= '{4}' WHERE patid = {5}";
                query = string.Format(query, name, gen, date, phone, add , key);
                con.setData(query);
                ShowPatients();
                MessageBox.Show("Patient Updated Successfully!!");
                clear();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if(key == 0)
            {
                MessageBox.Show("Select A Row");
            }
            else
            {
                string query = "DELETE FROM Patients WHERE patid=" + key;
                con.setData(query);
                ShowPatients();
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

        private void diagbtn_Click(object sender, EventArgs e)
        {
            Diagnosis obj = new Diagnosis();
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
    }
}
