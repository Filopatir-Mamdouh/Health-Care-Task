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
            string gen= patgen.Text;
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
    }
}
