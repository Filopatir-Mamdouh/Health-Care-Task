using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Functions
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string constr;
        public Functions()
        {
            constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bavly Badry\source\repos\Filopatir-Mamdouh\Health-Care-Task\WindowsFormsApp1\Resources\HealthCareDB.mdf"";Integrated Security=True;Connect Timeout=30";
            con= new SqlConnection(constr);
            cmd = new SqlCommand();
            cmd.Connection= con;
        }
        public DataTable getData(String Query)
        {
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter(Query, con);
            sda.Fill(dt);
            return dt;
        }
        public int setData(String Query)
        {
            int r = 0;
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText= constr;
            r= cmd.ExecuteNonQuery();
            con.Close();
            return r;
        }
    }
}
