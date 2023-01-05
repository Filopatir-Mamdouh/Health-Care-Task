using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
