﻿using System;
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
            patname.DisplayMember = con.getData(query).Columns["patname"].ToString();
            patname.ValueMember = con.getData(query).Columns["patid"].ToString();
            patname.DataSource = con.getData(query) ;
        }
        public void getTests()
        {
            string query = "SELECT * FROM Tests";
            patname.DisplayMember = con.getData(query).Columns["testname"].ToString();
            patname.ValueMember = con.getData(query).Columns["testid"].ToString();
            patname.DataSource = con.getData(query);
        }
        public void getCost()
        {
            if (Testname.SelectedIndex != -1)
            {
                string query = "SELECT * FROM Tests WHERE testid = " + Testname.SelectedValue.ToString();
                dcost.Text = con.getData(query).Columns["testcost"].ToString();
            }
        }
        private void clear()
        {
            patname.Text = "";
            Testname.SelectedIndex = -1;
            dcost.Text = "";
            result.Text = "";
        }
        private void savebtn_Click(object sender, EventArgs e)
        {

            if (patname.SelectedIndex == -1 || Testname.SelectedIndex == -1 || result.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                int name = Convert.ToInt32(patname.SelectedValue.ToString()); ;
                string date = dDate.Value.ToString();
                string r = result.Text;
                int test = Convert.ToInt32(Testname.SelectedValue.ToString());
                int cost = Convert.ToInt32(dcost.Text);
                string query = "INSERT INTO Diagnosis Values( '{0}' , {1} , {2} , {3} , '{4}' )";
                query = string.Format(query, date, name, test, cost, result);
                con.setData(query);
                ShowDiagnosis();
                MessageBox.Show("Diagnosis Added Sucessfully!!");
                clear();
            }
        }
        int key = 0;
        private void dlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            patname.Text = dlist.SelectedRows[0].Cells[1].Value.ToString();
            patgen.Text = dlist.SelectedRows[0].Cells[2].Value.ToString();
            DOB.Text = dlist.SelectedRows[0].Cells[3].Value.ToString();
            patphone.Text = dlist.SelectedRows[0].Cells[4].Value.ToString();
            patadd.Text = dlist.SelectedRows[0].Cells[5].Value.ToString();
            if (patname.Text == "")
            {
                key = 0;
            }
            else
                key = Convert.ToInt32(dlist.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string name = patname.Text;
            string date = DOB.Value.ToString();
            string phone = patphone.Text;
            string add = patadd.Text;
            if (name == "" || patgen.SelectedIndex == -1 || phone == "" || add == "" || key == 0)
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                string gen = patgen.SelectedItem.ToString();
                string query = "UPDATE Diagnosis SET patname= '{0}', patgen = '{1}', patdob= '{2}', patphone= '{3}', pataddress= '{4}' WHERE patid = {5}";
                query = string.Format(query, name, gen, date, phone, add, key);
                con.setData(query);
                ShowDiagnosis();
                MessageBox.Show("Patient Updated Successfully!!");
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
                string query = "DELETE FROM Diagnosis WHERE patid=" + key;
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

        private void Testname_SelectedIndexChanged(object sender, EventArgs e)
        {
            getCost();
        }
    }
}
